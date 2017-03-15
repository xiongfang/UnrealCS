// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#include "MonoScriptBind_PlayerController.h"
#include "MonoPluginPrivatePCH.h"


AMonoScriptBind_PlayerController::AMonoScriptBind_PlayerController()
{
}

#if WITH_MONO_HOTRELOAD
void AMonoScriptBind_PlayerController::HotReload()
{
	if (Context)
	{
		Context->EndHotReload();
	}
}
#endif

void AMonoScriptBind_PlayerController::BeginPlay()
{
	Super::BeginPlay();
#if WITH_MONO_HOTRELOAD
	if (FMonoDomain::Get() != NULL)
	{
		FMonoDomain::Get()->eventEndHotReload.AddUObject(this, &AMonoScriptBind_PlayerController::HotReload);
	}
#endif
	auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
	if (ScriptClass && GetWorld() && GetWorld()->WorldType != EWorldType::Editor)
	{
		Context.Reset(FScriptContextBase::CreateContext(ScriptClass->ClassName, ScriptClass, this));
	}

	if (Context)
	{
		Context->PushScriptPropertyValues(ScriptClass, this);
		Context->BeginPlay();
		Context->FetchScriptPropertyValues(ScriptClass, this);
	}
}
void AMonoScriptBind_PlayerController::Tick(float DeltaSeconds)
{
	Super::Tick(DeltaSeconds);
	if (Context)
	{
		auto ScriptClass = UMonoScriptClass::GetScriptGeneratedClass(GetClass());
		Context->PushScriptPropertyValues(ScriptClass, this);
		Context->Tick(DeltaSeconds);
		Context->FetchScriptPropertyValues(ScriptClass, this);
	}
}
void AMonoScriptBind_PlayerController::BeginDestroy()
{
	if (Context)
	{
		Context->Destroy();
		Context = NULL;
	}

#if WITH_MONO_HOTRELOAD
	if (FMonoDomain::Get() != NULL)
	{
		FMonoDomain::Get()->eventEndHotReload.RemoveAll(this);
	}
#endif
	Super::BeginDestroy();
}

void AMonoScriptBind_PlayerController::UpdateCameraManager(float DeltaSeconds)
{
	Super::UpdateCameraManager(DeltaSeconds);
}