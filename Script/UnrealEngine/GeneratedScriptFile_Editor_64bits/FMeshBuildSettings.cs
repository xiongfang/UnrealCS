#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Settings applied when building a mesh.</summary>
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FMeshBuildSettings
	{
		/// <summary>If true, degenerate triangles will be removed.</summary>
		public bool bUseMikkTSpace
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>If true, normals in the raw mesh are ignored and recomputed.</summary>
		public bool bRecomputeNormals
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 1, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 1, 1, 0, 1, 255); } }}
			
		}
		/// <summary>If true, tangents in the raw mesh are ignored and recomputed.</summary>
		public bool bRecomputeTangents
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 2, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 2, 1, 0, 1, 255); } }}
			
		}
		/// <summary>If true, degenerate triangles will be removed.</summary>
		public bool bRemoveDegenerates
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 3, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 3, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Required for PNT tessellation but can be slow. Recommend disabling for larger meshes.</summary>
		public bool bBuildAdjacencyBuffer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 4, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 4, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Required to optimize mesh in mirrored transform. Double index buffer size.</summary>
		public bool bBuildReversedIndexBuffer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 5, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 5, 1, 0, 1, 255); } }}
			
		}
		/// <summary>If true, Tangents will be stored at 16 bit vs 8 bit precision.</summary>
		public bool bUseHighPrecisionTangentBasis
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 6, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 6, 1, 0, 1, 255); } }}
			
		}
		/// <summary>If true, UVs will be stored at full floating point precision.</summary>
		public bool bUseFullPrecisionUVs
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 7, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 7, 1, 0, 1, 255); } }}
			
		}
		public bool bGenerateLightmapUVs
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(12)]
		public int MinLightmapResolution;
		[FieldOffset(16)]
		public int SrcLightmapIndex;
		[FieldOffset(20)]
		public int DstLightmapIndex;
		[FieldOffset(24)]
		public float BuildScale;
		/// <summary>The local scale applied when building the mesh</summary>
		[FieldOffset(28)]
		public FVector BuildScale3D;
		/// <summary>
		/// Scale to apply to the mesh when allocating the distance field volume texture.
		/// The default scale is 1, which is assuming that the mesh will be placed unscaled in the world.
		/// </summary>
		[FieldOffset(40)]
		public float DistanceFieldResolutionScale;
		/// <summary>
		/// Whether to generate the distance field treating every triangle hit as a front face.
		/// When enabled prevents the distance field from being discarded due to the mesh being open, but also lowers Distance Field AO quality.
		/// </summary>
		public bool bGenerateDistanceFieldAsIfTwoSided
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 44, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 44, 1, 0, 1, 255); } }}
			
		}
		/// <summary>
		/// Adding a constant distance effectively shrinks the distance field representation.
		/// This is useful for preventing self shadowing aritfacts when doing some minor ambient animation.
		/// Thin walls will be affected more severely than large hollow objects, because thin walls don't have a large negative region.
		/// </summary>
		[FieldOffset(48)]
		public float DistanceFieldBias;
		
	}
	
}
#endif
#endif
