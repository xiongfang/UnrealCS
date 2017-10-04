using System;
namespace UnrealEngine
{
	public partial class UAnimSequenceBase:UAnimationAsset
	{
		/// <summary>Returns the total play length of the montage, if played back with a speed of 1.0.</summary>
		public extern virtual float GetPlayLength();
		/// <summary>Length (in seconds) of this AnimSequence if played back with a speed of 1.0.</summary>
		public float SequenceLength;
		
		/// <summary>Number for tweaking playback rate of this animation globally.</summary>
		public float RateScale;
		
		/// <summary>Raw uncompressed float curve data</summary>
		public FRawCurveTracks RawCurveData;
		
		
	}
	
}
