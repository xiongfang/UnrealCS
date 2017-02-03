#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureSample
	{
		static readonly int Coordinates__Offset;
		/// <summary>Defaults to 'ConstCoordinate' if not specified</summary>
		public FExpressionInput Coordinates
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Coordinates__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int TextureObject__Offset;
		/// <summary>Defaults to 'Texture' if not specified</summary>
		public FExpressionInput TextureObject
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+TextureObject__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int MipValue__Offset;
		/// <summary>Defaults to 'ConstMipValue' if not specified</summary>
		public FExpressionInput MipValue
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+MipValue__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int CoordinatesDX__Offset;
		/// <summary>Coordinates derivative over the X axis</summary>
		public FExpressionInput CoordinatesDX
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+CoordinatesDX__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int CoordinatesDY__Offset;
		/// <summary>Coordinates derivative over the Y axis</summary>
		public FExpressionInput CoordinatesDY
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+CoordinatesDY__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int MipValueMode__Offset;
		/// <summary>Defines how the MipValue property is applied to the texture lookup</summary>
		public ETextureMipValueMode MipValueMode
		{
			get{ CheckIsValid();return (ETextureMipValueMode)Marshal.PtrToStructure(_this.Get()+MipValueMode__Offset, typeof(ETextureMipValueMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MipValueMode__Offset, false);}
			
		}
		
		static readonly int SamplerSource__Offset;
		/// <summary>
		/// Controls where the sampler for this texture lookup will come from.
		/// Choose 'from texture asset' to make use of the UTexture addressing settings,
		/// Otherwise use one of the global samplers, which will not consume a sampler slot.
		/// This allows materials to use more than 16 unique textures on SM5 platforms.
		/// </summary>
		public ESamplerSourceMode SamplerSource
		{
			get{ CheckIsValid();return (ESamplerSourceMode)Marshal.PtrToStructure(_this.Get()+SamplerSource__Offset, typeof(ESamplerSourceMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SamplerSource__Offset, false);}
			
		}
		
		static readonly int ConstCoordinate__Offset;
		/// <summary>only used if Coordinates is not hooked up</summary>
		public uint ConstCoordinate
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+ConstCoordinate__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstCoordinate__Offset, false);}
			
		}
		
		static readonly int ConstMipValue__Offset;
		/// <summary>only used if MipValue is not hooked up</summary>
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
