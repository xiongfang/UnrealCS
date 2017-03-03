#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=160)]
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
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<bool>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+24, false);}}}
			
		}
		public TStructArray<FTriangleSortSettings> TriangleSortSettings
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTriangleSortSettings>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		public bool bHasBeenSimplified
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(64)]
		public FSkeletalMeshOptimizationSettings ReductionSettings;
		public TStructArray<FName> RemovedBones
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+128, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+128, false);}}}
			
		}
		[FieldOffset(144)]
		public FString SourceImportFilename;
		
	}
	
}
#endif
#endif
