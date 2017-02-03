#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>One convex hull, used for simplified collision.</summary>
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FKConvexElem
	{
		/// <summary>Array of indices that make up the convex hull.</summary>
		public TStructArray<FVector> VertexData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FVector>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		/// <summary>Bounding box of this convex hull.</summary>
		[FieldOffset(48)]
		public FBox ElemBox;
		/// <summary>Transform of this element</summary>
		[FieldOffset(80)]
		public FTransform Transform;
		
	}
	
}
#endif
#endif
