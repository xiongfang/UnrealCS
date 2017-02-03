#pragma once

namespace UnrealEngine
{
	class _UBoxComponent
	{
		static FVector GetUnscaledBoxExtent(UBoxComponent* _this)
		{
			FVector ___ret = _this->GetUnscaledBoxExtent();
			return ___ret;
			
		}
		static FVector GetScaledBoxExtent(UBoxComponent* _this)
		{
			FVector ___ret = _this->GetScaledBoxExtent();
			return ___ret;
			
		}
		static void SetBoxExtent(UBoxComponent* _this,FVector* InBoxExtent,int32 bUpdateOverlaps)
		{
			_this->SetBoxExtent(*InBoxExtent,bUpdateOverlaps>0?true:false);
			
		}
		static UClass* StaticClass(){return UBoxComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBoxComponent::GetUnscaledBoxExtent",(const void*)GetUnscaledBoxExtent);
			mono_add_internal_call("UnrealEngine.UBoxComponent::GetScaledBoxExtent",(const void*)GetScaledBoxExtent);
			mono_add_internal_call("UnrealEngine.UBoxComponent::SetBoxExtent",(const void*)SetBoxExtent);
			mono_add_internal_call("UnrealEngine.UBoxComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
