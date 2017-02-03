#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackVectorBase
	{
		static readonly int VectorTrack__Offset;
		public FInterpCurveVector VectorTrack
		{
			get{ CheckIsValid();return (FInterpCurveVector)Marshal.PtrToStructure(_this.Get()+VectorTrack__Offset, typeof(FInterpCurveVector));}
			
		}
		
		static readonly int CurveTension__Offset;
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
