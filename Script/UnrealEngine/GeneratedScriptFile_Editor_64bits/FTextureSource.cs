#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Texture source data management.</summary>
	[StructLayout(LayoutKind.Explicit,Size=176)]
	public partial struct FTextureSource
	{
		/// <summary>GUID used to track changes to the source data.</summary>
		[FieldOffset(136)]
		public FGuid Id;
		/// <summary>Width of the texture.</summary>
		[FieldOffset(152)]
		public int SizeX;
		/// <summary>Height of the texture.</summary>
		[FieldOffset(156)]
		public int SizeY;
		/// <summary>Depth (volume textures) or faces (cube maps).</summary>
		[FieldOffset(160)]
		public int NumSlices;
		/// <summary>Number of mips provided as source data for the texture.</summary>
		[FieldOffset(164)]
		public int NumMips;
		/// <summary>RGBA8 source data is optionally compressed as PNG.</summary>
		public bool bPNGCompressed
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 168, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 168, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Legacy textures use a hash instead of a GUID.</summary>
		public bool bGuidIsHash
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 169, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 169, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Format in which the source data is stored.</summary>
		[FieldOffset(170)]
		public ETextureSourceFormat Format;
		
	}
	
}
#endif
#endif
