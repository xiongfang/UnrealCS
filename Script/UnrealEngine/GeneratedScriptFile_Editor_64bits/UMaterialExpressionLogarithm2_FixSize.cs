#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionLogarithm2
	{
		static readonly int X__Offset;
		public FExpressionInput X
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+X__Offset, typeof(FExpressionInput));}
			
		}
		
		static UMaterialExpressionLogarithm2()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionLogarithm2");
			X__Offset=GetPropertyOffset(NativeClassPtr,"X");
			
		}
		
	}
	
}
#endif
#endif
