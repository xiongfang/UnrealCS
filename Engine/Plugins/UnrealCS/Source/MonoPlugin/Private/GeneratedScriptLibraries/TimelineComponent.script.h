#pragma once

namespace UnrealEngine
{
	class _UTimelineComponent
	{
		static void SetLinearColorCurve(UTimelineComponent* _this,UCurveLinearColor* NewLinearColorCurve,MonoString* LinearColorTrackName)
		{
			FName LinearColorTrackName_temp=MonoStringToFName(LinearColorTrackName);
			_this->SetLinearColorCurve(NewLinearColorCurve,LinearColorTrackName_temp);
			
		}
		static void SetVectorCurve(UTimelineComponent* _this,UCurveVector* NewVectorCurve,MonoString* VectorTrackName)
		{
			FName VectorTrackName_temp=MonoStringToFName(VectorTrackName);
			_this->SetVectorCurve(NewVectorCurve,VectorTrackName_temp);
			
		}
		static void SetFloatCurve(UTimelineComponent* _this,UCurveFloat* NewFloatCurve,MonoString* FloatTrackName)
		{
			FName FloatTrackName_temp=MonoStringToFName(FloatTrackName);
			_this->SetFloatCurve(NewFloatCurve,FloatTrackName_temp);
			
		}
		static int32 GetIgnoreTimeDilation(UTimelineComponent* _this)
		{
			bool ___ret = _this->GetIgnoreTimeDilation();
			return ___ret?1:0;
			
		}
		static void SetIgnoreTimeDilation(UTimelineComponent* _this,int32 bNewIgnoreTimeDilation)
		{
			_this->SetIgnoreTimeDilation(bNewIgnoreTimeDilation>0?true:false);
			
		}
		static void SetTimelineLengthMode(UTimelineComponent* _this,int32 NewLengthMode)
		{
			_this->SetTimelineLengthMode((TEnumAsByte<ETimelineLengthMode>)NewLengthMode);
			
		}
		static void SetTimelineLength(UTimelineComponent* _this,float NewLength)
		{
			_this->SetTimelineLength(NewLength);
			
		}
		static float GetTimelineLength(UTimelineComponent* _this)
		{
			float ___ret = _this->GetTimelineLength();
			return ___ret;
			
		}
		static void SetNewTime(UTimelineComponent* _this,float NewTime)
		{
			_this->SetNewTime(NewTime);
			
		}
		static float GetPlayRate(UTimelineComponent* _this)
		{
			float ___ret = _this->GetPlayRate();
			return ___ret;
			
		}
		static void SetPlayRate(UTimelineComponent* _this,float NewRate)
		{
			_this->SetPlayRate(NewRate);
			
		}
		static int32 IsLooping(UTimelineComponent* _this)
		{
			bool ___ret = _this->IsLooping();
			return ___ret?1:0;
			
		}
		static void SetLooping(UTimelineComponent* _this,int32 bNewLooping)
		{
			_this->SetLooping(bNewLooping>0?true:false);
			
		}
		static float GetPlaybackPosition(UTimelineComponent* _this)
		{
			float ___ret = _this->GetPlaybackPosition();
			return ___ret;
			
		}
		static void SetPlaybackPosition(UTimelineComponent* _this,float NewPosition,int32 bFireEvents,int32 bFireUpdate)
		{
			_this->SetPlaybackPosition(NewPosition,bFireEvents>0?true:false,bFireUpdate>0?true:false);
			
		}
		static int32 IsReversing(UTimelineComponent* _this)
		{
			bool ___ret = _this->IsReversing();
			return ___ret?1:0;
			
		}
		static int32 IsPlaying(UTimelineComponent* _this)
		{
			bool ___ret = _this->IsPlaying();
			return ___ret?1:0;
			
		}
		static void Stop(UTimelineComponent* _this)
		{
			_this->Stop();
			
		}
		static void ReverseFromEnd(UTimelineComponent* _this)
		{
			_this->ReverseFromEnd();
			
		}
		static void Reverse(UTimelineComponent* _this)
		{
			_this->Reverse();
			
		}
		static void PlayFromStart(UTimelineComponent* _this)
		{
			_this->PlayFromStart();
			
		}
		static void Play(UTimelineComponent* _this)
		{
			_this->Play();
			
		}
		static UClass* StaticClass(){return UTimelineComponent::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetLinearColorCurve",(const void*)SetLinearColorCurve);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetVectorCurve",(const void*)SetVectorCurve);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetFloatCurve",(const void*)SetFloatCurve);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::GetIgnoreTimeDilation",(const void*)GetIgnoreTimeDilation);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetIgnoreTimeDilation",(const void*)SetIgnoreTimeDilation);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetTimelineLengthMode",(const void*)SetTimelineLengthMode);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetTimelineLength",(const void*)SetTimelineLength);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::GetTimelineLength",(const void*)GetTimelineLength);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetNewTime",(const void*)SetNewTime);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::GetPlayRate",(const void*)GetPlayRate);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetPlayRate",(const void*)SetPlayRate);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::IsLooping",(const void*)IsLooping);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetLooping",(const void*)SetLooping);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::GetPlaybackPosition",(const void*)GetPlaybackPosition);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::SetPlaybackPosition",(const void*)SetPlaybackPosition);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::IsReversing",(const void*)IsReversing);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::IsPlaying",(const void*)IsPlaying);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::Stop",(const void*)Stop);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::ReverseFromEnd",(const void*)ReverseFromEnd);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::Reverse",(const void*)Reverse);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::PlayFromStart",(const void*)PlayFromStart);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::Play",(const void*)Play);
			mono_add_internal_call("UnrealEngine.UTimelineComponent::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
