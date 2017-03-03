#pragma once

namespace UnrealEngine
{
	class _UPhysicsSpringComponent
	{
		static FVector GetSpringDirection(UPhysicsSpringComponent* _this)
		{
			FVector ___ret = _this->GetSpringDirection();
			return ___ret;
			
		}
		static FVector GetSpringCurrentEndPoint(UPhysicsSpringComponent* _this)
		{
			FVector ___ret = _this->GetSpringCurrentEndPoint();
			return ___ret;
			
		}
		static FVector GetSpringRestingPoint(UPhysicsSpringComponent* _this)
		{
			FVector ___ret = _this->GetSpringRestingPoint();
			return ___ret;
			
		}
		static float GetNormalizedCompressionScalar(UPhysicsSpringComponent* _this)
		{
			float ___ret = _this->GetNormalizedCompressionScalar();
			return ___ret;
			
		}
		static UClass* StaticClass(){return UPhysicsSpringComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UPhysicsSpringComponent::GetSpringDirection",(const void*)GetSpringDirection);
			mono_add_internal_call("UnrealEngine.UPhysicsSpringComponent::GetSpringCurrentEndPoint",(const void*)GetSpringCurrentEndPoint);
			mono_add_internal_call("UnrealEngine.UPhysicsSpringComponent::GetSpringRestingPoint",(const void*)GetSpringRestingPoint);
			mono_add_internal_call("UnrealEngine.UPhysicsSpringComponent::GetNormalizedCompressionScalar",(const void*)GetNormalizedCompressionScalar);
			mono_add_internal_call("UnrealEngine.UPhysicsSpringComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
