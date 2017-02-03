#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A 4-D homogeneous vector.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Vector4.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FVector4
	{
		[FieldOffset(0)]
		public float X;
		[FieldOffset(4)]
		public float Y;
		[FieldOffset(8)]
		public float Z;
		[FieldOffset(12)]
		public float W;
		
	}
	
}
#endif
#endif
