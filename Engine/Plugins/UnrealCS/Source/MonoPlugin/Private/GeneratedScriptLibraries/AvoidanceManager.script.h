#pragma once

namespace UnrealEngine
{
	class _UAvoidanceManager
	{
		static FVector GetAvoidanceVelocity(UAvoidanceManager* _this,FNavAvoidanceData* AvoidanceData,float DeltaTime)
		{
			FVector ___ret = _this->GetAvoidanceVelocity(*AvoidanceData,DeltaTime);
			return ___ret;
			
		}
		static FVector GetAvoidanceVelocityIgnoringUID(UAvoidanceManager* _this,FNavAvoidanceData* AvoidanceData,float DeltaTime,int32 IgnoreThisUID)
		{
			FVector ___ret = _this->GetAvoidanceVelocityIgnoringUID(*AvoidanceData,DeltaTime,IgnoreThisUID);
			return ___ret;
			
		}
		static FVector GetAvoidanceVelocityForComponent(UAvoidanceManager* _this,UMovementComponent* MovementComp)
		{
			FVector ___ret = _this->GetAvoidanceVelocityForComponent(MovementComp);
			return ___ret;
			
		}
		static int32 RegisterMovementComponent(UAvoidanceManager* _this,UMovementComponent* MovementComp,float AvoidanceWeight)
		{
			bool ___ret = _this->RegisterMovementComponent(MovementComp,AvoidanceWeight);
			return ___ret?1:0;
			
		}
		static int32 GetNewAvoidanceUID(UAvoidanceManager* _this)
		{
			int32 ___ret = _this->GetNewAvoidanceUID();
			return ___ret;
			
		}
		static int32 GetObjectCount(UAvoidanceManager* _this)
		{
			int32 ___ret = _this->GetObjectCount();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UAvoidanceManager::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAvoidanceManager::GetAvoidanceVelocity",(const void*)GetAvoidanceVelocity);
			mono_add_internal_call("UnrealEngine.UAvoidanceManager::GetAvoidanceVelocityIgnoringUID",(const void*)GetAvoidanceVelocityIgnoringUID);
			mono_add_internal_call("UnrealEngine.UAvoidanceManager::GetAvoidanceVelocityForComponent",(const void*)GetAvoidanceVelocityForComponent);
			mono_add_internal_call("UnrealEngine.UAvoidanceManager::RegisterMovementComponent",(const void*)RegisterMovementComponent);
			mono_add_internal_call("UnrealEngine.UAvoidanceManager::GetNewAvoidanceUID",(const void*)GetNewAvoidanceUID);
			mono_add_internal_call("UnrealEngine.UAvoidanceManager::GetObjectCount",(const void*)GetObjectCount);
			mono_add_internal_call("UnrealEngine.UAvoidanceManager::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
