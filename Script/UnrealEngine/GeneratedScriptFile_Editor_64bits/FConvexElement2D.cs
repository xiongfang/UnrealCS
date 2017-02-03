#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>One convex hull, used for simplified collision.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FConvexElement2D
	{
		/// <summary>Vertices that lie on the convex hull</summary>
		public TStructArray<FVector2D> VertexData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FVector2D>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
