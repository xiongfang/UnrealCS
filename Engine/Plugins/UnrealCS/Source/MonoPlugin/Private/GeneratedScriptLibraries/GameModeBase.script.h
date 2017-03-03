#pragma once

namespace UnrealEngine
{
	class _AGameModeBase
	{
		static void RestartPlayerAtTransform(AGameModeBase* _this,AController* NewPlayer,FTransform* SpawnTransform)
		{
			_this->RestartPlayerAtTransform(NewPlayer,*SpawnTransform);
			
		}
		static void RestartPlayerAtPlayerStart(AGameModeBase* _this,AController* NewPlayer,AActor* StartSpot)
		{
			_this->RestartPlayerAtPlayerStart(NewPlayer,StartSpot);
			
		}
		static void RestartPlayer(AGameModeBase* _this,AController* NewPlayer)
		{
			_this->RestartPlayer(NewPlayer);
			
		}
		static AActor* K2_FindPlayerStart(AGameModeBase* _this,AController* Player,MonoString* IncomingName)
		{
			FString IncomingName_temp=MonoStringToFString(IncomingName);
			AActor* ___ret = _this->K2_FindPlayerStart(Player,IncomingName_temp);
			return ___ret;
			
		}
		static void ChangeName(AGameModeBase* _this,AController* Controller,MonoString* NewName,int32 bNameChange)
		{
			FString NewName_temp=MonoStringToFString(NewName);
			_this->ChangeName(Controller,NewName_temp,bNameChange>0?true:false);
			
		}
		static void ReturnToMainMenuHost(AGameModeBase* _this)
		{
			_this->ReturnToMainMenuHost();
			
		}
		static void ResetLevel(AGameModeBase* _this)
		{
			_this->ResetLevel();
			
		}
		static int32 HasMatchStarted(AGameModeBase* _this)
		{
			bool ___ret = _this->HasMatchStarted();
			return ___ret?1:0;
			
		}
		static void StartPlay(AGameModeBase* _this)
		{
			_this->StartPlay();
			
		}
		static int32 GetNumSpectators(AGameModeBase* _this)
		{
			int32 ___ret = _this->GetNumSpectators();
			return ___ret;
			
		}
		static int32 GetNumPlayers(AGameModeBase* _this)
		{
			int32 ___ret = _this->GetNumPlayers();
			return ___ret;
			
		}
		static UClass* StaticClass(){return AGameModeBase::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AGameModeBase::RestartPlayerAtTransform",(const void*)RestartPlayerAtTransform);
			mono_add_internal_call("UnrealEngine.AGameModeBase::RestartPlayerAtPlayerStart",(const void*)RestartPlayerAtPlayerStart);
			mono_add_internal_call("UnrealEngine.AGameModeBase::RestartPlayer",(const void*)RestartPlayer);
			mono_add_internal_call("UnrealEngine.AGameModeBase::K2_FindPlayerStart",(const void*)K2_FindPlayerStart);
			mono_add_internal_call("UnrealEngine.AGameModeBase::ChangeName",(const void*)ChangeName);
			mono_add_internal_call("UnrealEngine.AGameModeBase::ReturnToMainMenuHost",(const void*)ReturnToMainMenuHost);
			mono_add_internal_call("UnrealEngine.AGameModeBase::ResetLevel",(const void*)ResetLevel);
			mono_add_internal_call("UnrealEngine.AGameModeBase::HasMatchStarted",(const void*)HasMatchStarted);
			mono_add_internal_call("UnrealEngine.AGameModeBase::StartPlay",(const void*)StartPlay);
			mono_add_internal_call("UnrealEngine.AGameModeBase::GetNumSpectators",(const void*)GetNumSpectators);
			mono_add_internal_call("UnrealEngine.AGameModeBase::GetNumPlayers",(const void*)GetNumPlayers);
			mono_add_internal_call("UnrealEngine.AGameModeBase::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
