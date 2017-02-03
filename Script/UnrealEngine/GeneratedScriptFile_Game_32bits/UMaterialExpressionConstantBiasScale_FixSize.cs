#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMaterialExpressionConstantBiasScale
	{
		static readonly int Input__Offset;
		public FExpressionInput Input
		{
			get{ CheckIsValid();return (FExpressionInput)Marshal.PtrToStructure(_this.Get()+Input__Offset, typeof(FExpressionInput));}
			
		}
		
		static readonly int Bias__Offset;
		public float Bias
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Bias__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Bias__Offset, false);}
			
		}
		
		static readonly int Scale__Offset;
		public float Scale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Scale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Scale__Offset, false);}
			
		}
		
		static UMaterialExpressionConstantBiasScale()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MaterialExpressionConstantBiasScale");
			Input__Offset=GetPropertyOffset(NativeClassPtr,"Input");
			Bias__Offset=GetPropertyOffset(NativeClassPtr,"Bias");
			Scale__Offset=GetPropertyOffset(NativeClassPtr,"Scale");
			
		}
		
	}
	
}
#endif
#endif
