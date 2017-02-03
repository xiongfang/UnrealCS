#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionConstant4Vector
	{
		static readonly int Constant__Offset;
		public FLinearColor Constant
		{
			get{ CheckIsValid();return (FLinearColor)Marshal.PtrToStructure(_this.Get()+Constant__Offset, typeof(FLinearColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Constant__Offset, false);}
			
		}
		
		static UMaterialExpressionConstant4Vector()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionConstant4Vector");
			Constant__Offset=GetPropertyOffset(NativeClassPtr,"Constant");
			
		}
		
	}
	
}
#endif
#endif
