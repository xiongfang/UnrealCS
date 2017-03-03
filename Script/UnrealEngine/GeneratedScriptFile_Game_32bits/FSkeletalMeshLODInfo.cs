#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=124)]
	public partial struct FSkeletalMeshLODInfo
	{
		[FieldOffset(0)]
		public float ScreenSize;
		[FieldOffset(4)]
		public float LODHysteresis;
		public TStructArray<int> LODMaterialMap
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+8, false);}}}
			
		}
		public TStructArray<bool> bEnableShadowCasting
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<bool>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+20, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+20, false);}}}
			
		}
		public TStructArray<FTriangleSortSettings> TriangleSortSettings
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTriangleSortSettings>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		public bool bHasBeenSimplified
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 44, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 44, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(48)]
		public FSkeletalMeshOptimizationSettings ReductionSettings;
		public TStructArray<FName> RemovedBones
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+100, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+100, false);}}}
			
		}
		[FieldOffset(112)]
		public FString SourceImportFilename;
		
	}
	
}
#endif
#endif
