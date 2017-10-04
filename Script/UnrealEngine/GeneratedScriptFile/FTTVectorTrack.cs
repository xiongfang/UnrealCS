using System;
namespace UnrealEngine
{
	/// <summary>Structure storing information about one vector interpolation track</summary>
	public partial struct FTTVectorTrack
	{
		/// <summary>Curve object used to define vector value over time</summary>
		public UCurveVector CurveVector;
		/// <summary>Name of this track</summary>
		public FName TrackName;
		/// <summary>Flag to identify internal/external curve</summary>
		public bool bIsExternalCurve;
		
	}
	
}
