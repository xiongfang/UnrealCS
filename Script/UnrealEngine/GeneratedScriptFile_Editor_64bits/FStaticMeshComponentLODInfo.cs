#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=176)]
	public partial struct FStaticMeshComponentLODInfo
	{
		/// <summary>Vertex data cached at the time this LOD was painted, if any</summary>
		public TStructArray<FPaintedVertex> PaintedVertices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FPaintedVertex>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
