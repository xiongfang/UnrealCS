#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimBlueprintGeneratedClass
	{
		static readonly int BakedStateMachines__Offset;
		public TStructArray<FBakedAnimationStateMachine> BakedStateMachines
		{
			get{ CheckIsValid();return new TStructArray<FBakedAnimationStateMachine>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BakedStateMachines__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BakedStateMachines__Offset, false);}
			
		}
		
		static readonly int TargetSkeleton__Offset;
		public USkeleton TargetSkeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TargetSkeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimNotifies__Offset;
		public TStructArray<FAnimNotifyEvent> AnimNotifies
		{
			get{ CheckIsValid();return new TStructArray<FAnimNotifyEvent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AnimNotifies__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AnimNotifies__Offset, false);}
			
		}
		
		static readonly int RootAnimNodeIndex__Offset;
		public int RootAnimNodeIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RootAnimNodeIndex__Offset, typeof(int));}
			
		}
		
		static readonly int OrderedSavedPoseIndices__Offset;
		public TStructArray<int> OrderedSavedPoseIndices
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+OrderedSavedPoseIndices__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+OrderedSavedPoseIndices__Offset, false);}
			
		}
		
		static readonly int SyncGroupNames__Offset;
		public TStructArray<FName> SyncGroupNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SyncGroupNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SyncGroupNames__Offset, false);}
			
		}
		
		static UAnimBlueprintGeneratedClass()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimBlueprintGeneratedClass");
			BakedStateMachines__Offset=GetPropertyOffset(NativeClassPtr,"BakedStateMachines");
			TargetSkeleton__Offset=GetPropertyOffset(NativeClassPtr,"TargetSkeleton");
			AnimNotifies__Offset=GetPropertyOffset(NativeClassPtr,"AnimNotifies");
			RootAnimNodeIndex__Offset=GetPropertyOffset(NativeClassPtr,"RootAnimNodeIndex");
			OrderedSavedPoseIndices__Offset=GetPropertyOffset(NativeClassPtr,"OrderedSavedPoseIndices");
			SyncGroupNames__Offset=GetPropertyOffset(NativeClassPtr,"SyncGroupNames");
			
		}
		
	}
	
}
#endif
#endif
