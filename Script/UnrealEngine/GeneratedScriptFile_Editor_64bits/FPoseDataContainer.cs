#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Pose data container
	/// Contains animation and curve for all poses
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FPoseDataContainer
	{
		/// <summary>
		/// pose names - horizontal data
		/// # of poses - there is no compression across tracks -
		/// unfortunately, tried TMap, but it is not great because it changes order whenever add/remove
		/// we need consistent array of names, so that it doesn't change orders
		/// </summary>
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
		/// <summary>curve meta data # of Curve UIDs should match with Poses.CurveValues.Num</summary>
		public TStructArray<FAnimCurveBase> Curves
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FAnimCurveBase>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+128, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+128, false);}}}
			
		}
		
	}
	
}
#endif
#endif
