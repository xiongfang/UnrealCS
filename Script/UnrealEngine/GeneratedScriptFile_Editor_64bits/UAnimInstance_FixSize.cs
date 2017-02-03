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
		/// <summary>
		/// Allows this anim instance to update its native update, blend tree, montages and asset players on
		/// a worker thread. this requires certain conditions to be met:
		/// - All access of variables in the blend tree should be a direct access of a member variable
		/// - No BlueprintUpdateAnimation event should be used (i.e. the event graph should be empty). Only native update is permitted.
		/// </summary>
		public bool bRunUpdatesInWorkerThreads
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRunUpdatesInWorkerThreads__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRunUpdatesInWorkerThreads__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bCanUseParallelUpdateAnimation__Offset;
		/// <summary>
		/// Whether we can use parallel updates for our animations.
		/// Conditions affecting this include:
		/// - Use of BlueprintUpdateAnimation
		/// - Use of non 'fast-path' EvaluateGraphExposedInputs in the node graph
		/// </summary>
		public bool bCanUseParallelUpdateAnimation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanUseParallelUpdateAnimation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bWarnAboutBlueprintUsage__Offset;
		/// <summary>
		/// Selecting this option will cause the compiler to emit warnings whenever a call into Blueprint
		/// is made from the animation graph. This can help track down optimizations that need to be made.
		/// </summary>
		public bool bWarnAboutBlueprintUsage
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWarnAboutBlueprintUsage__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bWarnAboutBlueprintUsage__Offset, 1,0,1,255);}
			
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
			bWarnAboutBlueprintUsage__Offset=GetPropertyOffset(NativeClassPtr,"bWarnAboutBlueprintUsage");
			OnMontageBlendingOut__Offset=GetPropertyOffset(NativeClassPtr,"OnMontageBlendingOut");
			OnMontageStarted__Offset=GetPropertyOffset(NativeClassPtr,"OnMontageStarted");
			OnMontageEnded__Offset=GetPropertyOffset(NativeClassPtr,"OnMontageEnded");
			bQueueMontageEvents__Offset=GetPropertyOffset(NativeClassPtr,"bQueueMontageEvents");
			ActiveAnimNotifyState__Offset=GetPropertyOffset(NativeClassPtr,"ActiveAnimNotifyState");
			
		}
		
	}
	
}
#endif
#endif
