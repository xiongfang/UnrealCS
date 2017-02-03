#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureSampleParameterSubUV
	{
		static readonly int bBlend__Offset;
		public bool bBlend
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBlend__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBlend__Offset, 1,0,1,1);}
			
		}
		
		static UMaterialExpressionTextureSampleParameterSubUV()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionTextureSampleParameterSubUV");
			bBlend__Offset=GetPropertyOffset(NativeClassPtr,"bBlend");
			
		}
		
	}
	
}
#endif
#endif
