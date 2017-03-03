#pragma once

namespace UnrealEngine
{
	class _AMatineeActor
	{
		static void SetLoopingState(AMatineeActor* _this,int32 bNewLooping)
		{
			_this->SetLoopingState(bNewLooping>0?true:false);
			
		}
		static void ChangePlaybackDirection(AMatineeActor* _this)
		{
			_this->ChangePlaybackDirection();
			
		}
		static void SetPosition(AMatineeActor* _this,float NewPosition,int32 bJump)
		{
			_this->SetPosition(NewPosition,bJump>0?true:false);
			
		}
		static void Pause(AMatineeActor* _this)
		{
			_this->Pause();
			
		}
		static void Reverse(AMatineeActor* _this)
		{
			_this->Reverse();
			
		}
		static void Stop(AMatineeActor* _this)
		{
			_this->Stop();
			
		}
		static void Play(AMatineeActor* _this)
		{
			_this->Play();
			
		}
		static UClass* StaticClass(){return AMatineeActor::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.AMatineeActor::SetLoopingState",(const void*)SetLoopingState);
			mono_add_internal_call("UnrealEngine.AMatineeActor::ChangePlaybackDirection",(const void*)ChangePlaybackDirection);
			mono_add_internal_call("UnrealEngine.AMatineeActor::SetPosition",(const void*)SetPosition);
			mono_add_internal_call("UnrealEngine.AMatineeActor::Pause",(const void*)Pause);
			mono_add_internal_call("UnrealEngine.AMatineeActor::Reverse",(const void*)Reverse);
			mono_add_internal_call("UnrealEngine.AMatineeActor::Stop",(const void*)Stop);
			mono_add_internal_call("UnrealEngine.AMatineeActor::Play",(const void*)Play);
			mono_add_internal_call("UnrealEngine.AMatineeActor::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
