using System;
namespace UnrealEngine
{
	public partial class USoundNodeModulator:USoundNode
	{
		/// <summary>The lower bound of pitch (1.0 is no change).</summary>
		public float PitchMin;
		
		/// <summary>The upper bound of pitch (1.0 is no change).</summary>
		public float PitchMax;
		
		/// <summary>The lower bound of volume (1.0 is no change).</summary>
		public float VolumeMin;
		
		/// <summary>The upper bound of volume (1.0 is no change).</summary>
		public float VolumeMax;
		
		
	}
	
}
