#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A geometry layer within the stereo rendered viewport.</summary>
	public partial class UStereoLayerComponent
	{
		static readonly int bLiveTexture__Offset;
		/// <summary>True if the stereo layer texture needs to update itself every frame(scene capture, video, etc.)</summary>
		public bool bLiveTexture
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLiveTexture__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLiveTexture__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bNoAlphaChannel__Offset;
		/// <summary>True if the texture should not use it's own alpha channel (1.0 will be substituted)</summary>
		public bool bNoAlphaChannel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNoAlphaChannel__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNoAlphaChannel__Offset, 1,0,2,2);}
			
		}
		
		static readonly int Texture__Offset;
		/// <summary>Texture displayed on the stereo layer *</summary>
		public UTexture Texture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Texture__Offset); if (v == IntPtr.Zero)return null; UTexture retValue = new UTexture(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Texture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Texture__Offset, value._this.Get()); }
			
		}
		
		static readonly int bQuadPreserveTextureRatio__Offset;
		/// <summary>True if the quad should internally set it's Y value based on the set texture's dimensions</summary>
		public bool bQuadPreserveTextureRatio
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bQuadPreserveTextureRatio__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bQuadPreserveTextureRatio__Offset, 1,0,1,1);}
			
		}
		
		static readonly int QuadSize__Offset;
		/// <summary>Size of the rendered stereo layer quad *</summary>
		public FVector2D QuadSize
		{
			get{ CheckIsValid();return (FVector2D)Marshal.PtrToStructure(_this.Get()+QuadSize__Offset, typeof(FVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+QuadSize__Offset, false);}
			
		}
		
		static readonly int UVRect__Offset;
		/// <summary>UV coordinates mapped to the quad face *</summary>
		public FBox2D UVRect
		{
			get{ CheckIsValid();return (FBox2D)Marshal.PtrToStructure(_this.Get()+UVRect__Offset, typeof(FBox2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UVRect__Offset, false);}
			
		}
		
		static readonly int StereoLayerType__Offset;
		/// <summary>Specifies how and where the quad is rendered to the screen *</summary>
		public EStereoLayerType StereoLayerType
		{
			get{ CheckIsValid();return (EStereoLayerType)Marshal.PtrToStructure(_this.Get()+StereoLayerType__Offset, typeof(EStereoLayerType));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StereoLayerType__Offset, false);}
			
		}
		
		static readonly int Priority__Offset;
		/// <summary>Render priority among all stereo layers, higher priority render on top of lower priority *</summary>
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
