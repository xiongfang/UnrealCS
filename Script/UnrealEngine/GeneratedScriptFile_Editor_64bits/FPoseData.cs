#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Pose data
	/// This is one pose data structure
	/// This will let us blend poses quickly easily
	/// All poses within this asset should contain same number of tracks,
	/// so that we can blend quickly
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FPoseData
	{
		/// <summary>local space pose, # of array match with # of Tracks</summary>
		public TStructArray<FTransform> LocalSpacePose
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>
		/// whether or not, the joint contains dirty transform
		/// it only blends if this is true
		/// this allows per bone blend
		/// @todo: convert to bit field?
		/// </summary>
		public TStructArray<bool> LocalSpacePoseMask
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<bool>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary># of array match with # of Curves in PoseDataContainer</summary>
		public TStructArray<float> CurveData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
