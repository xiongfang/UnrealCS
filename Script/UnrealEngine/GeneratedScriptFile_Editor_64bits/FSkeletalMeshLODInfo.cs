#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct containing information for a particular LOD level, such as materials and info for when to use it.</summary>
	[StructLayout(LayoutKind.Explicit,Size=160)]
	public partial struct FSkeletalMeshLODInfo
	{
		/// <summary>
		/// ScreenSize to display this LOD.
		/// The screen size is based around the projected diameter of the bounding
		/// sphere of the model. i.e. 0.5 means half the screen's maximum dimension.
		/// </summary>
		[FieldOffset(0)]
		public float ScreenSize;
		/// <summary>Used to avoid 'flickering' when on LOD boundary. Only taken into account when moving from complex->simple.</summary>
		[FieldOffset(4)]
		public float LODHysteresis;
		/// <summary>Mapping table from this LOD's materials to the USkeletalMesh materials array.</summary>
		public TStructArray<int> LODMaterialMap
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+8, false);}}}
			
		}
		/// <summary>Per-section control over whether to enable shadow casting.</summary>
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
		/// <summary>Whether to disable morph targets for this LOD.</summary>
		public bool bHasBeenSimplified
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Reduction settings to apply when building render data.</summary>
		[FieldOffset(64)]
		public FSkeletalMeshOptimizationSettings ReductionSettings;
		/// <summary>This has been removed in editor. We could re-apply this in import time or by mesh reduction utilities</summary>
		public TStructArray<FName> RemovedBones
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+128, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+128, false);}}}
			
		}
		/// <summary>The filename of the file tha was used to import this LOD if it was not auto generated.</summary>
		[FieldOffset(144)]
		public FString SourceImportFilename;
		
	}
	
}
#endif
#endif
