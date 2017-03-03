#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FTriangleSortSettings
	{
		[FieldOffset(0)]
		public ETriangleSortOption TriangleSorting;
		[FieldOffset(1)]
		public ETriangleSortAxis CustomLeftRightAxis;
		[FieldOffset(4)]
		public FName CustomLeftRightBoneName;
		
	}
	
}
#endif
#endif
