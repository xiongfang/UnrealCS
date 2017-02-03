#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Screen coordinates.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\IntPoint.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FIntPoint
	{
		[FieldOffset(0)]
		public int X;
		[FieldOffset(4)]
		public int Y;
		
	}
	
}
#endif
#endif
