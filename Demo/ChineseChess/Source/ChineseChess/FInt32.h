#pragma once
#include "Object.h"
#include "FInt32.generated.h"
class Int32;
USTRUCT()
struct FInt32
{
	GENERATED_BODY()
	public:
	static Int32 ToInt32(FInt32  v);
	public:
	FInt32 FromInt32(Int32  v);
	public:
	Int32 ToInt32();

public:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
		int _v;
};
