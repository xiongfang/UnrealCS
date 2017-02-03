#pragma once

namespace UnrealEngine
{
	class _USkeletalMeshSocket
	{
		static void InitializeSocketFromLocation(USkeletalMeshSocket* _this,USkeletalMeshComponent* SkelComp,FVector* WorldLocation,FVector* WorldNormal)
		{
			_this->InitializeSocketFromLocation(SkelComp,*WorldLocation,*WorldNormal);
			
		}
		static FVector GetSocketLocation(USkeletalMeshSocket* _this,USkeletalMeshComponent* SkelComp)
		{
			FVector ___ret = _this->GetSocketLocation(SkelComp);
			return ___ret;
			
		}
		static UClass* StaticClass(){return USkeletalMeshSocket::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USkeletalMeshSocket::InitializeSocketFromLocation",(const void*)InitializeSocketFromLocation);
			mono_add_internal_call("UnrealEngine.USkeletalMeshSocket::GetSocketLocation",(const void*)GetSocketLocation);
			mono_add_internal_call("UnrealEngine.USkeletalMeshSocket::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
