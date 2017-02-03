#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVectorFieldAnimated
	{
		static readonly int Texture__Offset;
		/// <summary>The texture from which to create the vector field.</summary>
		public UTexture2D Texture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Texture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Texture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Texture__Offset, value._this.Get()); }
			
		}
		
		static readonly int ConstructionOp__Offset;
		/// <summary>The operation used to construct the vector field.</summary>
		public EVectorFieldConstructionOp ConstructionOp
		{
			get{ CheckIsValid();return (EVectorFieldConstructionOp)Marshal.PtrToStructure(_this.Get()+ConstructionOp__Offset, typeof(EVectorFieldConstructionOp));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstructionOp__Offset, false);}
			
		}
		
		static readonly int VolumeSizeX__Offset;
		/// <summary>The size of the volume. Valid sizes: 16, 32, 64.</summary>
		public int VolumeSizeX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VolumeSizeX__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeSizeX__Offset, false);}
			
		}
		
		static readonly int VolumeSizeY__Offset;
		/// <summary>The size of the volume. Valid sizes: 16, 32, 64.</summary>
		public int VolumeSizeY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VolumeSizeY__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeSizeY__Offset, false);}
			
		}
		
		static readonly int VolumeSizeZ__Offset;
		/// <summary>The size of the volume. Valid sizes: 16, 32, 64.</summary>
		public int VolumeSizeZ
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VolumeSizeZ__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeSizeZ__Offset, false);}
			
		}
		
		static readonly int SubImagesX__Offset;
		/// <summary>The number of horizontal subimages in the texture atlas.</summary>
		public int SubImagesX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImagesX__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImagesX__Offset, false);}
			
		}
		
		static readonly int SubImagesY__Offset;
		/// <summary>The number of vertical subimages in the texture atlas.</summary>
		public int SubImagesY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImagesY__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImagesY__Offset, false);}
			
		}
		
		static readonly int FrameCount__Offset;
		/// <summary>The number of frames in the atlas.</summary>
		public int FrameCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+FrameCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrameCount__Offset, false);}
			
		}
		
		static readonly int FramesPerSecond__Offset;
		/// <summary>The rate at which to interpolate between frames.</summary>
		public float FramesPerSecond
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FramesPerSecond__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FramesPerSecond__Offset, false);}
			
		}
		
		static readonly int bLoop__Offset;
		/// <summary>Whether or not the simulation should loop.</summary>
		public bool bLoop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoop__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoop__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseField__Offset;
		/// <summary>A static vector field used to add noise.</summary>
		public UVectorFieldStatic NoiseField
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NoiseField__Offset); if (v == IntPtr.Zero)return null; UVectorFieldStatic retValue = new UVectorFieldStatic(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + NoiseField__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + NoiseField__Offset, value._this.Get()); }
			
		}
		
		static readonly int NoiseScale__Offset;
		/// <summary>Scale to apply to vectors in the noise field.</summary>
		public float NoiseScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseScale__Offset, false);}
			
		}
		
		static readonly int NoiseMax__Offset;
		/// <summary>The maximum magnitude of noise vectors to apply.</summary>
		public float NoiseMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseMax__Offset, false);}
			
		}
		
		static UVectorFieldAnimated()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VectorFieldAnimated");
			Texture__Offset=GetPropertyOffset(NativeClassPtr,"Texture");
			ConstructionOp__Offset=GetPropertyOffset(NativeClassPtr,"ConstructionOp");
			VolumeSizeX__Offset=GetPropertyOffset(NativeClassPtr,"VolumeSizeX");
			VolumeSizeY__Offset=GetPropertyOffset(NativeClassPtr,"VolumeSizeY");
			VolumeSizeZ__Offset=GetPropertyOffset(NativeClassPtr,"VolumeSizeZ");
			SubImagesX__Offset=GetPropertyOffset(NativeClassPtr,"SubImagesX");
			SubImagesY__Offset=GetPropertyOffset(NativeClassPtr,"SubImagesY");
			FrameCount__Offset=GetPropertyOffset(NativeClassPtr,"FrameCount");
			FramesPerSecond__Offset=GetPropertyOffset(NativeClassPtr,"FramesPerSecond");
			bLoop__Offset=GetPropertyOffset(NativeClassPtr,"bLoop");
			NoiseField__Offset=GetPropertyOffset(NativeClassPtr,"NoiseField");
			NoiseScale__Offset=GetPropertyOffset(NativeClassPtr,"NoiseScale");
			NoiseMax__Offset=GetPropertyOffset(NativeClassPtr,"NoiseMax");
			
		}
		
	}
	
}
#endif
#endif
