#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FSkeletalMeshOptimizationSettings
	{
		[FieldOffset(0)]
		public SkeletalMeshOptimizationType ReductionMethod;
		[FieldOffset(4)]
		public float NumOfTrianglesPercentage;
		[FieldOffset(8)]
		public float MaxDeviationPercentage;
		[FieldOffset(12)]
		public float WeldingThreshold;
		public bool bRecalcNormals
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(20)]
		public float NormalsThreshold;
		[FieldOffset(24)]
		public SkeletalMeshOptimizationImportance SilhouetteImportance;
		[FieldOffset(25)]
		public SkeletalMeshOptimizationImportance TextureImportance;
		[FieldOffset(26)]
		public SkeletalMeshOptimizationImportance ShadingImportance;
		[FieldOffset(27)]
		public SkeletalMeshOptimizationImportance SkinningImportance;
		[FieldOffset(28)]
		public float BoneReductionRatio;
		[FieldOffset(32)]
		public int MaxBonesPerVertex;
		public TStructArray<FBoneReference> BonesToRemove
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FBoneReference>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		[FieldOffset(56)]
		public int BaseLOD;
		
	}
	
}
#endif
#endif
