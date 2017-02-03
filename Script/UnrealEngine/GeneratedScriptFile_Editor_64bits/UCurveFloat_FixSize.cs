#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UCurveFloat
	{
		static readonly int FloatCurve__Offset;
		/// <summary>Keyframe data</summary>
		public FRichCurve FloatCurve
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+FloatCurve__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int bIsEventCurve__Offset;
		/// <summary>Flag to represent event curve</summary>
		public bool bIsEventCurve
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsEventCurve__Offset, 1, 0, 1, 255);}
			
		}
		
		static UCurveFloat()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CurveFloat");
			FloatCurve__Offset=GetPropertyOffset(NativeClassPtr,"FloatCurve");
			bIsEventCurve__Offset=GetPropertyOffset(NativeClassPtr,"bIsEventCurve");
			
		}
		
	}
	
}
#endif
#endif
