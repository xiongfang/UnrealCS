using System;
namespace UnrealEngine
{
	public partial class UAnimSingleNodeInstance:UAnimInstance
	{
		/// <summary>Set pose value</summary>
		public extern void SetPreviewCurveOverride(FName PoseName,float Value,bool bRemoveIfZero);
		/// <summary>Set New Asset - calls InitializeAnimation, for now we need MeshComponent *</summary>
		public extern virtual void SetAnimationAsset(UAnimationAsset NewAsset,bool bIsLooping=true,float InPlayRate=1.000000f);
		public extern void StopAnim();
		/// <summary>For AnimSequence specific *</summary>
		public extern void PlayAnim(bool bIsLooping=false,float InPlayRate=1.000000f,float InStartPosition=0.000000f);
		public extern float GetLength();
		public extern void SetPlaying(bool bIsPlaying);
		public extern void SetBlendSpaceInput(FVector InBlendInput);
		public extern void SetPositionWithPreviousTime(float InPosition,float InPreviousTime,bool bFireNotifies=true);
		public extern void SetPosition(float InPosition,bool bFireNotifies=true);
		public extern void SetReverse(bool bInReverse);
		public extern void SetPlayRate(float InPlayRate);
		public extern void SetLooping(bool bIsLooping);
		/// <summary>Current Asset being played *</summary>
		public UAnimationAsset CurrentAsset;
		
		
	}
	
}
