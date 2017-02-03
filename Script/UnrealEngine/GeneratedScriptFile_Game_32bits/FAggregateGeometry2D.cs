#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FAggregateGeometry2D
	{
		public TStructArray<FCircleElement2D> CircleElements
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FCircleElement2D>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		public TStructArray<FBoxElement2D> BoxElements
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBoxElement2D>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+12, false);}}}
			
		}
		public TStructArray<FConvexElement2D> ConvexElements
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FConvexElement2D>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+24, false);}}}
			
		}
		
	}
	
}
#endif
#endif
