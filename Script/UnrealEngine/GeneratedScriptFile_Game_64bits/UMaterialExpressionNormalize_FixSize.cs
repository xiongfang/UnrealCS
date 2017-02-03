#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionNormalize
	{
		static readonly int VectorInput__Offset;
		public FExpressionInput VectorInput
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+VectorInput__Offset, typeof(FExpressionInput));}
			
		}
		
		static UMaterialExpressionNormalize()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionNormalize");
			VectorInput__Offset=GetPropertyOffset(NativeClassPtr,"VectorInput");
			
		}
		
	}
	
}
#endif
#endif
