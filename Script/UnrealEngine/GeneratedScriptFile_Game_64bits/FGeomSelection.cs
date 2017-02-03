#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FGeomSelection
	{
		[FieldOffset(0)]
		public int Type;
		[FieldOffset(4)]
		public int Index;
		[FieldOffset(8)]
		public int SelectionIndex;
		
	}
	
}
#endif
#endif
