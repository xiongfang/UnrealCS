#pragma once

namespace UnrealEngine
{
	class _UCheatManager
	{
		static void CheatScript(UCheatManager* _this,MonoString* ScriptName)
		{
			FString ScriptName_temp=MonoStringToFString(ScriptName);
			_this->CheatScript(ScriptName_temp);
			
		}
		static void InvertMouse(UCheatManager* _this)
		{
			_this->InvertMouse();
			
		}
		static void SetMouseSensitivityToDefault(UCheatManager* _this)
		{
			_this->SetMouseSensitivityToDefault();
			
		}
		static void SetWorldOrigin(UCheatManager* _this)
		{
			_this->SetWorldOrigin();
			
		}
		static void LogLoc(UCheatManager* _this)
		{
			_this->LogLoc();
			
		}
		static void FlushLog(UCheatManager* _this)
		{
			_this->FlushLog();
			
		}
		static void BugItStringCreator(UCheatManager* _this,FVector* ViewLocation,FRotator* ViewRotation,MonoString** GoString,MonoString** LocString)
		{
			FString GoString_temp;
			FString LocString_temp;
			_this->BugItStringCreator(*ViewLocation,*ViewRotation,GoString_temp,LocString_temp);
			*GoString=FStringToMonoString(GoString_temp);
			*LocString=FStringToMonoString(LocString_temp);
			
		}
		static void BugIt(UCheatManager* _this,MonoString* ScreenShotDescription)
		{
			FString ScreenShotDescription_temp=MonoStringToFString(ScreenShotDescription);
			_this->BugIt(ScreenShotDescription_temp);
			
		}
		static void BugItGo(UCheatManager* _this,float X,float Y,float Z,float Pitch,float Yaw,float Roll)
		{
			_this->BugItGo(X,Y,Z,Pitch,Yaw,Roll);
			
		}
		static void DumpVoiceMutingState(UCheatManager* _this)
		{
			_this->DumpVoiceMutingState();
			
		}
		static void DumpChatState(UCheatManager* _this)
		{
			_this->DumpChatState();
			
		}
		static void DumpPartyState(UCheatManager* _this)
		{
			_this->DumpPartyState();
			
		}
		static void DumpOnlineSessionState(UCheatManager* _this)
		{
			_this->DumpOnlineSessionState();
			
		}
		static void SetNavDrawDistance(UCheatManager* _this,float DrawDistance)
		{
			_this->SetNavDrawDistance(DrawDistance);
			
		}
		static void RebuildNavigation(UCheatManager* _this)
		{
			_this->RebuildNavigation();
			
		}
		static void TestCollisionDistance(UCheatManager* _this)
		{
			_this->TestCollisionDistance();
			
		}
		static void DebugCapsuleSweepClear(UCheatManager* _this)
		{
			_this->DebugCapsuleSweepClear();
			
		}
		static void DebugCapsuleSweepPawn(UCheatManager* _this)
		{
			_this->DebugCapsuleSweepPawn();
			
		}
		static void DebugCapsuleSweepCapture(UCheatManager* _this)
		{
			_this->DebugCapsuleSweepCapture();
			
		}
		static void DebugCapsuleSweepComplex(UCheatManager* _this,int32 bTraceComplex)
		{
			_this->DebugCapsuleSweepComplex(bTraceComplex>0?true:false);
			
		}
		static void DebugCapsuleSweepChannel(UCheatManager* _this,int32 Channel)
		{
			_this->DebugCapsuleSweepChannel((TEnumAsByte<ECollisionChannel>)Channel);
			
		}
		static void DebugCapsuleSweepSize(UCheatManager* _this,float HalfHeight,float Radius)
		{
			_this->DebugCapsuleSweepSize(HalfHeight,Radius);
			
		}
		static void DebugCapsuleSweep(UCheatManager* _this)
		{
			_this->DebugCapsuleSweep();
			
		}
		static void ServerToggleAILogging(UCheatManager* _this)
		{
			_this->ServerToggleAILogging();
			
		}
		static void ToggleAILogging(UCheatManager* _this)
		{
			_this->ToggleAILogging();
			
		}
		static void ToggleDebugCamera(UCheatManager* _this)
		{
			_this->ToggleDebugCamera();
			
		}
		static void StreamLevelOut(UCheatManager* _this,MonoString* PackageName)
		{
			FName PackageName_temp=MonoStringToFName(PackageName);
			_this->StreamLevelOut(PackageName_temp);
			
		}
		static void OnlyLoadLevel(UCheatManager* _this,MonoString* PackageName)
		{
			FName PackageName_temp=MonoStringToFName(PackageName);
			_this->OnlyLoadLevel(PackageName_temp);
			
		}
		static void StreamLevelIn(UCheatManager* _this,MonoString* PackageName)
		{
			FName PackageName_temp=MonoStringToFName(PackageName);
			_this->StreamLevelIn(PackageName_temp);
			
		}
		static void ViewClass(UCheatManager* _this,TSubclassOf<AActor>  DesiredClass)
		{
			_this->ViewClass(DesiredClass);
			
		}
		static void ViewActor(UCheatManager* _this,MonoString* ActorName)
		{
			FName ActorName_temp=MonoStringToFName(ActorName);
			_this->ViewActor(ActorName_temp);
			
		}
		static void ViewPlayer(UCheatManager* _this,MonoString* S)
		{
			FString S_temp=MonoStringToFString(S);
			_this->ViewPlayer(S_temp);
			
		}
		static void ViewSelf(UCheatManager* _this)
		{
			_this->ViewSelf();
			
		}
		static void PlayersOnly(UCheatManager* _this)
		{
			_this->PlayersOnly();
			
		}
		static void Summon(UCheatManager* _this,MonoString* ClassName)
		{
			FString ClassName_temp=MonoStringToFString(ClassName);
			_this->Summon(ClassName_temp);
			
		}
		static void DestroyPawns(UCheatManager* _this,TSubclassOf<APawn>  aClass)
		{
			_this->DestroyPawns(aClass);
			
		}
		static void DestroyAllPawnsExceptTarget(UCheatManager* _this)
		{
			_this->DestroyAllPawnsExceptTarget();
			
		}
		static void DestroyAll(UCheatManager* _this,TSubclassOf<AActor>  aClass)
		{
			_this->DestroyAll(aClass);
			
		}
		static void DestroyTarget(UCheatManager* _this)
		{
			_this->DestroyTarget();
			
		}
		static void DamageTarget(UCheatManager* _this,float DamageAmount)
		{
			_this->DamageTarget(DamageAmount);
			
		}
		static void Slomo(UCheatManager* _this,float NewTimeDilation)
		{
			_this->Slomo(NewTimeDilation);
			
		}
		static void God(UCheatManager* _this)
		{
			_this->God();
			
		}
		static void Ghost(UCheatManager* _this)
		{
			_this->Ghost();
			
		}
		static void Walk(UCheatManager* _this)
		{
			_this->Walk();
			
		}
		static void Fly(UCheatManager* _this)
		{
			_this->Fly();
			
		}
		static void ChangeSize(UCheatManager* _this,float F)
		{
			_this->ChangeSize(F);
			
		}
		static void Teleport(UCheatManager* _this)
		{
			_this->Teleport();
			
		}
		static void FreezeFrame(UCheatManager* _this,float Delay)
		{
			_this->FreezeFrame(Delay);
			
		}
		static UClass* StaticClass(){return UCheatManager::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UCheatManager::CheatScript",(const void*)CheatScript);
			mono_add_internal_call("UnrealEngine.UCheatManager::InvertMouse",(const void*)InvertMouse);
			mono_add_internal_call("UnrealEngine.UCheatManager::SetMouseSensitivityToDefault",(const void*)SetMouseSensitivityToDefault);
			mono_add_internal_call("UnrealEngine.UCheatManager::SetWorldOrigin",(const void*)SetWorldOrigin);
			mono_add_internal_call("UnrealEngine.UCheatManager::LogLoc",(const void*)LogLoc);
			mono_add_internal_call("UnrealEngine.UCheatManager::FlushLog",(const void*)FlushLog);
			mono_add_internal_call("UnrealEngine.UCheatManager::BugItStringCreator",(const void*)BugItStringCreator);
			mono_add_internal_call("UnrealEngine.UCheatManager::BugIt",(const void*)BugIt);
			mono_add_internal_call("UnrealEngine.UCheatManager::BugItGo",(const void*)BugItGo);
			mono_add_internal_call("UnrealEngine.UCheatManager::DumpVoiceMutingState",(const void*)DumpVoiceMutingState);
			mono_add_internal_call("UnrealEngine.UCheatManager::DumpChatState",(const void*)DumpChatState);
			mono_add_internal_call("UnrealEngine.UCheatManager::DumpPartyState",(const void*)DumpPartyState);
			mono_add_internal_call("UnrealEngine.UCheatManager::DumpOnlineSessionState",(const void*)DumpOnlineSessionState);
			mono_add_internal_call("UnrealEngine.UCheatManager::SetNavDrawDistance",(const void*)SetNavDrawDistance);
			mono_add_internal_call("UnrealEngine.UCheatManager::RebuildNavigation",(const void*)RebuildNavigation);
			mono_add_internal_call("UnrealEngine.UCheatManager::TestCollisionDistance",(const void*)TestCollisionDistance);
			mono_add_internal_call("UnrealEngine.UCheatManager::DebugCapsuleSweepClear",(const void*)DebugCapsuleSweepClear);
			mono_add_internal_call("UnrealEngine.UCheatManager::DebugCapsuleSweepPawn",(const void*)DebugCapsuleSweepPawn);
			mono_add_internal_call("UnrealEngine.UCheatManager::DebugCapsuleSweepCapture",(const void*)DebugCapsuleSweepCapture);
			mono_add_internal_call("UnrealEngine.UCheatManager::DebugCapsuleSweepComplex",(const void*)DebugCapsuleSweepComplex);
			mono_add_internal_call("UnrealEngine.UCheatManager::DebugCapsuleSweepChannel",(const void*)DebugCapsuleSweepChannel);
			mono_add_internal_call("UnrealEngine.UCheatManager::DebugCapsuleSweepSize",(const void*)DebugCapsuleSweepSize);
			mono_add_internal_call("UnrealEngine.UCheatManager::DebugCapsuleSweep",(const void*)DebugCapsuleSweep);
			mono_add_internal_call("UnrealEngine.UCheatManager::ServerToggleAILogging",(const void*)ServerToggleAILogging);
			mono_add_internal_call("UnrealEngine.UCheatManager::ToggleAILogging",(const void*)ToggleAILogging);
			mono_add_internal_call("UnrealEngine.UCheatManager::ToggleDebugCamera",(const void*)ToggleDebugCamera);
			mono_add_internal_call("UnrealEngine.UCheatManager::StreamLevelOut",(const void*)StreamLevelOut);
			mono_add_internal_call("UnrealEngine.UCheatManager::OnlyLoadLevel",(const void*)OnlyLoadLevel);
			mono_add_internal_call("UnrealEngine.UCheatManager::StreamLevelIn",(const void*)StreamLevelIn);
			mono_add_internal_call("UnrealEngine.UCheatManager::ViewClass",(const void*)ViewClass);
			mono_add_internal_call("UnrealEngine.UCheatManager::ViewActor",(const void*)ViewActor);
			mono_add_internal_call("UnrealEngine.UCheatManager::ViewPlayer",(const void*)ViewPlayer);
			mono_add_internal_call("UnrealEngine.UCheatManager::ViewSelf",(const void*)ViewSelf);
			mono_add_internal_call("UnrealEngine.UCheatManager::PlayersOnly",(const void*)PlayersOnly);
			mono_add_internal_call("UnrealEngine.UCheatManager::Summon",(const void*)Summon);
			mono_add_internal_call("UnrealEngine.UCheatManager::DestroyPawns",(const void*)DestroyPawns);
			mono_add_internal_call("UnrealEngine.UCheatManager::DestroyAllPawnsExceptTarget",(const void*)DestroyAllPawnsExceptTarget);
			mono_add_internal_call("UnrealEngine.UCheatManager::DestroyAll",(const void*)DestroyAll);
			mono_add_internal_call("UnrealEngine.UCheatManager::DestroyTarget",(const void*)DestroyTarget);
			mono_add_internal_call("UnrealEngine.UCheatManager::DamageTarget",(const void*)DamageTarget);
			mono_add_internal_call("UnrealEngine.UCheatManager::Slomo",(const void*)Slomo);
			mono_add_internal_call("UnrealEngine.UCheatManager::God",(const void*)God);
			mono_add_internal_call("UnrealEngine.UCheatManager::Ghost",(const void*)Ghost);
			mono_add_internal_call("UnrealEngine.UCheatManager::Walk",(const void*)Walk);
			mono_add_internal_call("UnrealEngine.UCheatManager::Fly",(const void*)Fly);
			mono_add_internal_call("UnrealEngine.UCheatManager::ChangeSize",(const void*)ChangeSize);
			mono_add_internal_call("UnrealEngine.UCheatManager::Teleport",(const void*)Teleport);
			mono_add_internal_call("UnrealEngine.UCheatManager::FreezeFrame",(const void*)FreezeFrame);
			mono_add_internal_call("UnrealEngine.UCheatManager::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
