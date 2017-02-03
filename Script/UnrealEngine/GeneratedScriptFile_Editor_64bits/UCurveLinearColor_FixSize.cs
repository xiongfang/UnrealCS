#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCurveLinearColor
	{
		static readonly int FloatCurves__Offset;
		/// <summary>Keyframe data, one curve for red, green, blue, and alpha</summary>
		public FRichCurve FloatCurves
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+FloatCurves__Offset, typeof(FRichCurve));}
			
		}
		
		static UCurveLinearColor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CurveLinearColor");
			FloatCurves__Offset=GetPropertyOffset(NativeClassPtr,"FloatCurves");
			
		}
		
	}
	
}
#endif
#endif
