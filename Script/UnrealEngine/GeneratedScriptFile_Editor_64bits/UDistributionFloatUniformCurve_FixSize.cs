#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionFloatUniformCurve
	{
		static readonly int ConstantCurve__Offset;
		/// <summary>Keyframe data for how output constant varies over time.</summary>
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
