using System;
namespace UnrealEngine
{
	public partial class USoundNodeEnveloper:USoundNode
	{
		/// <summary>The time in seconds where the envelope's loop begins.</summary>
		public float LoopStart;
		
		/// <summary>The time in seconds where the envelope's loop ends.</summary>
		public float LoopEnd;
		
		/// <summary>The time in seconds it takes the evelope to fade out after the last loop is completed.</summary>
		public float DurationAfterLoop;
		
		/// <summary>The number of times the envelope should loop if looping is enabled and the envelope is not set to loop indefinitely.</summary>
		public int LoopCount;
		
		/// <summary>If enabled, the envelope will continue to loop indefenitely regardless of the Loop Count value.</summary>
		public bool bLoopIndefinitely;
		
		/// <summary>If enabled, the envelope will loop using the loop settings.</summary>
		public bool bLoop;
		
		public UDistributionFloatConstantCurve VolumeInterpCurve;
		
		public UDistributionFloatConstantCurve PitchInterpCurve;
		
		/// <summary>The distribution defining the volume envelope.</summary>
		public FRuntimeFloatCurve VolumeCurve;
		
		/// <summary>The distribution defining the pitch envelope.</summary>
		public FRuntimeFloatCurve PitchCurve;
		
		/// <summary>The lower bound of pitch (1.0 is no change)</summary>
		public float PitchMin;
		
		/// <summary>The upper bound of pitch (1.0 is no change)</summary>
		public float PitchMax;
		
		/// <summary>The lower bound of volume (1.0 is no change)</summary>
		public float VolumeMin;
		
		/// <summary>The upper bound of volume (1.0 is no change)</summary>
		public float VolumeMax;
		
		
	}
	
}
