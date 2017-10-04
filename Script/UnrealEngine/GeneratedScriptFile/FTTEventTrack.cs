using System;
namespace UnrealEngine
{
	/// <summary>Structure storing information about one event track</summary>
	public partial struct FTTEventTrack
	{
		/// <summary>Curve object used to store keys</summary>
		public UCurveFloat CurveKeys;
		/// <summary>Name of this track</summary>
		public FName TrackName;
		/// <summary>Flag to identify internal/external curve</summary>
		public bool bIsExternalCurve;
		
	}
	
}
