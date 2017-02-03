// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once
namespace UnrealEngine
{
	class _UWorld_Ext
	{
		static AActor* SpawnActor(UWorld* _this, UClass* Class, FVector* Location, FRotator* Rotation)
		{
			return _this->SpawnActor(Class, Location, Rotation);
		}

	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UWorld::SpawnActor", (const void*)SpawnActor);
		}
	};
}
