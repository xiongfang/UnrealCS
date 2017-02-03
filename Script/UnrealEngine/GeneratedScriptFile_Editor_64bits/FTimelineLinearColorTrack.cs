#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct that contains one entry for each linear color interpolation performed by the timeline</summary>
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FTimelineLinearColorTrack
	{
		/// <summary>Float curve to be evaluated</summary>
		/// <summary>Name of track, usually set in Timeline Editor. Used by SetInterpLinearColorCurve function.</summary>
		[FieldOffset(28)]
		public FName TrackName;
		/// <summary>Name of property that we should update from this curve</summary>
		[FieldOffset(40)]
		public FName LinearColorPropertyName;
		/// <summary>Cached linear color struct property pointer</summary>
		
	}
	
}
#endif
#endif
