#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A point or direction FVector in 2d space.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Vector2D.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FVector2D
	{
		[FieldOffset(0)]
		public float X;
		[FieldOffset(4)]
		public float Y;
		
	}
	
}
#endif
#endif
