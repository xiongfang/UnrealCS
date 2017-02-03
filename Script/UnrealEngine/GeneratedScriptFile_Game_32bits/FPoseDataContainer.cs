#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=108)]
	public partial struct FPoseDataContainer
	{
		public TStructArray<FSmartName> PoseNames
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FSmartName>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		public TStructArray<FPoseData> Poses
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FPoseData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+12, false);}}}
			
		}
		public TStructArray<FName> Tracks
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+24, false);}}}
			
		}
		public TStructArray<FAnimCurveBase> Curves
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FAnimCurveBase>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+96, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+96, false);}}}
			
		}
		
	}
	
}
#endif
#endif
