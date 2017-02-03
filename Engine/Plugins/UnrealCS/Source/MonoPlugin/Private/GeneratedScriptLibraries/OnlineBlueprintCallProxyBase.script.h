#pragma once

namespace UnrealEngine
{
	class _UOnlineBlueprintCallProxyBase
	{
		static void Activate(UOnlineBlueprintCallProxyBase* _this)
		{
			_this->Activate();
			
		}
		static UClass* StaticClass(){return UOnlineBlueprintCallProxyBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UOnlineBlueprintCallProxyBase::Activate",(const void*)Activate);
			mono_add_internal_call("UnrealEngine.UOnlineBlueprintCallProxyBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
