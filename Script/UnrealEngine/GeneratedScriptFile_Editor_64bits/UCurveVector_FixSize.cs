#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCurveVector
	{
		static readonly int FloatCurves__Offset;
		/// <summary>Keyframe data, one curve for X, Y and Z</summary>
		public FRichCurve FloatCurves
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+FloatCurves__Offset, typeof(FRichCurve));}
			
		}
		
		static UCurveVector()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CurveVector");
			FloatCurves__Offset=GetPropertyOffset(NativeClassPtr,"FloatCurves");
			
		}
		
	}
	
}
#endif
#endif
