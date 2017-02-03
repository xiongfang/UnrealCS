#pragma once

namespace UnrealEngine
{
	class _UAnimSingleNodeInstance
	{
		static void SetPreviewCurveOverride(UAnimSingleNodeInstance* _this,MonoString* PoseName,float Value,int32 bRemoveIfZero)
		{
			FName PoseName_temp=MonoStringToFName(PoseName);
			_this->SetPreviewCurveOverride(PoseName_temp,Value,bRemoveIfZero>0?true:false);
			
		}
		static void SetAnimationAsset(UAnimSingleNodeInstance* _this,UAnimationAsset* NewAsset,int32 bIsLooping,float InPlayRate)
		{
			_this->SetAnimationAsset(NewAsset,bIsLooping>0?true:false,InPlayRate);
			
		}
		static void StopAnim(UAnimSingleNodeInstance* _this)
		{
			_this->StopAnim();
			
		}
		static void PlayAnim(UAnimSingleNodeInstance* _this,int32 bIsLooping,float InPlayRate,float InStartPosition)
		{
			_this->PlayAnim(bIsLooping>0?true:false,InPlayRate,InStartPosition);
			
		}
		static float GetLength(UAnimSingleNodeInstance* _this)
		{
			float ___ret = _this->GetLength();
			return ___ret;
			
		}
		static void SetPlaying(UAnimSingleNodeInstance* _this,int32 bIsPlaying)
		{
			_this->SetPlaying(bIsPlaying>0?true:false);
			
		}
		static void SetBlendSpaceInput(UAnimSingleNodeInstance* _this,FVector* InBlendInput)
		{
			_this->SetBlendSpaceInput(*InBlendInput);
			
		}
		static void SetPositionWithPreviousTime(UAnimSingleNodeInstance* _this,float InPosition,float InPreviousTime,int32 bFireNotifies)
		{
			_this->SetPositionWithPreviousTime(InPosition,InPreviousTime,bFireNotifies>0?true:false);
			
		}
		static void SetPosition(UAnimSingleNodeInstance* _this,float InPosition,int32 bFireNotifies)
		{
			_this->SetPosition(InPosition,bFireNotifies>0?true:false);
			
		}
		static void SetReverse(UAnimSingleNodeInstance* _this,int32 bInReverse)
		{
			_this->SetReverse(bInReverse>0?true:false);
			
		}
		static void SetPlayRate(UAnimSingleNodeInstance* _this,float InPlayRate)
		{
			_this->SetPlayRate(InPlayRate);
			
		}
		static void SetLooping(UAnimSingleNodeInstance* _this,int32 bIsLooping)
		{
			_this->SetLooping(bIsLooping>0?true:false);
			
		}
		static UClass* StaticClass(){return UAnimSingleNodeInstance::StaticClass();}
		public:
		static void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::SetPreviewCurveOverride",(const void*)SetPreviewCurveOverride);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::SetAnimationAsset",(const void*)SetAnimationAsset);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::StopAnim",(const void*)StopAnim);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::PlayAnim",(const void*)PlayAnim);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::GetLength",(const void*)GetLength);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::SetPlaying",(const void*)SetPlaying);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::SetBlendSpaceInput",(const void*)SetBlendSpaceInput);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::SetPositionWithPreviousTime",(const void*)SetPositionWithPreviousTime);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::SetPosition",(const void*)SetPosition);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::SetReverse",(const void*)SetReverse);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::SetPlayRate",(const void*)SetPlayRate);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::SetLooping",(const void*)SetLooping);
			mono_add_internal_call("UnrealEngine.UAnimSingleNodeInstance::StaticClass",(const void*)StaticClass);
			
		}
		
	}
	;
}
