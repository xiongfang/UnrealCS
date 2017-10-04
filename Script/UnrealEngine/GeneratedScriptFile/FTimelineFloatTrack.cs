using System;
namespace UnrealEngine
{
	/// <summary>Struct that contains one entry for each vector interpolation performed by the timeline</summary>
	public partial struct FTimelineFloatTrack
	{
		/// <summary>Float curve to be evaluated</summary>
		public UCurveFloat FloatCurve;
		/// <summary>Name of track, usually set in Timeline Editor. Used by SetInterpFloatCurve function.</summary>
		public FName TrackName;
		/// <summary>Name of property that we should update from this curve</summary>
		public FName FloatPropertyName;
		/// <summary>Cached float property pointer</summary>
		public UFloatProperty FloatProperty;
		
	}
	
}
