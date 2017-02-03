#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UStereoLayerComponent
	{
		static readonly int bLiveTexture__Offset;
		public bool bLiveTexture
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLiveTexture__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLiveTexture__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bNoAlphaChannel__Offset;
		public bool bNoAlphaChannel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoAlphaChannel__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNoAlphaChannel__Offset, 1,0,2,2);}
			
		}
		
		static readonly int Texture__Offset;
		public UTexture Texture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Texture__Offset); if (v == IntPtr.Zero)return null; UTexture retValue = new UTexture(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Texture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Texture__Offset, value._this.Get()); }
			
		}
		
		static readonly int bQuadPreserveTextureRatio__Offset;
		public bool bQuadPreserveTextureRatio
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bQuadPreserveTextureRatio__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bQuadPreserveTextureRatio__Offset, 1,0,1,1);}
			
		}
		
		static readonly int QuadSize__Offset;
		public FVector2D QuadSize
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+QuadSize__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+QuadSize__Offset, false);}
			
		}
		
		static readonly int UVRect__Offset;
		public FBox2D UVRect
		{
			get{ CheckIsValid();return (FBox2D)Marshal.PtrToStructure(_this.Get()+UVRect__Offset, typeof(FBox2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UVRect__Offset, false);}
			
		}
		
		static readonly int StereoLayerType__Offset;
		public EStereoLayerType StereoLayerType
		{
			get{ CheckIsValid();return (EStereoLayerType)Marshal.PtrToStructure(_this.Get()+StereoLayerType__Offset, typeof(EStereoLayerType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StereoLayerType__Offset, false);}
			
		}
		
		static readonly int Priority__Offset;
		public int Priority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Priority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Priority__Offset, false);}
			
		}
		
		static UStereoLayerComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("StereoLayerComponent");
			bLiveTexture__Offset=GetPropertyOffset(NativeClassPtr,"bLiveTexture");
			bNoAlphaChannel__Offset=GetPropertyOffset(NativeClassPtr,"bNoAlphaChannel");
			Texture__Offset=GetPropertyOffset(NativeClassPtr,"Texture");
			bQuadPreserveTextureRatio__Offset=GetPropertyOffset(NativeClassPtr,"bQuadPreserveTextureRatio");
			QuadSize__Offset=GetPropertyOffset(NativeClassPtr,"QuadSize");
			UVRect__Offset=GetPropertyOffset(NativeClassPtr,"UVRect");
			StereoLayerType__Offset=GetPropertyOffset(NativeClassPtr,"StereoLayerType");
			Priority__Offset=GetPropertyOffset(NativeClassPtr,"Priority");
			
		}
		
	}
	
}
#endif
#endif
