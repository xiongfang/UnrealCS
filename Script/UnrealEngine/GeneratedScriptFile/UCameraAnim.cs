using System;
namespace UnrealEngine
{
	public partial class UCameraAnim:UObject
	{
		/// <summary>The UInterpGroup that holds our actual interpolation data.</summary>
		public UInterpGroup CameraInterpGroup;
		
		/// <summary>This is to preview and they only exists in editor</summary>
		public UInterpGroup PreviewInterpGroup;
		
		/// <summary>Length, in seconds.</summary>
		public float AnimLength;
		
		/// <summary>AABB in local space.</summary>
		public FBox BoundingBox;
		
		/// <summary>
		/// If true, assume all transform keys are intended be offsets from the start of the animation. This allows the animation to be authored at any world location and be applied as a delta to the camera.
		/// If false, assume all transform keys are authored relative to the world origin. Positions will be directly applied as deltas to the camera.
		/// </summary>
		public bool bRelativeToInitialTransform;
		
		/// <summary>
		/// If true, assume all FOV keys are intended be offsets from the start of the animation.
		/// If false, assume all FOV keys are authored relative to the current FOV of the camera at the start of the animation.
		/// </summary>
		public bool bRelativeToInitialFOV;
		
		/// <summary>The base FOV that all FOV keys are relative to.</summary>
		public float BaseFOV;
		
		/// <summary>Default PP settings to put on the animated camera. For modifying PP without keyframes.</summary>
		public FPostProcessSettings BasePostProcessSettings;
		
		/// <summary>Default PP blend weight to put on the animated camera. For modifying PP without keyframes.</summary>
		public float BasePostProcessBlendWeight;
		
		
	}
	
}
