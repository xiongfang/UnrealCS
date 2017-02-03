#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UHapticFeedbackEffect_Curve
	{
		static readonly int HapticDetails__Offset;
		public FHapticFeedbackDetails_Curve HapticDetails
		{
			get{ CheckIsValid();return (FHapticFeedbackDetails_Curve)Marshal.PtrToStructure(_this.Get()+HapticDetails__Offset, typeof(FHapticFeedbackDetails_Curve));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HapticDetails__Offset, false);}
			
		}
		
		static UHapticFeedbackEffect_Curve()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("HapticFeedbackEffect_Curve");
			HapticDetails__Offset=GetPropertyOffset(NativeClassPtr,"HapticDetails");
			
		}
		
	}
	
}
#endif
#endif
