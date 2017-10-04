using System;
namespace UnrealEngine
{
	public partial class UInterpTrackFloatBase:UInterpTrack
	{
		/// <summary>Actually track data containing keyframes of float as it varies over time.</summary>
		public FInterpCurveFloat FloatTrack;
		
		/// <summary>Tension of curve, used for keypoints using automatic tangents.</summary>
		public float CurveTension;
		
		
	}
	
}
