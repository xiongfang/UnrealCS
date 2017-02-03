#pragma once

namespace UnrealEngine
{
	class _ACameraActor
	{
		static int32 GetAutoActivatePlayerIndex(ACameraActor* _this)
		{
			int32 ___ret = _this->GetAutoActivatePlayerIndex();
			return ___ret;
			
		}
		static UClass* StaticClass(){return ACameraActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ACameraActor::GetAutoActivatePlayerIndex",(const void*)GetAutoActivatePlayerIndex);
			mono_add_internal_call("UnrealEngine.ACameraActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
