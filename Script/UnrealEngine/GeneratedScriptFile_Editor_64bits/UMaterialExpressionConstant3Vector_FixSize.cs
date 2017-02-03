#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionConstant3Vector
	{
		static readonly int Constant__Offset;
		public FLinearColor Constant
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+Constant__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Constant__Offset, false);}
			
		}
		
		static UMaterialExpressionConstant3Vector()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionConstant3Vector");
			Constant__Offset=GetPropertyOffset(NativeClassPtr,"Constant");
			
		}
		
	}
	
}
#endif
#endif
