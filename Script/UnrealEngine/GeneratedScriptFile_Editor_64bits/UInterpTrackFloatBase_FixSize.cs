#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackFloatBase
	{
		static readonly int FloatTrack__Offset;
		/// <summary>Actually track data containing keyframes of float as it varies over time.</summary>
		public FInterpCurveFloat FloatTrack
		{
			get{ CheckIsValid();return (FInterpCurveFloat)Marshal.PtrToStructure(_this.Get()+FloatTrack__Offset, typeof(FInterpCurveFloat));}
			
		}
		
		static readonly int CurveTension__Offset;
		/// <summary>Tension of curve, used for keypoints using automatic tangents.</summary>
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
