#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionFloatConstantCurve
	{
		static readonly int ConstantCurve__Offset;
		public FInterpCurveFloat ConstantCurve
		{
			get{ CheckIsValid();return (FInterpCurveFloat)Marshal.PtrToStructure(_this.Get()+ConstantCurve__Offset, typeof(FInterpCurveFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstantCurve__Offset, false);}
			
		}
		
		static UDistributionFloatConstantCurve()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DistributionFloatConstantCurve");
			ConstantCurve__Offset=GetPropertyOffset(NativeClassPtr,"ConstantCurve");
			
		}
		
	}
	
}
#endif
#endif
