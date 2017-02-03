#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackFloatBase
	{
		static readonly int FloatTrack__Offset;
		public FInterpCurveFloat FloatTrack
		{
			get{ CheckIsValid();return (FInterpCurveFloat)Marshal.PtrToStructure(_this.Get()+FloatTrack__Offset, typeof(FInterpCurveFloat));}
			
		}
		
		static readonly int CurveTension__Offset;
		public float CurveTension
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CurveTension__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CurveTension__Offset, false);}
			
		}
		
		static UInterpTrackFloatBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackFloatBase");
			FloatTrack__Offset=GetPropertyOffset(NativeClassPtr,"FloatTrack");
			CurveTension__Offset=GetPropertyOffset(NativeClassPtr,"CurveTension");
			
		}
		
	}
	
}
#endif
#endif
