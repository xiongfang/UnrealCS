using System;
namespace UnrealEngine
{
	/// <summary>Struct that contains one entry for each vector interpolation performed by the timeline</summary>
	public partial struct FTimelineVectorTrack
	{
		/// <summary>Vector curve to be evaluated</summary>
		public UCurveVector VectorCurve;
		/// <summary>Name of track, usually set in Timeline Editor. Used by SetInterpVectorCurve function.</summary>
		public FName TrackName;
		/// <summary>Name of property that we should update from this curve</summary>
		public FName VectorPropertyName;
		/// <summary>Cached vector struct property pointer</summary>
		public UStructProperty VectorProperty;
		
	}
	
}
