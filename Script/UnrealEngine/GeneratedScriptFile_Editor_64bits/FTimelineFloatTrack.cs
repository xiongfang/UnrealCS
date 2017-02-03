#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct that contains one entry for each vector interpolation performed by the timeline</summary>
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FTimelineFloatTrack
	{
		/// <summary>Float curve to be evaluated</summary>
		/// <summary>Name of track, usually set in Timeline Editor. Used by SetInterpFloatCurve function.</summary>
		[FieldOffset(28)]
		public FName TrackName;
		/// <summary>Name of property that we should update from this curve</summary>
		[FieldOffset(40)]
		public FName FloatPropertyName;
		/// <summary>Cached float property pointer</summary>
		
	}
	
}
#endif
#endif
