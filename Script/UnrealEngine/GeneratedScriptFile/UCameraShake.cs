using System;
namespace UnrealEngine
{
	public partial class UCameraShake:UObject
	{
		/// <summary>
		/// If true to only allow a single instance of this shake class to play at any given time.
		/// Subsequent attempts to play this shake will simply restart the timer.
		/// </summary>
		public bool bSingleInstance;
		
		/// <summary>Duration in seconds of current screen shake. Less than 0 means indefinite, 0 means no oscillation.</summary>
		public float OscillationDuration;
		
		/// <summary>Duration of the blend-in, where the oscillation scales from 0 to 1.</summary>
		public float OscillationBlendInTime;
		
		/// <summary>Duration of the blend-out, where the oscillation scales from 1 to 0.</summary>
		public float OscillationBlendOutTime;
		
		/// <summary>Rotational oscillation</summary>
		public FROscillator RotOscillation;
		
		/// <summary>Positional oscillation</summary>
		public FVOscillator LocOscillation;
		
		/// <summary>FOV oscillation</summary>
		public FFOscillator FOVOscillation;
		
		/// <summary>Scalar defining how fast to play the anim.</summary>
		public float AnimPlayRate;
		
		/// <summary>Scalar defining how "intense" to play the anim.</summary>
		public float AnimScale;
		
		/// <summary>Linear blend-in time.</summary>
		public float AnimBlendInTime;
		
		/// <summary>Linear blend-out time.</summary>
		public float AnimBlendOutTime;
		
		/// <summary>When bRandomAnimSegment is true, this defines how long the anim should play.</summary>
		public float RandomAnimSegmentDuration;
		
		/// <summary>Source camera animation to play. Can be null.</summary>
		public UCameraAnim Anim;
		
		/// <summary>
		/// If true, play a random snippet of the animation of length Duration.  Implies bLoop and bRandomStartTime = true for the CameraAnim.
		/// If false, play the full anim once, non-looped. Useful for getting variety out of a single looped CameraAnim asset.
		/// </summary>
		public bool bRandomAnimSegment;
		
		public APlayerCameraManager CameraOwner;
		
		/// <summary>Overall intensity scale for this shake instance.</summary>
		public float ShakeScale;
		
		/// <summary>Time remaining for oscillation shakes. Less than 0.f means shake infinitely.</summary>
		public float OscillatorTimeRemaining;
		
		/// <summary>The playing instance of the CameraAnim-based shake, if any.</summary>
		public UCameraAnimInst AnimInst;
		
		
	}
	
}
