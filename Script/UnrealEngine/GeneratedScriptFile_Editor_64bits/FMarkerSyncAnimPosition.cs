#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Represent a current play position in an animation
	/// based on sync markers
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FMarkerSyncAnimPosition
	{
		/// <summary>The marker we have passed</summary>
		[FieldOffset(0)]
		public FName PreviousMarkerName;
		/// <summary>The marker we are heading towards</summary>
		[FieldOffset(12)]
		public FName NextMarkerName;
		/// <summary>
		/// Value between 0 and 1 representing where we are:
		///       0   we are at PreviousMarker
		///       1   we are at NextMarker
		///       0.5 we are half way between the two
		/// </summary>
		[FieldOffset(24)]
		public float PositionBetweenMarkers;
		
	}
	
}
#endif
#endif
