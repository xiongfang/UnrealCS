using System;
namespace UnrealEngine
{
	public partial class UBlendSpaceBase:UAnimationAsset
	{
		/// <summary>
		/// When you use blend per bone, allows rotation to blend in mesh space. This only works if this does not contain additive animation samples
		/// This is more performance intensive
		/// </summary>
		public bool bRotationBlendInMeshSpace;
		
		/// <summary>Preview Base pose for additive BlendSpace *</summary>
		public UAnimSequence PreviewBasePose;
		
		/// <summary>This animation length changes based on current input (resulting in different blend time)*</summary>
		public float AnimLength;
		
		/// <summary>Input interpolation parameter for all 3 axis, for each axis input, decide how you'd like to interpolate input to</summary>
		public FInterpolationParameter InterpolationParam;
		
		/// <summary>
		/// Target weight interpolation. When target samples are set, how fast you'd like to get to target. Improve target blending.
		/// i.e. for locomotion, if you interpolate input, when you move from left to right rapidly, you'll interpolate through forward, but if you use target weight interpolation,
		/// you'll skip forward, but interpolate between left to right
		/// </summary>
		public float TargetWeightInterpolationSpeedPerSec;
		
		/// <summary>
		/// The current mode used by the blendspace to decide which animation notifies to fire. Valid options are:
		///       - AllAnimations - All notify events will fire
		///       - HighestWeightedAnimation - Notify events will only fire from the highest weighted animation
		///       - None - No notify events will fire from any animations
		/// </summary>
		public ENotifyTriggerMode NotifyTriggerMode;
		
		/// <summary>
		/// Track index to get marker data from. Samples are tested for the suitability of marker based sync
		///           during load and if we can use marker based sync we cache an index to a representative sample here
		/// </summary>
		public int SampleIndexWithMarkers;
		
		/// <summary>Blend Parameters for each axis. *</summary>
		public FBlendParameter BlendParameters;
		
		
	}
	
}
