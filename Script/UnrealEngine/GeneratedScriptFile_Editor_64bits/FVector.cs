#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A point or direction FVector in 3d space.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Vector.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FVector
	{
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
