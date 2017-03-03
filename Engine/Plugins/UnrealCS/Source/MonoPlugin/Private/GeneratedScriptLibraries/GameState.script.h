#pragma once

namespace UnrealEngine
{
	class _AGameState
	{
		static void OnRep_ElapsedTime(AGameState* _this)
		{
			_this->OnRep_ElapsedTime();
			
		}
		static void OnRep_MatchState(AGameState* _this)
		{
			_this->OnRep_MatchState();
			
		}
		static UClass* StaticClass(){return AGameState::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AGameState::OnRep_ElapsedTime",(const void*)OnRep_ElapsedTime);
			mono_add_internal_call("UnrealEngine.AGameState::OnRep_MatchState",(const void*)OnRep_MatchState);
			mono_add_internal_call("UnrealEngine.AGameState::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
