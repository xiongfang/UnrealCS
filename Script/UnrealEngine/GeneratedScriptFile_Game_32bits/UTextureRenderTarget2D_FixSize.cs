#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTextureRenderTarget2D
	{
		static readonly int SizeX__Offset;
		public int SizeX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeX__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeX__Offset, false);}
			
		}
		
		static readonly int SizeY__Offset;
		public int SizeY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeY__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeY__Offset, false);}
			
		}
		
		static readonly int ClearColor__Offset;
		public FLinearColor ClearColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ClearColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int AddressX__Offset;
		public TextureAddress AddressX
		{
			get{ CheckIsValid();return (TextureAddress)Marshal.PtrToStructure(_this.Get()+AddressX__Offset, typeof(TextureAddress));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AddressX__Offset, false);}
			
		}
		
		static readonly int AddressY__Offset;
		public TextureAddress AddressY
		{
			get{ CheckIsValid();return (TextureAddress)Marshal.PtrToStructure(_this.Get()+AddressY__Offset, typeof(TextureAddress));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AddressY__Offset, false);}
			
		}
		
		static readonly int bForceLinearGamma__Offset;
		public bool bForceLinearGamma
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceLinearGamma__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHDR__Offset;
		public bool bHDR
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHDR__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHDR__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bGPUSharedFlag__Offset;
		public bool bGPUSharedFlag
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGPUSharedFlag__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGPUSharedFlag__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bAutoGenerateMips__Offset;
		public bool bAutoGenerateMips
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoGenerateMips__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoGenerateMips__Offset, 1,0,8,8);}
			
		}
		
		static readonly int OverrideFormat__Offset;
		public EPixelFormat OverrideFormat
		{
			get{ CheckIsValid();return (EPixelFormat)Marshal.PtrToStructure(_this.Get()+OverrideFormat__Offset, typeof(EPixelFormat));}
			
		}
		
		static UTextureRenderTarget2D()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextureRenderTarget2D");
			SizeX__Offset=GetPropertyOffset(NativeClassPtr,"SizeX");
			SizeY__Offset=GetPropertyOffset(NativeClassPtr,"SizeY");
			ClearColor__Offset=GetPropertyOffset(NativeClassPtr,"ClearColor");
			AddressX__Offset=GetPropertyOffset(NativeClassPtr,"AddressX");
			AddressY__Offset=GetPropertyOffset(NativeClassPtr,"AddressY");
			bForceLinearGamma__Offset=GetPropertyOffset(NativeClassPtr,"bForceLinearGamma");
			bHDR__Offset=GetPropertyOffset(NativeClassPtr,"bHDR");
			bGPUSharedFlag__Offset=GetPropertyOffset(NativeClassPtr,"bGPUSharedFlag");
			bAutoGenerateMips__Offset=GetPropertyOffset(NativeClassPtr,"bAutoGenerateMips");
			OverrideFormat__Offset=GetPropertyOffset(NativeClassPtr,"OverrideFormat");
			
		}
		
	}
	
}
#endif
#endif
