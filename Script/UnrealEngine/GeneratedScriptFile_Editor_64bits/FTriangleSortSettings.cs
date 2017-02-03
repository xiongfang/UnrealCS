#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct containing triangle sort settings for a particular section</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
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
