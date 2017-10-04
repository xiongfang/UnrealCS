using System;
namespace UnrealEngine
{
	public partial class UInterpTrackLinearColorBase:UInterpTrack
	{
		/// <summary>Actually track data containing keyframes of a FVector as it varies over time.</summary>
		public FInterpCurveLinearColor LinearColorTrack;
		
		/// <summary>Tension of curve, used for keypoints using automatic tangents.</summary>
		public float CurveTension;
		
		
	}
	
}
