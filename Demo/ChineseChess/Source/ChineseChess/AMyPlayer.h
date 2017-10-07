#pragma once
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"
#include "FInt32.h"
#include "AMyPlayer.generated.h"
class AActor;

UCLASS()
class AMyPlayer:public APawn
{
	GENERATED_BODY()
	public:
		UPROPERTY(EditAnywhere, BlueprintReadWrite)
			FInt32 why2;
	public:
	UFUNCTION(BlueprintCallable)
	void Say();
	public:
	void SetOwner(AActor*  NewOwner);
	public:
	virtual void Hello();
};
