#pragma once

namespace UnrealEngine
{
	class _UDestructibleComponent
	{
		static UDestructibleMesh* GetDestructibleMesh(UDestructibleComponent* _this)
		{
			UDestructibleMesh* ___ret = _this->GetDestructibleMesh();
			return ___ret;
			
		}
		static void SetDestructibleMesh(UDestructibleComponent* _this,UDestructibleMesh* NewMesh)
		{
			_this->SetDestructibleMesh(NewMesh);
			
		}
		static void ApplyRadiusDamage(UDestructibleComponent* _this,float BaseDamage,FVector* HurtOrigin,float DamageRadius,float ImpulseStrength,int32 bFullDamage)
		{
			_this->ApplyRadiusDamage(BaseDamage,*HurtOrigin,DamageRadius,ImpulseStrength,bFullDamage>0?true:false);
			
		}
		static void ApplyDamage(UDestructibleComponent* _this,float DamageAmount,FVector* HitLocation,FVector* ImpulseDir,float ImpulseStrength)
		{
			_this->ApplyDamage(DamageAmount,*HitLocation,*ImpulseDir,ImpulseStrength);
			
		}
		static UClass* StaticClass(){return UDestructibleComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UDestructibleComponent::GetDestructibleMesh",(const void*)GetDestructibleMesh);
			mono_add_internal_call("UnrealEngine.UDestructibleComponent::SetDestructibleMesh",(const void*)SetDestructibleMesh);
			mono_add_internal_call("UnrealEngine.UDestructibleComponent::ApplyRadiusDamage",(const void*)ApplyRadiusDamage);
			mono_add_internal_call("UnrealEngine.UDestructibleComponent::ApplyDamage",(const void*)ApplyDamage);
			mono_add_internal_call("UnrealEngine.UDestructibleComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
