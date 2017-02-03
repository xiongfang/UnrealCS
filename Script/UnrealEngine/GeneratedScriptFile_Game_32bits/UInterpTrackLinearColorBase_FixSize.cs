#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackLinearColorBase
	{
		static readonly int LinearColorTrack__Offset;
		public FInterpCurveLinearColor LinearColorTrack
		{
			get{ CheckIsValid();return (FInterpCurveLinearColor)Marshal.PtrToStructure(_this.Get()+LinearColorTrack__Offset, typeof(FInterpCurveLinearColor));}
			
		}
		
		static readonly int CurveTension__Offset;
		public float CurveTension
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CurveTension__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CurveTension__Offset, false);}
			
		}
		
		static UInterpTrackLinearColorBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackLinearColorBase");
			LinearColorTrack__Offset=GetPropertyOffset(NativeClassPtr,"LinearColorTrack");
			CurveTension__Offset=GetPropertyOffset(NativeClassPtr,"CurveTension");
			
		}
		
	}
	
}
#endif
#endif
