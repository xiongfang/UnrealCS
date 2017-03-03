#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FPoseSnapshot
	{
		public TStructArray<FTransform> LocalTransforms
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTransform>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		public TStructArray<FName> BoneNames
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		[FieldOffset(32)]
		public FName SkeletalMeshName;
		[FieldOffset(40)]
		public FName SnapshotName;
		public bool bIsValid
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 48, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 48, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
