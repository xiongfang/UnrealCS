#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FPoseDataContainer
	{
		public TStructArray<FSmartName> PoseNames
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FSmartName>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		public TStructArray<FPoseData> Poses
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FPoseData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		public TStructArray<FName> Tracks
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		public TStructArray<FAnimCurveBase> Curves
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FAnimCurveBase>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+128, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+128, false);}}}
			
		}
		
	}
	
}
#endif
#endif
