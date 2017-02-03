#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionParticleSubUV
	{
		static readonly int bBlend__Offset;
		public bool bBlend
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBlend__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBlend__Offset, 1,0,1,1);}
			
		}
		
		static UMaterialExpressionParticleSubUV()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionParticleSubUV");
			bBlend__Offset=GetPropertyOffset(NativeClassPtr,"bBlend");
			
		}
		
	}
	
}
#endif
#endif
