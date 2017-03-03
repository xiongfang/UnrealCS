#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// * Any property you're adding to AnimMontage and parent class has to be considered for Child Asset
	/// *
	/// * Child Asset is considered to be only asset mapping feature using everything else in the class
	/// * For example, you can just use all parent's setting  for the montage, but only remap assets
	/// * This isn't magic bullet unfortunately and it is consistent effort of keeping the data synced with parent
	/// * If you add new property, please make sure those property has to be copied for children.
	/// * If it does, please add the copy in the function RefreshParentAssetData
	/// </summary>
	public partial class UAnimMontage
	{
		static readonly int BlendIn__Offset;
		/// <summary>Blend in option.</summary>
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
		/// <summary>Blend out option. This is only used when it blends out itself. If it's interrupted by other montages, it will use new montage's BlendIn option to blend out.</summary>
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
		/// <summary>
		/// Time from Sequence End to trigger blend out.
		/// <0 means using BlendOutTime, so BlendOut finishes as Montage ends.
		/// >=0 means using 'SequenceEnd - BlendOutTriggerTime' to trigger blend out.
		/// </summary>
		public float BlendOutTriggerTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BlendOutTriggerTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BlendOutTriggerTime__Offset, false);}
			
		}
		
		static readonly int SyncGroup__Offset;
		/// <summary>If you're using marker based sync for this montage, make sure to add sync group name. For now we only support one group</summary>
		public FName SyncGroup
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SyncGroup__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SyncGroup__Offset, false);}
			
		}
		
		static readonly int SyncSlotIndex__Offset;
		/// <summary>wip: until we have UI working</summary>
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
		/// <summary>composite section.</summary>
		public TStructArray<FCompositeSection> CompositeSections
		{
			get{ CheckIsValid();return new TStructArray<FCompositeSection>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CompositeSections__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CompositeSections__Offset, false);}
			
		}
		
		static readonly int SlotAnimTracks__Offset;
		/// <summary>slot data, each slot contains anim track</summary>
		public TStructArray<FSlotAnimationTrack> SlotAnimTracks
		{
			get{ CheckIsValid();return new TStructArray<FSlotAnimationTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SlotAnimTracks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SlotAnimTracks__Offset, false);}
			
		}
		
		static readonly int BranchingPoints__Offset;
		/// <summary>Remove this when VER_UE4_MONTAGE_BRANCHING_POINT_REMOVAL is removed.</summary>
		public TStructArray<FBranchingPoint> BranchingPoints
		{
			get{ CheckIsValid();return new TStructArray<FBranchingPoint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BranchingPoints__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BranchingPoints__Offset, false);}
			
		}
		
		static readonly int bEnableRootMotionTranslation__Offset;
		/// <summary>If this is on, it will allow extracting root motion translation. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
		public bool bEnableRootMotionTranslation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableRootMotionTranslation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int bEnableRootMotionRotation__Offset;
		/// <summary>If this is on, it will allow extracting root motion rotation. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
		public bool bEnableRootMotionRotation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableRootMotionRotation__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int RootMotionRootLock__Offset;
		/// <summary>Root Bone will be locked to that position when extracting root motion. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
		public ERootMotionRootLock RootMotionRootLock
		{
			get{ CheckIsValid();return (ERootMotionRootLock)Marshal.PtrToStructure(_this.Get()+RootMotionRootLock__Offset, typeof(ERootMotionRootLock));}
			
		}
		
		static readonly int PreviewBasePose__Offset;
		/// <summary>Preview Base pose for additive BlendSpace *</summary>
		public UAnimSequence PreviewBasePose
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewBasePose__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + PreviewBasePose__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + PreviewBasePose__Offset, value._this.Get()); }
			
		}
		
		static readonly int BranchingPointMarkers__Offset;
		/// <summary>Cached list of Branching Point markers</summary>
		public TStructArray<FBranchingPointMarker> BranchingPointMarkers
		{
			get{ CheckIsValid();return new TStructArray<FBranchingPointMarker>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BranchingPointMarkers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BranchingPointMarkers__Offset, false);}
			
		}
		
		static readonly int BranchingPointStateNotifyIndices__Offset;
		/// <summary>Keep track of which AnimNotify_State are marked as BranchingPoints, so we can update their state when the Montage is ticked</summary>
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
			PreviewBasePose__Offset=GetPropertyOffset(NativeClassPtr,"PreviewBasePose");
			BranchingPointMarkers__Offset=GetPropertyOffset(NativeClassPtr,"BranchingPointMarkers");
			BranchingPointStateNotifyIndices__Offset=GetPropertyOffset(NativeClassPtr,"BranchingPointStateNotifyIndices");
			
		}
		
	}
	
}
#endif
#endif
