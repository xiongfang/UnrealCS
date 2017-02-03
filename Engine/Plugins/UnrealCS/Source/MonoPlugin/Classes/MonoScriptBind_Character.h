// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt
#pragma once
#include "MonoScriptBind_Character.generated.h"

UCLASS()
class MONOPLUGIN_API AMonoScriptBind_Character : public ACharacter
{
	GENERATED_BODY()

public:
	AMonoScriptBind_Character();
	virtual void BeginPlay() override;
	virtual void Tick(float DeltaSeconds) override;
	virtual void BeginDestroy() override;


#if WITH_MONO_HOTRELOAD
	void HotReload();
#endif
protected:
	TAutoPtr<FScriptContextBase> Context;
};