#pragma once

namespace UnrealEngine
{
	class _ULevelStreaming
	{
		static ALevelScriptActor* GetLevelScriptActor(ULevelStreaming* _this)
		{
			ALevelScriptActor* ___ret = _this->GetLevelScriptActor();
			return ___ret;
			
		}
		static int32 IsStreamingStatePending(ULevelStreaming* _this)
		{
			bool ___ret = _this->IsStreamingStatePending();
			return ___ret?1:0;
			
		}
		static int32 IsLevelLoaded(ULevelStreaming* _this)
		{
			bool ___ret = _this->IsLevelLoaded();
			return ___ret?1:0;
			
		}
		static int32 IsLevelVisible(ULevelStreaming* _this)
		{
			bool ___ret = _this->IsLevelVisible();
			return ___ret?1:0;
			
		}
		static UClass* StaticClass(){return ULevelStreaming::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.ULevelStreaming::GetLevelScriptActor",(const void*)GetLevelScriptActor);
			mono_add_internal_call("UnrealEngine.ULevelStreaming::IsStreamingStatePending",(const void*)IsStreamingStatePending);
			mono_add_internal_call("UnrealEngine.ULevelStreaming::IsLevelLoaded",(const void*)IsLevelLoaded);
			mono_add_internal_call("UnrealEngine.ULevelStreaming::IsLevelVisible",(const void*)IsLevelVisible);
			mono_add_internal_call("UnrealEngine.ULevelStreaming::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
