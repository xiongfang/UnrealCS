#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionFloatConstantCurve
	{
		static readonly int ConstantCurve__Offset;
		/// <summary>Keyframe data for how output constant varies over time.</summary>
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
