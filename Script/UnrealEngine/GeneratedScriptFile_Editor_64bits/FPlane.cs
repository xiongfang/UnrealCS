#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A plane definition in 3D space.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Plane.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FPlane
	{
		[FieldOffset(12)]
		public float W;
		[FieldOffset(0)]
		public float X;
		[FieldOffset(4)]
		public float Y;
		[FieldOffset(8)]
		public float Z;
		
	}
	
}
#endif
#endif
