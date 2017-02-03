#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A rectangular 2D Box.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Box2D.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FBox2D
	{
		[FieldOffset(0)]
		public FVector2D Min;
		[FieldOffset(8)]
		public FVector2D Max;
		[FieldOffset(16)]
		public byte IsValid;
		
	}
	
}
#endif
#endif
