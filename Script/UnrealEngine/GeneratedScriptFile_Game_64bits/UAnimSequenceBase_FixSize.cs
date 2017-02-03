#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimSequenceBase
	{
		static readonly int Notifies__Offset;
		public TStructArray<FAnimNotifyEvent> Notifies
		{
			get{ CheckIsValid();return new TStructArray<FAnimNotifyEvent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Notifies__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Notifies__Offset, false);}
			
		}
		
		static readonly int SequenceLength__Offset;
		public float SequenceLength
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SequenceLength__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SequenceLength__Offset, false);}
			
		}
		
		static readonly int RateScale__Offset;
		public float RateScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RateScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RateScale__Offset, false);}
			
		}
		
		static readonly int RawCurveData__Offset;
		public FRawCurveTracks RawCurveData
		{
			get{ CheckIsValid();return (FRawCurveTracks)Marshal.PtrToStructure(_this.Get()+RawCurveData__Offset, typeof(FRawCurveTracks));}
			
		}
		
		static UAnimSequenceBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimSequenceBase");
			Notifies__Offset=GetPropertyOffset(NativeClassPtr,"Notifies");
			SequenceLength__Offset=GetPropertyOffset(NativeClassPtr,"SequenceLength");
			RateScale__Offset=GetPropertyOffset(NativeClassPtr,"RateScale");
			RawCurveData__Offset=GetPropertyOffset(NativeClassPtr,"RawCurveData");
			
		}
		
	}
	
}
#endif
#endif
