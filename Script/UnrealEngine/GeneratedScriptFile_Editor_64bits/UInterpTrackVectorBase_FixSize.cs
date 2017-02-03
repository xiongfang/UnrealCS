#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackVectorBase
	{
		static readonly int VectorTrack__Offset;
		/// <summary>Actually track data containing keyframes of a FVector as it varies over time.</summary>
		public FInterpCurveVector VectorTrack
		{
			get{ CheckIsValid();return (FInterpCurveVector)Marshal.PtrToStructure(_this.Get()+VectorTrack__Offset, typeof(FInterpCurveVector));}
			
		}
		
		static readonly int CurveTension__Offset;
		/// <summary>Tension of curve, used for keypoints using automatic tangents.</summary>
		public float CurveTension
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CurveTension__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CurveTension__Offset, false);}
			
		}
		
		static UInterpTrackVectorBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackVectorBase");
			VectorTrack__Offset=GetPropertyOffset(NativeClassPtr,"VectorTrack");
			CurveTension__Offset=GetPropertyOffset(NativeClassPtr,"CurveTension");
			
		}
		
	}
	
}
#endif
#endif
