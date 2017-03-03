#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FBuilderPoly
	{
		public TStructArray<int> VertexIndices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		[FieldOffset(12)]
		public int Direction;
		[FieldOffset(16)]
		public FName ItemName;
		[FieldOffset(24)]
		public int PolyFlags;
		
	}
	
}
#endif
#endif
