// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#pragma once
#include "AIController.h"
#include "MonoScriptBind_AIController.generated.h"

UCLASS()
class MONOPLUGIN_API AMonoScriptBind_AIController : public AAIController
{
	GENERATED_BODY()

public:
	AMonoScriptBind_AIController();
	virtual void BeginPlay() override;
	virtual void Tick(float DeltaSeconds) override;
	virtual void BeginDestroy() override;


#if WITH_MONO_HOTRELOAD
	void HotReload();
#endif
protected:
	TUniquePtr<FScriptContextBase> Context;
};