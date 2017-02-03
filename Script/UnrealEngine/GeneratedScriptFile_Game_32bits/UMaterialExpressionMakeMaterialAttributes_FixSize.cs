#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionMakeMaterialAttributes
	{
		static readonly int BaseColor__Offset;
		public FExpressionInput BaseColor
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+BaseColor__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Metallic__Offset;
		public FExpressionInput Metallic
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Metallic__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Specular__Offset;
		public FExpressionInput Specular
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Specular__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Roughness__Offset;
		public FExpressionInput Roughness
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Roughness__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int EmissiveColor__Offset;
		public FExpressionInput EmissiveColor
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+EmissiveColor__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Opacity__Offset;
		public FExpressionInput Opacity
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Opacity__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int OpacityMask__Offset;
		public FExpressionInput OpacityMask
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+OpacityMask__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Normal__Offset;
		public FExpressionInput Normal
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Normal__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int WorldPositionOffset__Offset;
		public FExpressionInput WorldPositionOffset
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+WorldPositionOffset__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int WorldDisplacement__Offset;
		public FExpressionInput WorldDisplacement
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+WorldDisplacement__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int TessellationMultiplier__Offset;
		public FExpressionInput TessellationMultiplier
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+TessellationMultiplier__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int SubsurfaceColor__Offset;
		public FExpressionInput SubsurfaceColor
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+SubsurfaceColor__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int ClearCoat__Offset;
		public FExpressionInput ClearCoat
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+ClearCoat__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int ClearCoatRoughness__Offset;
		public FExpressionInput ClearCoatRoughness
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+ClearCoatRoughness__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int AmbientOcclusion__Offset;
		public FExpressionInput AmbientOcclusion
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+AmbientOcclusion__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Refraction__Offset;
		public FExpressionInput Refraction
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Refraction__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int CustomizedUVs__Offset;
		public FExpressionInput CustomizedUVs
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+CustomizedUVs__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int PixelDepthOffset__Offset;
		public FExpressionInput PixelDepthOffset
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+PixelDepthOffset__Offset, typeof(FExpressionInput));}
			
		}
		
		static UMaterialExpressionMakeMaterialAttributes()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionMakeMaterialAttributes");
			BaseColor__Offset=GetPropertyOffset(NativeClassPtr,"BaseColor");
			Metallic__Offset=GetPropertyOffset(NativeClassPtr,"Metallic");
			Specular__Offset=GetPropertyOffset(NativeClassPtr,"Specular");
			Roughness__Offset=GetPropertyOffset(NativeClassPtr,"Roughness");
			EmissiveColor__Offset=GetPropertyOffset(NativeClassPtr,"EmissiveColor");
			Opacity__Offset=GetPropertyOffset(NativeClassPtr,"Opacity");
			OpacityMask__Offset=GetPropertyOffset(NativeClassPtr,"OpacityMask");
			Normal__Offset=GetPropertyOffset(NativeClassPtr,"Normal");
			WorldPositionOffset__Offset=GetPropertyOffset(NativeClassPtr,"WorldPositionOffset");
			WorldDisplacement__Offset=GetPropertyOffset(NativeClassPtr,"WorldDisplacement");
			TessellationMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"TessellationMultiplier");
			SubsurfaceColor__Offset=GetPropertyOffset(NativeClassPtr,"SubsurfaceColor");
			ClearCoat__Offset=GetPropertyOffset(NativeClassPtr,"ClearCoat");
			ClearCoatRoughness__Offset=GetPropertyOffset(NativeClassPtr,"ClearCoatRoughness");
			AmbientOcclusion__Offset=GetPropertyOffset(NativeClassPtr,"AmbientOcclusion");
			Refraction__Offset=GetPropertyOffset(NativeClassPtr,"Refraction");
			CustomizedUVs__Offset=GetPropertyOffset(NativeClassPtr,"CustomizedUVs");
			PixelDepthOffset__Offset=GetPropertyOffset(NativeClassPtr,"PixelDepthOffset");
			
		}
		
	}
	
}
#endif
#endif
