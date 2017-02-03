// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "Components/ActorComponent.h"
#include "MonoScriptBind_Component.generated.h"

class FScriptContextBase;
typedef struct _MonoMethod MonoMethod;
/**
* Script-extendable component class
*/
UCLASS()
class MONOPLUGIN_API UMonoScriptBind_Component : public UActorComponent
{
	GENERATED_UCLASS_BODY()

public:
	UPROPERTY(Category = Script,EditAnywhere)
	bool SyncProperty;

	// Begin UActorComponent interface.
	virtual void OnRegister() override;
	virtual void OnUnregister() override;
	virtual void InitializeComponent() override;
	// Called when the game starts
	virtual void BeginPlay() override;
	virtual void TickComponent(float DeltaTime, enum ELevelTick TickType, FActorComponentTickFunction *ThisTickFunction) override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
	virtual void BeginDestroy() override;
	// Begin UActorComponent interface.

	//UFUNCTION(BlueprintCallable, Category = "ScriptContext")
	//bool CallScriptFunction(FString FunctionName);

	void InvokeMonoEventThunk(FFrame& Stack, RESULT_DECL);

#if WITH_EDITOR
	virtual void PostEditChangeProperty
	(
		struct FPropertyChangedEvent & PropertyChangedEvent
	) override;
#endif
#if WITH_MONO_HOTRELOAD
	void BeginHotReload();
	void EndHotReload();
#endif

	//初始化默认参数
	void InitDefault();

	//_UObject需要用到这个方法
	FScriptContextBase* GetContext() { return Context; }
protected:
	void HotReloadData();

	MonoMethod* methodInitializeComponent;
	MonoMethod* methodOnRegister;
	MonoMethod* methodOnUnregister;

	TAutoPtr<FScriptContextBase> Context;
};