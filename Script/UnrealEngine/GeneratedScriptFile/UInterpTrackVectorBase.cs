using System;
namespace UnrealEngine
{
	public partial class UInterpTrackVectorBase:UInterpTrack
	{
		/// <summary>Actually track data containing keyframes of a FVector as it varies over time.</summary>
		public FInterpCurveVector VectorTrack;
		
		/// <summary>Tension of curve, used for keypoints using automatic tangents.</summary>
		public float CurveTension;
		
		
	}
	
}
