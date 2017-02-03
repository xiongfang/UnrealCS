#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A bounding box.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Box.h
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FBox
	{
		[FieldOffset(0)]
		public FVector Min;
		[FieldOffset(12)]
		public FVector Max;
		[FieldOffset(24)]
		public byte IsValid;
		
	}
	
}
#endif
#endif
