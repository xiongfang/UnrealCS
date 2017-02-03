#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimClassData
	{
		static readonly int BakedStateMachines__Offset;
		/// <summary>List of state machines present in this blueprint class</summary>
		public TStructArray<FBakedAnimationStateMachine> BakedStateMachines
		{
			get{ CheckIsValid();return new TStructArray<FBakedAnimationStateMachine>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BakedStateMachines__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BakedStateMachines__Offset, false);}
			
		}
		
		static readonly int TargetSkeleton__Offset;
		/// <summary>Target skeleton for this blueprint class</summary>
		public USkeleton TargetSkeleton
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + TargetSkeleton__Offset); if (v == IntPtr.Zero)return null; USkeleton retValue = new USkeleton(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimNotifies__Offset;
		/// <summary>A list of anim notifies that state machines (or anything else) may reference</summary>
		public TStructArray<FAnimNotifyEvent> AnimNotifies
		{
			get{ CheckIsValid();return new TStructArray<FAnimNotifyEvent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AnimNotifies__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AnimNotifies__Offset, false);}
			
		}
		
		static readonly int RootAnimNodeIndex__Offset;
		/// <summary>The index of the root node in the animation tree</summary>
		public int RootAnimNodeIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RootAnimNodeIndex__Offset, typeof(int));}
			
		}
		
		static readonly int OrderedSavedPoseIndices__Offset;
		/// <summary>Indices for each of the saved pose nodes that require updating, in the order they need to get updates.</summary>
		public TStructArray<int> OrderedSavedPoseIndices
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+OrderedSavedPoseIndices__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+OrderedSavedPoseIndices__Offset, false);}
			
		}
		
		static readonly int RootAnimNodeProperty__Offset;
		public UStructProperty RootAnimNodeProperty
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RootAnimNodeProperty__Offset); if (v == IntPtr.Zero)return null; UStructProperty retValue = new UStructProperty(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AnimNodeProperties__Offset;
		/// <summary>The array of anim nodes</summary>
		public TObjectArray<UStructProperty>  AnimNodeProperties
		{
					get{ CheckIsValid();return new TObjectArray<UStructProperty>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AnimNodeProperties__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AnimNodeProperties__Offset, false);}
			
		}
		
		static readonly int SyncGroupNames__Offset;
		/// <summary>Array of sync group names in the order that they are requested during compile</summary>
		public TStructArray<FName> SyncGroupNames
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SyncGroupNames__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SyncGroupNames__Offset, false);}
			
		}
		
		static UAnimClassData()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimClassData");
			BakedStateMachines__Offset=GetPropertyOffset(NativeClassPtr,"BakedStateMachines");
			TargetSkeleton__Offset=GetPropertyOffset(NativeClassPtr,"TargetSkeleton");
			AnimNotifies__Offset=GetPropertyOffset(NativeClassPtr,"AnimNotifies");
			RootAnimNodeIndex__Offset=GetPropertyOffset(NativeClassPtr,"RootAnimNodeIndex");
			OrderedSavedPoseIndices__Offset=GetPropertyOffset(NativeClassPtr,"OrderedSavedPoseIndices");
			RootAnimNodeProperty__Offset=GetPropertyOffset(NativeClassPtr,"RootAnimNodeProperty");
			AnimNodeProperties__Offset=GetPropertyOffset(NativeClassPtr,"AnimNodeProperties");
			SyncGroupNames__Offset=GetPropertyOffset(NativeClassPtr,"SyncGroupNames");
			
		}
		
	}
	
}
#endif
#endif
