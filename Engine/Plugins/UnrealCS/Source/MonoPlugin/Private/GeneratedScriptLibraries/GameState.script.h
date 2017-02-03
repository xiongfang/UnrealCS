#pragma once

namespace UnrealEngine
{
	class _AGameState
	{
		static float GetServerWorldTimeSeconds(AGameState* _this)
		{
			float ___ret = _this->GetServerWorldTimeSeconds();
			return ___ret;
			
		}
		static void OnRep_ElapsedTime(AGameState* _this)
		{
			_this->OnRep_ElapsedTime();
			
		}
		static void OnRep_MatchState(AGameState* _this)
		{
			_this->OnRep_MatchState();
			
		}
		static void OnRep_SpectatorClass(AGameState* _this)
		{
			_this->OnRep_SpectatorClass();
			
		}
		static void OnRep_GameModeClass(AGameState* _this)
		{
			_this->OnRep_GameModeClass();
			
		}
		static UClass* StaticClass(){return AGameState::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AGameState::GetServerWorldTimeSeconds",(const void*)GetServerWorldTimeSeconds);
			mono_add_internal_call("UnrealEngine.AGameState::OnRep_ElapsedTime",(const void*)OnRep_ElapsedTime);
			mono_add_internal_call("UnrealEngine.AGameState::OnRep_MatchState",(const void*)OnRep_MatchState);
			mono_add_internal_call("UnrealEngine.AGameState::OnRep_SpectatorClass",(const void*)OnRep_SpectatorClass);
			mono_add_internal_call("UnrealEngine.AGameState::OnRep_GameModeClass",(const void*)OnRep_GameModeClass);
			mono_add_internal_call("UnrealEngine.AGameState::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
