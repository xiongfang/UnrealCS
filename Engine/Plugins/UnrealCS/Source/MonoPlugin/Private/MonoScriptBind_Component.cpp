// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoScriptBind_Component.h"
#include "MonoPluginPrivatePCH.h"

//#if WITH_MONO
#include "MonoDomain.h"
#include "MonoScriptClass.h"
#include "MonoIntegration.h"

UMonoScriptBind_Component::UMonoScriptBind_Component(const FObjectInitializer& ObjectInitializer)
	: Super(ObjectInitializer)
{
	PrimaryComponentTick.bCanEverTick = true;
	bTickInEditor = false;
	bAutoActivate = true;
	bWantsInitializeComponent = true;

}

void UMonoScriptBind_Component::OnRegister()
{
	Super::OnRegister();


#if WITH_MONO_HOTRELOAD
	if (FMonoDomain::Get() != NULL)
	{
		FMonoDomain::Get()->eventBeginHotReload.AddUObject(this, &UMonoScriptBind_Component::BeginHotReload);
		FMonoDomain::Get()->eventEndHotReload.AddUObject(this, &UMonoScriptBind_Component::EndHotReload);
	}
#endif
	auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
	if (ScriptClass && GetWorld() && GetWorld()->WorldType != EWorldType::Editor)
	{
		Context.Reset(FScriptContextBase::CreateContext(ScriptClass->ClassName, ScriptClass, this));
		if (!Context)
		{
			bAutoActivate = false;
			PrimaryComponentTick.bCanEverTick = false;
		}
		else
		{

			//初始化的时候，同步一次属性
			Context->PushScriptPropertyValues(ScriptClass, this);

			HotReloadData();
			if (methodOnRegister)
			{
				Context->Invoke(methodOnRegister, nullptr);
				if(SyncProperty)
					Context->FetchScriptPropertyValues(ScriptClass, this);
			}
		}
	}
}

//初始化默认参数
void UMonoScriptBind_Component::InitDefault()
{
	auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
	if (ScriptClass)
	{
		TUniquePtr<FScriptContextBase> TempContext;
		TempContext.Reset(FScriptContextBase::CreateContext(ScriptClass->ClassName, ScriptClass, this));
		if (!TempContext)
		{
			bAutoActivate = false;
			PrimaryComponentTick.bCanEverTick = false;
		}
		else
		{
			if (HasAnyFlags(RF_ClassDefaultObject))
				TempContext->FetchScriptPropertyValues(ScriptClass, this);

			//移除上下文，这样就不必要热更新了（默认对象只需要属性）
			TempContext = nullptr;
		}
	}
}
void UMonoScriptBind_Component::OnUnregister()
{
	if (Context && methodOnUnregister)
	{
		auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
		if (SyncProperty)
			Context->PushScriptPropertyValues(ScriptClass, this);
		Context->Invoke(methodOnUnregister, nullptr);
		if (SyncProperty)
			Context->FetchScriptPropertyValues(ScriptClass, this);
	}
	Super::OnUnregister();
}
void UMonoScriptBind_Component::InitializeComponent()
{
	Super::InitializeComponent();
	if (Context && methodInitializeComponent)
	{
		auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
		if (SyncProperty)
			Context->PushScriptPropertyValues(ScriptClass, this);
		Context->Invoke(methodInitializeComponent, nullptr);
		if (SyncProperty)
			Context->FetchScriptPropertyValues(ScriptClass, this);
	}
}

void UMonoScriptBind_Component::BeginPlay()
{
	Super::BeginPlay();
	if (Context)
	{
		auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
		if (SyncProperty)
			Context->PushScriptPropertyValues(ScriptClass, this);
		Context->BeginPlay();
		if (SyncProperty)
			Context->FetchScriptPropertyValues(ScriptClass, this);
	}
}
void UMonoScriptBind_Component::TickComponent(float DeltaTime, enum ELevelTick TickType, FActorComponentTickFunction *ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);
	if (Context)
	{
		auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
		if (SyncProperty)
			Context->PushScriptPropertyValues(ScriptClass, this);
		Context->Tick(DeltaTime);
		if (SyncProperty)
			Context->FetchScriptPropertyValues(ScriptClass, this);
	}
};

void UMonoScriptBind_Component::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	if (Context)
	{
		auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
		if (SyncProperty)
			Context->PushScriptPropertyValues(ScriptClass, this);
		Context->EndPlay(EndPlayReason);
		if (SyncProperty)
			Context->FetchScriptPropertyValues(ScriptClass, this);
	}

	Super::EndPlay(EndPlayReason);
}

void UMonoScriptBind_Component::BeginDestroy()
{
	if (Context)
	{
		auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
		if (SyncProperty)
			Context->PushScriptPropertyValues(ScriptClass, this);
		Context->Destroy();
		Context = NULL;
	}

#if WITH_MONO_HOTRELOAD
	if (FMonoDomain::Get() != NULL)
	{
		FMonoDomain::Get()->eventBeginHotReload.RemoveAll(this);
		FMonoDomain::Get()->eventEndHotReload.RemoveAll(this);
	}
#endif
	Super::BeginDestroy();
}

void UMonoScriptBind_Component::InvokeMonoEventThunk(FFrame& Stack, RESULT_DECL)
{
	if (Context)
	{
		Context->InvokeScriptFunction(Stack, RESULT_PARAM);
	}

	P_FINISH;
}

void UMonoScriptBind_Component::HotReloadData()
{
	//查找方法
	FMonoContext* MonoContext = (FMonoContext*)Context.Get();
	methodInitializeComponent = MonoContext->FindMethod("InitializeComponent", 0);
	methodOnRegister = MonoContext->FindMethod("OnRegister", 0);
	methodOnUnregister = MonoContext->FindMethod("OnUnregister", 0);
}
#if WITH_MONO_HOTRELOAD
void UMonoScriptBind_Component::EndHotReload()
{
	if (Context)
	{
		Context->EndHotReload();
		HotReloadData();
		auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
		Context->PushScriptPropertyValues(ScriptClass, this);
	}
}

void UMonoScriptBind_Component::BeginHotReload()
{
	if (Context)
	{
		Context->BeginHotReload();
	}
}
#endif

#if WITH_EDITOR
void UMonoScriptBind_Component::PostEditChangeProperty
(
	struct FPropertyChangedEvent & PropertyChangedEvent
)
{
	if (Context)
	{
		auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
		Context->PushScriptPropertyValues(ScriptClass, this);
	}
}
#endif

//#endif