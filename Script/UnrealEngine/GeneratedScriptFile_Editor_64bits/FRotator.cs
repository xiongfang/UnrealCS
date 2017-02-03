#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// An orthogonal rotation in 3d space.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Rotator.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FRotator
	{
		/// <summary>Pitch (degrees) around Y axis</summary>
		[FieldOffset(0)]
		public float Pitch;
		/// <summary>Yaw (degrees) around Z axis</summary>
		[FieldOffset(4)]
		public float Yaw;
		/// <summary>Roll (degrees) around X axis</summary>
		[FieldOffset(8)]
		public float Roll;
		
	}
	
}
#endif
#endif
