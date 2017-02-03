#pragma once

namespace UnrealEngine
{
	class _UCameraAnimInst
	{
		static void SetScale(UCameraAnimInst* _this,float NewDuration)
		{
			_this->SetScale(NewDuration);
			
		}
		static void SetDuration(UCameraAnimInst* _this,float NewDuration)
		{
			_this->SetDuration(NewDuration);
			
		}
		static void Stop(UCameraAnimInst* _this,int32 bImmediate)
		{
			_this->Stop(bImmediate>0?true:false);
			
		}
		static UClass* StaticClass(){return UCameraAnimInst::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCameraAnimInst::SetScale",(const void*)SetScale);
			mono_add_internal_call("UnrealEngine.UCameraAnimInst::SetDuration",(const void*)SetDuration);
			mono_add_internal_call("UnrealEngine.UCameraAnimInst::Stop",(const void*)Stop);
			mono_add_internal_call("UnrealEngine.UCameraAnimInst::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
