#pragma once

namespace UnrealEngine
{
	class _UMovieSceneSequencePlayer
	{
		static float GetPlaybackEnd(UMovieSceneSequencePlayer* _this)
		{
			float ___ret = _this->GetPlaybackEnd();
			return ___ret;
			
		}
		static float GetPlaybackStart(UMovieSceneSequencePlayer* _this)
		{
			float ___ret = _this->GetPlaybackStart();
			return ___ret;
			
		}
		static void SetPlaybackRange(UMovieSceneSequencePlayer* _this,float NewStartTime,float NewEndTime)
		{
			_this->SetPlaybackRange(NewStartTime,NewEndTime);
			
		}
		static void SetPlayRate(UMovieSceneSequencePlayer* _this,float PlayRate)
		{
			_this->SetPlayRate(PlayRate);
			
		}
		static float GetPlayRate(UMovieSceneSequencePlayer* _this)
		{
			float ___ret = _this->GetPlayRate();
			return ___ret;
			
		}
		static float GetLength(UMovieSceneSequencePlayer* _this)
		{
			float ___ret = _this->GetLength();
			return ___ret;
			
		}
		static int32 IsPlaying(UMovieSceneSequencePlayer* _this)
		{
			bool ___ret = _this->IsPlaying();
			return ___ret?1:0;
			
		}
		static void SetPlaybackPosition(UMovieSceneSequencePlayer* _this,float NewPlaybackPosition)
		{
			_this->SetPlaybackPosition(NewPlaybackPosition);
			
		}
		static float GetPlaybackPosition(UMovieSceneSequencePlayer* _this)
		{
			float ___ret = _this->GetPlaybackPosition();
			return ___ret;
			
		}
		static void Stop(UMovieSceneSequencePlayer* _this)
		{
			_this->Stop();
			
		}
		static void Pause(UMovieSceneSequencePlayer* _this)
		{
			_this->Pause();
			
		}
		static void StartPlayingNextTick(UMovieSceneSequencePlayer* _this)
		{
			_this->StartPlayingNextTick();
			
		}
		static void PlayLooping(UMovieSceneSequencePlayer* _this,int32 NumLoops)
		{
			_this->PlayLooping(NumLoops);
			
		}
		static void ChangePlaybackDirection(UMovieSceneSequencePlayer* _this)
		{
			_this->ChangePlaybackDirection();
			
		}
		static void PlayReverse(UMovieSceneSequencePlayer* _this)
		{
			_this->PlayReverse();
			
		}
		static void Play(UMovieSceneSequencePlayer* _this)
		{
			_this->Play();
			
		}
		static UClass* StaticClass(){return UMovieSceneSequencePlayer::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::GetPlaybackEnd",(const void*)GetPlaybackEnd);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::GetPlaybackStart",(const void*)GetPlaybackStart);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::SetPlaybackRange",(const void*)SetPlaybackRange);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::SetPlayRate",(const void*)SetPlayRate);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::GetPlayRate",(const void*)GetPlayRate);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::GetLength",(const void*)GetLength);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::IsPlaying",(const void*)IsPlaying);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::SetPlaybackPosition",(const void*)SetPlaybackPosition);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::GetPlaybackPosition",(const void*)GetPlaybackPosition);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::Stop",(const void*)Stop);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::Pause",(const void*)Pause);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::StartPlayingNextTick",(const void*)StartPlayingNextTick);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::PlayLooping",(const void*)PlayLooping);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::ChangePlaybackDirection",(const void*)ChangePlaybackDirection);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::PlayReverse",(const void*)PlayReverse);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::Play",(const void*)Play);
			mono_add_internal_call("UnrealEngine.UMovieSceneSequencePlayer::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
