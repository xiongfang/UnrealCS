#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimInstance
	{
		static readonly int DeltaTime__Offset;
		public float DeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DeltaTime__Offset, typeof(float));}
			
		}
		
		static readonly int CurrentSkeleton__Offset;
		public USkeleton CurrentSkeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentSkeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RootMotionMode__Offset;
		public ERootMotionMode RootMotionMode
		{
			get{ CheckIsValid();return (ERootMotionMode)Marshal.PtrToStructure(_this.Get()+RootMotionMode__Offset, typeof(ERootMotionMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RootMotionMode__Offset, false);}
			
		}
		
		static readonly int bRunUpdatesInWorkerThreads__Offset;
		public bool bRunUpdatesInWorkerThreads
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRunUpdatesInWorkerThreads__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bCanUseParallelUpdateAnimation__Offset;
		public bool bCanUseParallelUpdateAnimation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanUseParallelUpdateAnimation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bUseMultiThreadedAnimationUpdate__Offset;
		public bool bUseMultiThreadedAnimationUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseMultiThreadedAnimationUpdate__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bWarnAboutBlueprintUsage__Offset;
		public bool bWarnAboutBlueprintUsage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWarnAboutBlueprintUsage__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int OnMontageBlendingOut__Offset;
		public FMulticastScriptDelegate OnMontageBlendingOut
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnMontageBlendingOut__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnMontageBlendingOut__Offset, false);}
			
		}
		
		static readonly int OnMontageStarted__Offset;
		public FMulticastScriptDelegate OnMontageStarted
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnMontageStarted__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnMontageStarted__Offset, false);}
			
		}
		
		static readonly int OnMontageEnded__Offset;
		public FMulticastScriptDelegate OnMontageEnded
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnMontageEnded__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnMontageEnded__Offset, false);}
			
		}
		
		static readonly int OnAllMontageInstancesEnded__Offset;
		public FMulticastScriptDelegate OnAllMontageInstancesEnded
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnAllMontageInstancesEnded__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnAllMontageInstancesEnded__Offset, false);}
			
		}
		
		static readonly int bQueueMontageEvents__Offset;
		public bool bQueueMontageEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bQueueMontageEvents__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ActiveAnimNotifyState__Offset;
		public TStructArray<FAnimNotifyEvent> ActiveAnimNotifyState
		{
			get{ CheckIsValid();return new TStructArray<FAnimNotifyEvent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveAnimNotifyState__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveAnimNotifyState__Offset, false);}
			
		}
		
		static UAnimInstance()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimInstance");
			DeltaTime__Offset=GetPropertyOffset(NativeClassPtr,"DeltaTime");
			CurrentSkeleton__Offset=GetPropertyOffset(NativeClassPtr,"CurrentSkeleton");
			RootMotionMode__Offset=GetPropertyOffset(NativeClassPtr,"RootMotionMode");
			bRunUpdatesInWorkerThreads__Offset=GetPropertyOffset(NativeClassPtr,"bRunUpdatesInWorkerThreads");
			bCanUseParallelUpdateAnimation__Offset=GetPropertyOffset(NativeClassPtr,"bCanUseParallelUpdateAnimation");
			bUseMultiThreadedAnimationUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bUseMultiThreadedAnimationUpdate");
			bWarnAboutBlueprintUsage__Offset=GetPropertyOffset(NativeClassPtr,"bWarnAboutBlueprintUsage");
			OnMontageBlendingOut__Offset=GetPropertyOffset(NativeClassPtr,"OnMontageBlendingOut");
			OnMontageStarted__Offset=GetPropertyOffset(NativeClassPtr,"OnMontageStarted");
			OnMontageEnded__Offset=GetPropertyOffset(NativeClassPtr,"OnMontageEnded");
			OnAllMontageInstancesEnded__Offset=GetPropertyOffset(NativeClassPtr,"OnAllMontageInstancesEnded");
			bQueueMontageEvents__Offset=GetPropertyOffset(NativeClassPtr,"bQueueMontageEvents");
			ActiveAnimNotifyState__Offset=GetPropertyOffset(NativeClassPtr,"ActiveAnimNotifyState");
			
		}
		
	}
	
}
#endif
#endif
