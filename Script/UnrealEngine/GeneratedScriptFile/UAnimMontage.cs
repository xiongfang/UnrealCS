using System;
namespace UnrealEngine
{
	public partial class UAnimMontage:UAnimCompositeBase
	{
		/// <summary>Blend in option.</summary>
		public FAlphaBlend BlendIn;
		
		public float BlendInTime;
		
		/// <summary>Blend out option. This is only used when it blends out itself. If it's interrupted by other montages, it will use new montage's BlendIn option to blend out.</summary>
		public FAlphaBlend BlendOut;
		
		public float BlendOutTime;
		
		/// <summary>
		/// Time from Sequence End to trigger blend out.
		/// <0 means using BlendOutTime, so BlendOut finishes as Montage ends.
		/// >=0 means using 'SequenceEnd - BlendOutTriggerTime' to trigger blend out.
		/// </summary>
		public float BlendOutTriggerTime;
		
		/// <summary>If you're using marker based sync for this montage, make sure to add sync group name. For now we only support one group</summary>
		public FName SyncGroup;
		
		/// <summary>wip: until we have UI working</summary>
		public int SyncSlotIndex;
		
		public FMarkerSyncData MarkerData;
		
		/// <summary>If this is on, it will allow extracting root motion translation. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
		public bool bEnableRootMotionTranslation;
		
		/// <summary>If this is on, it will allow extracting root motion rotation. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
		public bool bEnableRootMotionRotation;
		
		/// <summary>Root Bone will be locked to that position when extracting root motion. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
		public ERootMotionRootLock RootMotionRootLock;
		
		/// <summary>Preview Base pose for additive BlendSpace *</summary>
		public UAnimSequence PreviewBasePose;
		
		
	}
	
}
