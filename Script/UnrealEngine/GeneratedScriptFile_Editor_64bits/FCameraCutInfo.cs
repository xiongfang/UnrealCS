#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Helper struct for storing the camera world-position for each camera cut in the cinematic.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FCameraCutInfo
	{
		[FieldOffset(0)]
		public FVector Location;
		[FieldOffset(12)]
		public float TimeStamp;
		
	}
	
}
#endif
#endif
