#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FAnimSyncMarker
	{
		/// <summary>The name of this marker</summary>
		[FieldOffset(0)]
		public FName MarkerName;
		/// <summary>Time in seconds of this marker</summary>
		[FieldOffset(12)]
		public float Time;
		/// <summary>The editor track this marker sits on</summary>
		[FieldOffset(16)]
		public int TrackIndex;
		
	}
	
}
#endif
#endif
