#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionFloatUniformCurve
	{
		static readonly int ConstantCurve__Offset;
		public FInterpCurveVector2D ConstantCurve
		{
			get{ CheckIsValid();return (FInterpCurveVector2D)Marshal.PtrToStructure(_this.Get()+ConstantCurve__Offset, typeof(FInterpCurveVector2D));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstantCurve__Offset, false);}
			
		}
		
		static UDistributionFloatUniformCurve()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DistributionFloatUniformCurve");
			ConstantCurve__Offset=GetPropertyOffset(NativeClassPtr,"ConstantCurve");
			
		}
		
	}
	
}
#endif
#endif
