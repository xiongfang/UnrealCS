#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=68)]
	public partial struct FLightmassWorldInfoSettings
	{
		[FieldOffset(0)]
		public float StaticLightingLevelScale;
		[FieldOffset(4)]
		public int NumIndirectLightingBounces;
		[FieldOffset(8)]
		public float IndirectLightingQuality;
		[FieldOffset(12)]
		public float IndirectLightingSmoothness;
		[FieldOffset(16)]
		public FColor EnvironmentColor;
		[FieldOffset(20)]
		public float EnvironmentIntensity;
		[FieldOffset(24)]
		public float EmissiveBoost;
		[FieldOffset(28)]
		public float DiffuseBoost;
		public bool bUseAmbientOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 1); } }}
			
		}
		public bool bGenerateAmbientOcclusionMaterialMask
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 2, 2); } }}
			
		}
		[FieldOffset(36)]
		public float DirectIlluminationOcclusionFraction;
		[FieldOffset(40)]
		public float IndirectIlluminationOcclusionFraction;
		[FieldOffset(44)]
		public float OcclusionExponent;
		[FieldOffset(48)]
		public float FullyOccludedSamplesFraction;
		[FieldOffset(52)]
		public float MaxOcclusionDistance;
		public bool bVisualizeMaterialDiffuse
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 1); } }}
			
		}
		public bool bVisualizeAmbientOcclusion
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 2, 2); } }}
			
		}
		[FieldOffset(60)]
		public float VolumeLightSamplePlacementScale;
		public bool bCompressLightmaps
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 64, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 64, 1, 0, 1, 1); } }}
			
		}
		
	}
	
}
#endif
#endif
