#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimInstance
	{
		static readonly int DeltaTime__Offset;
		/// <summary>DeltaTime *</summary>
		public float DeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DeltaTime__Offset, typeof(float));}
			
		}
		
		static readonly int CurrentSkeleton__Offset;
		/// <summary>This is used to extract animation. If Mesh exists, this will be overwritten by Mesh->Skeleton</summary>
		public USkeleton CurrentSkeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentSkeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RootMotionMode__Offset;
		/// <summary>Sets where this blueprint pulls Root Motion from</summary>
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
		/// <summary>
		/// Allows this anim instance to update its native update, blend tree, montages and asset players on
		/// a worker thread. This flag is propagated from the UAnimBlueprint to this instance by the compiler.
		/// The compiler will attempt to pick up any issues that may occur with threaded update.
		/// For updates to run in multiple threads both this flag and the project setting "Allow Multi Threaded
		/// Animation Update" should be set.
		/// </summary>
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
		/// <summary>Called when a montage starts blending out, whether interrupted or finished</summary>
		public FMulticastScriptDelegate OnMontageBlendingOut
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnMontageBlendingOut__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnMontageBlendingOut__Offset, false);}
			
		}
		
		static readonly int OnMontageStarted__Offset;
		/// <summary>Called when a montage has started</summary>
		public FMulticastScriptDelegate OnMontageStarted
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnMontageStarted__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnMontageStarted__Offset, false);}
			
		}
		
		static readonly int OnMontageEnded__Offset;
		/// <summary>Called when a montage has ended, whether interrupted or finished</summary>
		public FMulticastScriptDelegate OnMontageEnded
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnMontageEnded__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnMontageEnded__Offset, false);}
			
		}
		
		static readonly int OnAllMontageInstancesEnded__Offset;
		/// <summary>Called when all Montage instances have ended.</summary>
		public FMulticastScriptDelegate OnAllMontageInstancesEnded
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnAllMontageInstancesEnded__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnAllMontageInstancesEnded__Offset, false);}
			
		}
		
		static readonly int bQueueMontageEvents__Offset;
		/// <summary>
		/// True when Montages are being ticked, and Montage Events should be queued.
		/// When Montage are being ticked, we queue AnimNotifies and Events. We trigger notifies first, then Montage events.
		/// </summary>
		public bool bQueueMontageEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bQueueMontageEvents__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ActiveAnimNotifyState__Offset;
		/// <summary>
		/// Currently Active AnimNotifyState, stored as a copy of the event as we need to
		///               call NotifyEnd on the event after a deletion in the editor. After this the event
		///               is removed correctly.
		/// </summary>
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
