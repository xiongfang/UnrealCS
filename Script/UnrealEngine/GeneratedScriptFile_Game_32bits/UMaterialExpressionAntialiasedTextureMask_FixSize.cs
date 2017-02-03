#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionAntialiasedTextureMask
	{
		static readonly int Threshold__Offset;
		public float Threshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Threshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Threshold__Offset, false);}
			
		}
		
		static readonly int Channel__Offset;
		public ETextureColorChannel Channel
		{
			get{ CheckIsValid();return (ETextureColorChannel)Marshal.PtrToStructure(_this.Get()+Channel__Offset, typeof(ETextureColorChannel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Channel__Offset, false);}
			
		}
		
		static UMaterialExpressionAntialiasedTextureMask()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionAntialiasedTextureMask");
			Threshold__Offset=GetPropertyOffset(NativeClassPtr,"Threshold");
			Channel__Offset=GetPropertyOffset(NativeClassPtr,"Channel");
			
		}
		
	}
	
}
#endif
#endif
