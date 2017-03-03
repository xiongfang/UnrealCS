#pragma once

namespace UnrealEngine
{
	class _UBlueprintAsyncActionBase
	{
		static void Activate(UBlueprintAsyncActionBase* _this)
		{
			_this->Activate();
			
		}
		static UClass* StaticClass(){return UBlueprintAsyncActionBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UBlueprintAsyncActionBase::Activate",(const void*)Activate);
			mono_add_internal_call("UnrealEngine.UBlueprintAsyncActionBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
