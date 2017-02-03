#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// An integer vector in 3D space.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\IntVector.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FIntVector
	{
		[FieldOffset(0)]
		public int X;
		[FieldOffset(4)]
		public int Y;
		[FieldOffset(8)]
		public int Z;
		
	}
	
}
#endif
#endif
