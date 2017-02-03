#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureSample
	{
		static readonly int Coordinates__Offset;
		public FExpressionInput Coordinates
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Coordinates__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int TextureObject__Offset;
		public FExpressionInput TextureObject
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+TextureObject__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int MipValue__Offset;
		public FExpressionInput MipValue
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+MipValue__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int CoordinatesDX__Offset;
		public FExpressionInput CoordinatesDX
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+CoordinatesDX__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int CoordinatesDY__Offset;
		public FExpressionInput CoordinatesDY
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+CoordinatesDY__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int MipValueMode__Offset;
		public ETextureMipValueMode MipValueMode
		{
			get{ CheckIsValid();return (ETextureMipValueMode)Marshal.PtrToStructure(_this.Get()+MipValueMode__Offset, typeof(ETextureMipValueMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MipValueMode__Offset, false);}
			
		}
		
		static readonly int SamplerSource__Offset;
		public ESamplerSourceMode SamplerSource
		{
			get{ CheckIsValid();return (ESamplerSourceMode)Marshal.PtrToStructure(_this.Get()+SamplerSource__Offset, typeof(ESamplerSourceMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SamplerSource__Offset, false);}
			
		}
		
		static readonly int ConstCoordinate__Offset;
		public uint ConstCoordinate
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+ConstCoordinate__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstCoordinate__Offset, false);}
			
		}
		
		static readonly int ConstMipValue__Offset;
		public int ConstMipValue
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ConstMipValue__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstMipValue__Offset, false);}
			
		}
		
		static UMaterialExpressionTextureSample()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionTextureSample");
			Coordinates__Offset=GetPropertyOffset(NativeClassPtr,"Coordinates");
			TextureObject__Offset=GetPropertyOffset(NativeClassPtr,"TextureObject");
			MipValue__Offset=GetPropertyOffset(NativeClassPtr,"MipValue");
			CoordinatesDX__Offset=GetPropertyOffset(NativeClassPtr,"CoordinatesDX");
			CoordinatesDY__Offset=GetPropertyOffset(NativeClassPtr,"CoordinatesDY");
			MipValueMode__Offset=GetPropertyOffset(NativeClassPtr,"MipValueMode");
			SamplerSource__Offset=GetPropertyOffset(NativeClassPtr,"SamplerSource");
			ConstCoordinate__Offset=GetPropertyOffset(NativeClassPtr,"ConstCoordinate");
			ConstMipValue__Offset=GetPropertyOffset(NativeClassPtr,"ConstMipValue");
			
		}
		
	}
	
}
#endif
#endif
