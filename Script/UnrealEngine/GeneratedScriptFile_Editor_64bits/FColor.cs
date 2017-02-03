#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A Color (BGRA).
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Color.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FColor
	{
		[FieldOffset(0)]
		public byte B;
		[FieldOffset(1)]
		public byte G;
		[FieldOffset(2)]
		public byte R;
		[FieldOffset(3)]
		public byte A;
		
	}
	
}
#endif
#endif
