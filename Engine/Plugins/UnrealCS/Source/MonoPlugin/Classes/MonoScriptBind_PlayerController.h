// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
#include "MonoScriptBind_PlayerController.generated.h"

UCLASS()
class MONOPLUGIN_API AMonoScriptBind_PlayerController : public APlayerController
{
	GENERATED_BODY()

public:
	AMonoScriptBind_PlayerController();
	virtual void BeginPlay() override;
	virtual void Tick(float DeltaSeconds) override;
	virtual void BeginDestroy() override;

	virtual void UpdateCameraManager(float DeltaSeconds) override;

#if WITH_MONO_HOTRELOAD
	void HotReload();
#endif
protected:
	TUniquePtr<FScriptContextBase> Context;
};