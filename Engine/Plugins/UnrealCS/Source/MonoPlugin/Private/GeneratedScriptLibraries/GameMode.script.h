#pragma once

namespace UnrealEngine
{
	class _AGameMode
	{
		static void SetBandwidthLimit(AGameMode* _this,float AsyncIOBandwidthLimit)
		{
			_this->SetBandwidthLimit(AsyncIOBandwidthLimit);
			
		}
		static void Say(AGameMode* _this,MonoString* Msg)
		{
			FString Msg_temp=MonoStringToFString(Msg);
			_this->Say(Msg_temp);
			
		}
		static void AbortMatch(AGameMode* _this)
		{
			_this->AbortMatch();
			
		}
		static void RestartGame(AGameMode* _this)
		{
			_this->RestartGame();
			
		}
		static void EndMatch(AGameMode* _this)
		{
			_this->EndMatch();
			
		}
		static void StartMatch(AGameMode* _this)
		{
			_this->StartMatch();
			
		}
		static int32 HasMatchEnded(AGameMode* _this)
		{
			bool ___ret = _this->HasMatchEnded();
			return ___ret?1:0;
			
		}
		static int32 IsMatchInProgress(AGameMode* _this)
		{
			bool ___ret = _this->IsMatchInProgress();
			return ___ret?1:0;
			
		}
		static MonoString* GetMatchState(AGameMode* _this)
		{
			FName ___ret = _this->GetMatchState();
			return FNameToMonoString(___ret);
			
		}
		static UClass* StaticClass(){return AGameMode::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AGameMode::SetBandwidthLimit",(const void*)SetBandwidthLimit);
			mono_add_internal_call("UnrealEngine.AGameMode::Say",(const void*)Say);
			mono_add_internal_call("UnrealEngine.AGameMode::AbortMatch",(const void*)AbortMatch);
			mono_add_internal_call("UnrealEngine.AGameMode::RestartGame",(const void*)RestartGame);
			mono_add_internal_call("UnrealEngine.AGameMode::EndMatch",(const void*)EndMatch);
			mono_add_internal_call("UnrealEngine.AGameMode::StartMatch",(const void*)StartMatch);
			mono_add_internal_call("UnrealEngine.AGameMode::HasMatchEnded",(const void*)HasMatchEnded);
			mono_add_internal_call("UnrealEngine.AGameMode::IsMatchInProgress",(const void*)IsMatchInProgress);
			mono_add_internal_call("UnrealEngine.AGameMode::GetMatchState",(const void*)GetMatchState);
			mono_add_internal_call("UnrealEngine.AGameMode::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
