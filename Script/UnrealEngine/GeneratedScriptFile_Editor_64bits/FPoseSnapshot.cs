#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A pose for a skeletal mesh</summary>
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FPoseSnapshot
	{
		/// <summary>Array of transforms per-bone</summary>
		public TStructArray<FTransform> LocalTransforms
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>Array of bone names (corresponding to LocalTransforms)</summary>
		public TStructArray<FName> BoneNames
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>The name of the skeletal mesh that was used to take this snapshot</summary>
		[FieldOffset(32)]
		public FName SkeletalMeshName;
		/// <summary>The name for this snapshot</summary>
		[FieldOffset(44)]
		public FName SnapshotName;
		/// <summary>Whether the pose is valid</summary>
		public bool bIsValid
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
