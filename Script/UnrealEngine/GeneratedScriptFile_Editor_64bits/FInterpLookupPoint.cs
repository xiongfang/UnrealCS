#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Array of group names to retrieve position and rotation data from instead of using the data stored in the keyframe.
	/// A value of NAME_None means to use the PosTrack and EulerTrack data for the keyframe.
	/// There needs to be the same amount of elements in this array as there are keyframes.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FInterpLookupPoint
	{
		[FieldOffset(0)]
		public FName GroupName;
		[FieldOffset(12)]
		public float Time;
		
	}
	
}
#endif
#endif
