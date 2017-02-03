#pragma once

namespace UnrealEngine
{
	class _URadialForceComponent
	{
		static void RemoveObjectTypeToAffect(URadialForceComponent* _this,int32 ObjectType)
		{
			_this->RemoveObjectTypeToAffect((TEnumAsByte<EObjectTypeQuery>)ObjectType);
			
		}
		static void AddObjectTypeToAffect(URadialForceComponent* _this,int32 ObjectType)
		{
			_this->AddObjectTypeToAffect((TEnumAsByte<EObjectTypeQuery>)ObjectType);
			
		}
		static void FireImpulse(URadialForceComponent* _this)
		{
			_this->FireImpulse();
			
		}
		static UClass* StaticClass(){return URadialForceComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.URadialForceComponent::RemoveObjectTypeToAffect",(const void*)RemoveObjectTypeToAffect);
			mono_add_internal_call("UnrealEngine.URadialForceComponent::AddObjectTypeToAffect",(const void*)AddObjectTypeToAffect);
			mono_add_internal_call("UnrealEngine.URadialForceComponent::FireImpulse",(const void*)FireImpulse);
			mono_add_internal_call("UnrealEngine.URadialForceComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
