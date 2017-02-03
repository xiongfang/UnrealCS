#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FKConvexElem
	{
		public TStructArray<FVector> VertexData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FVector>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		[FieldOffset(28)]
		public FBox ElemBox;
		[FieldOffset(64)]
		public FTransform Transform;
		
	}
	
}
#endif
#endif
