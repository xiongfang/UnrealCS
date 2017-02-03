#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTangentOutput
	{
		static readonly int Input__Offset;
		public FExpressionInput Input
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Input__Offset, typeof(FExpressionInput));}
			
		}
		
		static UMaterialExpressionTangentOutput()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionTangentOutput");
			Input__Offset=GetPropertyOffset(NativeClassPtr,"Input");
			
		}
		
	}
	
}
#endif
#endif
