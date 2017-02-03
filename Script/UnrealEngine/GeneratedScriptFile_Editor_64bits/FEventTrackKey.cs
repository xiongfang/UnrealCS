#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Information for one event in the track.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FEventTrackKey
	{
		[FieldOffset(0)]
		public float Time;
		[FieldOffset(4)]
		public FName EventName;
		
	}
	
}
#endif
#endif
