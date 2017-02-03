#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FKConvexElem
	{
		public TStructArray<FVector> VertexData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FVector>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		[FieldOffset(48)]
		public FBox ElemBox;
		[FieldOffset(80)]
		public FTransform Transform;
		
	}
	
}
#endif
#endif
