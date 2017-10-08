#pragma once
#include "Runtime/Engine/Classes/GameFramework/Pawn.h"
#include "FInt32.h"
class AActor;
#include "AMyPlayer.generated.h"
UCLASS()
class AMyPlayer:public APawn
{
	GENERATED_BODY()
	public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
		FInt32 why;
	public:
	UFUNCTION(BlueprintCallable)
	void Say();
	public:
	
	void SetOwner(AActor*  NewOwner);
	public:
	
	virtual void Hello();
};
