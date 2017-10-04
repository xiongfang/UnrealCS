using System;
namespace UnrealEngine
{
	/// <summary>Structure storing information about one color interpolation track</summary>
	public partial struct FTTLinearColorTrack
	{
		/// <summary>Curve object used to define color value over time</summary>
		public UCurveLinearColor CurveLinearColor;
		/// <summary>Name of this track</summary>
		public FName TrackName;
		/// <summary>Flag to identify internal/external curve</summary>
		public bool bIsExternalCurve;
		
	}
	
}
