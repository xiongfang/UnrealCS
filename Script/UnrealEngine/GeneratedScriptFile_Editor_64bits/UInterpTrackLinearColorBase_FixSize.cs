#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackLinearColorBase
	{
		static readonly int LinearColorTrack__Offset;
		/// <summary>Actually track data containing keyframes of a FVector as it varies over time.</summary>
		public FInterpCurveLinearColor LinearColorTrack
		{
			get{ CheckIsValid();return (FInterpCurveLinearColor)Marshal.PtrToStructure(_this.Get()+LinearColorTrack__Offset, typeof(FInterpCurveLinearColor));}
			
		}
		
		static readonly int CurveTension__Offset;
		/// <summary>Tension of curve, used for keypoints using automatic tangents.</summary>
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
