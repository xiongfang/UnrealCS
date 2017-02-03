#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVectorFieldAnimated
	{
		static readonly int Texture__Offset;
		public UTexture2D Texture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Texture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Texture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Texture__Offset, value._this.Get()); }
			
		}
		
		static readonly int ConstructionOp__Offset;
		public EVectorFieldConstructionOp ConstructionOp
		{
			get{ CheckIsValid();return (EVectorFieldConstructionOp)Marshal.PtrToStructure(_this.Get()+ConstructionOp__Offset, typeof(EVectorFieldConstructionOp));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstructionOp__Offset, false);}
			
		}
		
		static readonly int VolumeSizeX__Offset;
		public int VolumeSizeX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VolumeSizeX__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeSizeX__Offset, false);}
			
		}
		
		static readonly int VolumeSizeY__Offset;
		public int VolumeSizeY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VolumeSizeY__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeSizeY__Offset, false);}
			
		}
		
		static readonly int VolumeSizeZ__Offset;
		public int VolumeSizeZ
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VolumeSizeZ__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeSizeZ__Offset, false);}
			
		}
		
		static readonly int SubImagesX__Offset;
		public int SubImagesX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImagesX__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImagesX__Offset, false);}
			
		}
		
		static readonly int SubImagesY__Offset;
		public int SubImagesY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImagesY__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImagesY__Offset, false);}
			
		}
		
		static readonly int FrameCount__Offset;
		public int FrameCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+FrameCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FrameCount__Offset, false);}
			
		}
		
		static readonly int FramesPerSecond__Offset;
		public float FramesPerSecond
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FramesPerSecond__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FramesPerSecond__Offset, false);}
			
		}
		
		static readonly int bLoop__Offset;
		public bool bLoop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoop__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoop__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NoiseField__Offset;
		public UVectorFieldStatic NoiseField
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NoiseField__Offset); if (v == IntPtr.Zero)return null; UVectorFieldStatic retValue = new UVectorFieldStatic(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + NoiseField__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + NoiseField__Offset, value._this.Get()); }
			
		}
		
		static readonly int NoiseScale__Offset;
		public float NoiseScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NoiseScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NoiseScale__Offset, false);}
			
		}
		
		static readonly int NoiseMax__Offset;
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
