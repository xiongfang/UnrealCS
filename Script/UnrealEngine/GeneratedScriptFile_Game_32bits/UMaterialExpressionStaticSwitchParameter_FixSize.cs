#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionStaticSwitchParameter
	{
		static readonly int A__Offset;
		public FExpressionInput A
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+A__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int B__Offset;
		public FExpressionInput B
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+B__Offset, typeof(FExpressionInput));}
			
		}
		
		static UMaterialExpressionStaticSwitchParameter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionStaticSwitchParameter");
			A__Offset=GetPropertyOffset(NativeClassPtr,"A");
			B__Offset=GetPropertyOffset(NativeClassPtr,"B");
			
		}
		
	}
	
}
#endif
#endif
