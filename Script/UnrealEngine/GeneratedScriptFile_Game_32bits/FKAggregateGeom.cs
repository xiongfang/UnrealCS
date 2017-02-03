#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=52)]
	public partial struct FKAggregateGeom
	{
		public TStructArray<FKSphereElem> SphereElems
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FKSphereElem>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		public TStructArray<FKBoxElem> BoxElems
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FKBoxElem>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+12, false);}}}
			
		}
		public TStructArray<FKSphylElem> SphylElems
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FKSphylElem>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+24, false);}}}
			
		}
		public TStructArray<FKConvexElem> ConvexElems
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FKConvexElem>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+36, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+36, false);}}}
			
		}
		
	}
	
}
#endif
#endif
