#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSpriteCategoryInfo
	{
		[FieldOffset(0)]
		public FName Category;
		[FieldOffset(8)]
		public FText DisplayName;
		[FieldOffset(20)]
		public FText Description;
		
	}
	
}
#endif
#endif
