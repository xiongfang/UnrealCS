#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTextureRenderTargetCube
	{
		static readonly int SizeX__Offset;
		public int SizeX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeX__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeX__Offset, false);}
			
		}
		
		static readonly int ClearColor__Offset;
		public FLinearColor ClearColor
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+ClearColor__Offset, typeof(FLinearColor));}
			
		}
		
		static readonly int OverrideFormat__Offset;
		public EPixelFormat OverrideFormat
		{
			get{ CheckIsValid();return (EPixelFormat)Marshal.PtrToStructure(_this.Get()+OverrideFormat__Offset, typeof(EPixelFormat));}
			
		}
		
		static readonly int bHDR__Offset;
		public bool bHDR
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHDR__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHDR__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bForceLinearGamma__Offset;
		public bool bForceLinearGamma
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceLinearGamma__Offset, 1, 0, 2, 2);}
			
		}
		
		static UTextureRenderTargetCube()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextureRenderTargetCube");
			SizeX__Offset=GetPropertyOffset(NativeClassPtr,"SizeX");
			ClearColor__Offset=GetPropertyOffset(NativeClassPtr,"ClearColor");
			OverrideFormat__Offset=GetPropertyOffset(NativeClassPtr,"OverrideFormat");
			bHDR__Offset=GetPropertyOffset(NativeClassPtr,"bHDR");
			bForceLinearGamma__Offset=GetPropertyOffset(NativeClassPtr,"bForceLinearGamma");
			
		}
		
	}
	
}
#endif
#endif
