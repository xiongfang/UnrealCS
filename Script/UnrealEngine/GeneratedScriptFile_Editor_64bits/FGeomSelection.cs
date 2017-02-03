#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Selection information for geometry mode</summary>
	[StructLayout(LayoutKind.Explicit,Size=12)]
	public partial struct FGeomSelection
	{
		[FieldOffset(0)]
		public int Type;
		/// <summary>EGeometrySelectionType_</summary>
		[FieldOffset(4)]
		public int Index;
		/// <summary>Index into the geometry data structures</summary>
		[FieldOffset(8)]
		public int SelectionIndex;
		
	}
	
}
#endif
#endif
