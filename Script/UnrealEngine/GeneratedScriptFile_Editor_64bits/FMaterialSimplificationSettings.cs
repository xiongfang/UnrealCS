#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Use FMaterialProxySettings instead</summary>
	[StructLayout(LayoutKind.Explicit,Size=68)]
	public partial struct FMaterialSimplificationSettings
	{
		/// <summary>Size of generated BaseColor map</summary>
		[FieldOffset(0)]
		public FIntPoint BaseColorMapSize;
		/// <summary>Whether to generate normal map</summary>
		public bool bNormalMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 8, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 8, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Size of generated specular map</summary>
		[FieldOffset(12)]
		public FIntPoint NormalMapSize;
		/// <summary>Metallic constant</summary>
		[FieldOffset(20)]
		public float MetallicConstant;
		/// <summary>Whether to generate metallic map</summary>
		public bool bMetallicMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Size of generated metallic map</summary>
		[FieldOffset(28)]
		public FIntPoint MetallicMapSize;
		/// <summary>Roughness constant</summary>
		[FieldOffset(36)]
		public float RoughnessConstant;
		/// <summary>Whether to generate roughness map</summary>
		public bool bRoughnessMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 40, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 40, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Size of generated roughness map</summary>
		[FieldOffset(44)]
		public FIntPoint RoughnessMapSize;
		/// <summary>Specular constant</summary>
		[FieldOffset(52)]
		public float SpecularConstant;
		/// <summary>Whether to generate specular map</summary>
		public bool bSpecularMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Size of generated specular map</summary>
		[FieldOffset(60)]
		public FIntPoint SpecularMapSize;
		
	}
	
}
#endif
#endif
