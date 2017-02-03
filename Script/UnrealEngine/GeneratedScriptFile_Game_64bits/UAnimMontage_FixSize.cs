#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimMontage
	{
		static readonly int BlendIn__Offset;
		public FAlphaBlend BlendIn
		{
			get{ CheckIsValid();return (FAlphaBlend)Marshal.PtrToStructure(_this.Get()+BlendIn__Offset, typeof(FAlphaBlend));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendIn__Offset, false);}
			
		}
		
		static readonly int BlendInTime__Offset;
		public float BlendInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendInTime__Offset, typeof(float));}
			
		}
		
		static readonly int BlendOut__Offset;
		public FAlphaBlend BlendOut
		{
			get{ CheckIsValid();return (FAlphaBlend)Marshal.PtrToStructure(_this.Get()+BlendOut__Offset, typeof(FAlphaBlend));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendOut__Offset, false);}
			
		}
		
		static readonly int BlendOutTime__Offset;
		public float BlendOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendOutTime__Offset, typeof(float));}
			
		}
		
		static readonly int BlendOutTriggerTime__Offset;
		public float BlendOutTriggerTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendOutTriggerTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendOutTriggerTime__Offset, false);}
			
		}
		
		static readonly int SyncGroup__Offset;
		public FName SyncGroup
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SyncGroup__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SyncGroup__Offset, false);}
			
		}
		
		static readonly int SyncSlotIndex__Offset;
		public int SyncSlotIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SyncSlotIndex__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SyncSlotIndex__Offset, false);}
			
		}
		
		static readonly int MarkerData__Offset;
		public FMarkerSyncData MarkerData
		{
			get{ CheckIsValid();return (FMarkerSyncData)Marshal.PtrToStructure(_this.Get()+MarkerData__Offset, typeof(FMarkerSyncData));}
			
		}
		
		static readonly int CompositeSections__Offset;
		public TStructArray<FCompositeSection> CompositeSections
		{
			get{ CheckIsValid();return new TStructArray<FCompositeSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CompositeSections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CompositeSections__Offset, false);}
			
		}
		
		static readonly int SlotAnimTracks__Offset;
		public TStructArray<FSlotAnimationTrack> SlotAnimTracks
		{
			get{ CheckIsValid();return new TStructArray<FSlotAnimationTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SlotAnimTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SlotAnimTracks__Offset, false);}
			
		}
		
		static readonly int BranchingPoints__Offset;
		public TStructArray<FBranchingPoint> BranchingPoints
		{
			get{ CheckIsValid();return new TStructArray<FBranchingPoint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BranchingPoints__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BranchingPoints__Offset, false);}
			
		}
		
		static readonly int bEnableRootMotionTranslation__Offset;
		public bool bEnableRootMotionTranslation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableRootMotionTranslation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bEnableRootMotionRotation__Offset;
		public bool bEnableRootMotionRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableRootMotionRotation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int RootMotionRootLock__Offset;
		public ERootMotionRootLock RootMotionRootLock
		{
			get{ CheckIsValid();return (ERootMotionRootLock)Marshal.PtrToStructure(_this.Get()+RootMotionRootLock__Offset, typeof(ERootMotionRootLock));}
			
		}
		
		static readonly int BranchingPointMarkers__Offset;
		public TStructArray<FBranchingPointMarker> BranchingPointMarkers
		{
			get{ CheckIsValid();return new TStructArray<FBranchingPointMarker>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BranchingPointMarkers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BranchingPointMarkers__Offset, false);}
			
		}
		
		static readonly int BranchingPointStateNotifyIndices__Offset;
		public TStructArray<int> BranchingPointStateNotifyIndices
		{
			get{ CheckIsValid();return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BranchingPointStateNotifyIndices__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BranchingPointStateNotifyIndices__Offset, false);}
			
		}
		
		static UAnimMontage()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimMontage");
			BlendIn__Offset=GetPropertyOffset(NativeClassPtr,"BlendIn");
			BlendInTime__Offset=GetPropertyOffset(NativeClassPtr,"BlendInTime");
			BlendOut__Offset=GetPropertyOffset(NativeClassPtr,"BlendOut");
			BlendOutTime__Offset=GetPropertyOffset(NativeClassPtr,"BlendOutTime");
			BlendOutTriggerTime__Offset=GetPropertyOffset(NativeClassPtr,"BlendOutTriggerTime");
			SyncGroup__Offset=GetPropertyOffset(NativeClassPtr,"SyncGroup");
			SyncSlotIndex__Offset=GetPropertyOffset(NativeClassPtr,"SyncSlotIndex");
			MarkerData__Offset=GetPropertyOffset(NativeClassPtr,"MarkerData");
			CompositeSections__Offset=GetPropertyOffset(NativeClassPtr,"CompositeSections");
			SlotAnimTracks__Offset=GetPropertyOffset(NativeClassPtr,"SlotAnimTracks");
			BranchingPoints__Offset=GetPropertyOffset(NativeClassPtr,"BranchingPoints");
			bEnableRootMotionTranslation__Offset=GetPropertyOffset(NativeClassPtr,"bEnableRootMotionTranslation");
			bEnableRootMotionRotation__Offset=GetPropertyOffset(NativeClassPtr,"bEnableRootMotionRotation");
			RootMotionRootLock__Offset=GetPropertyOffset(NativeClassPtr,"RootMotionRootLock");
			BranchingPointMarkers__Offset=GetPropertyOffset(NativeClassPtr,"BranchingPointMarkers");
			BranchingPointStateNotifyIndices__Offset=GetPropertyOffset(NativeClassPtr,"BranchingPointStateNotifyIndices");
			
		}
		
	}
	
}
#endif
#endif
