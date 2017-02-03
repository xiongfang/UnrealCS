#pragma once

namespace UnrealEngine
{
	class _AGameMode
	{
		static AActor* K2_FindPlayerStart(AGameMode* _this,AController* Player)
		{
			AActor* ___ret = _this->K2_FindPlayerStart(Player);
			return ___ret;
			
		}
		static void ChangeName(AGameMode* _this,AController* Controller,MonoString* NewName,int32 bNameChange)
		{
			FString NewName_temp=MonoStringToFString(NewName);
			_this->ChangeName(Controller,NewName_temp,bNameChange>0?true:false);
			
		}
		static int32 GetNumPlayers(AGameMode* _this)
		{
			int32 ___ret = _this->GetNumPlayers();
			return ___ret;
			
		}
		static void ResetLevel(AGameMode* _this)
		{
			_this->ResetLevel();
			
		}
		static void SetBandwidthLimit(AGameMode* _this,float AsyncIOBandwidthLimit)
		{
			_this->SetBandwidthLimit(AsyncIOBandwidthLimit);
			
		}
		static void AbortMatch(AGameMode* _this)
		{
			_this->AbortMatch();
			
		}
		static void ReturnToMainMenuHost(AGameMode* _this)
		{
			_this->ReturnToMainMenuHost();
			
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
		static void StartPlay(AGameMode* _this)
		{
			_this->StartPlay();
			
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
		static int32 HasMatchStarted(AGameMode* _this)
		{
			bool ___ret = _this->HasMatchStarted();
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
			mono_add_internal_call("UnrealEngine.AGameMode::K2_FindPlayerStart",(const void*)K2_FindPlayerStart);
			mono_add_internal_call("UnrealEngine.AGameMode::ChangeName",(const void*)ChangeName);
			mono_add_internal_call("UnrealEngine.AGameMode::GetNumPlayers",(const void*)GetNumPlayers);
			mono_add_internal_call("UnrealEngine.AGameMode::ResetLevel",(const void*)ResetLevel);
			mono_add_internal_call("UnrealEngine.AGameMode::SetBandwidthLimit",(const void*)SetBandwidthLimit);
			mono_add_internal_call("UnrealEngine.AGameMode::AbortMatch",(const void*)AbortMatch);
			mono_add_internal_call("UnrealEngine.AGameMode::ReturnToMainMenuHost",(const void*)ReturnToMainMenuHost);
			mono_add_internal_call("UnrealEngine.AGameMode::RestartGame",(const void*)RestartGame);
			mono_add_internal_call("UnrealEngine.AGameMode::EndMatch",(const void*)EndMatch);
			mono_add_internal_call("UnrealEngine.AGameMode::StartMatch",(const void*)StartMatch);
			mono_add_internal_call("UnrealEngine.AGameMode::StartPlay",(const void*)StartPlay);
			mono_add_internal_call("UnrealEngine.AGameMode::HasMatchEnded",(const void*)HasMatchEnded);
			mono_add_internal_call("UnrealEngine.AGameMode::IsMatchInProgress",(const void*)IsMatchInProgress);
			mono_add_internal_call("UnrealEngine.AGameMode::HasMatchStarted",(const void*)HasMatchStarted);
			mono_add_internal_call("UnrealEngine.AGameMode::GetMatchState",(const void*)GetMatchState);
			mono_add_internal_call("UnrealEngine.AGameMode::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
