using System;
namespace UnrealEngine
{
	/// <summary>Struct that contains one entry for each linear color interpolation performed by the timeline</summary>
	public partial struct FTimelineLinearColorTrack
	{
		/// <summary>Float curve to be evaluated</summary>
		public UCurveLinearColor LinearColorCurve;
		/// <summary>Name of track, usually set in Timeline Editor. Used by SetInterpLinearColorCurve function.</summary>
		public FName TrackName;
		/// <summary>Name of property that we should update from this curve</summary>
		public FName LinearColorPropertyName;
		/// <summary>Cached linear color struct property pointer</summary>
		public UStructProperty LinearColorProperty;
		
	}
	
}
