#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Container for an aggregate of collision shapes</summary>
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FKAggregateGeom
	{
		public TStructArray<FKSphereElem> SphereElems
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FKSphereElem>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		public TStructArray<FKBoxElem> BoxElems
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FKBoxElem>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		public TStructArray<FKSphylElem> SphylElems
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FKSphylElem>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		public TStructArray<FKConvexElem> ConvexElems
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FKConvexElem>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+48, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+48, false);}}}
			
		}
		
	}
	
}
#endif
#endif
