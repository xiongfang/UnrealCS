#pragma once

namespace UnrealEngine
{
	class _USpacer
	{
		static void SetSize(USpacer* _this,FVector2D* InSize)
		{
			_this->SetSize(*InSize);
			
		}
		static UClass* StaticClass(){return USpacer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.USpacer::SetSize",(const void*)SetSize);
			mono_add_internal_call("UnrealEngine.USpacer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
