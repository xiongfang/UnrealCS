using System;
namespace UnrealEngine
{
	/// <summary>Structure storing information about one float interpolation track</summary>
	public partial struct FTTFloatTrack
	{
		/// <summary>Curve object used to define float value over time</summary>
		public UCurveFloat CurveFloat;
		/// <summary>Name of this track</summary>
		public FName TrackName;
		/// <summary>Flag to identify internal/external curve</summary>
		public bool bIsExternalCurve;
		
	}
	
}
