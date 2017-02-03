#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionVectorConstantCurve
	{
		static readonly int ConstantCurve__Offset;
		/// <summary>Keyframe data for each component (X,Y,Z) over time.</summary>
		public FInterpCurveVector ConstantCurve
		{
			get{ CheckIsValid();return (FInterpCurveVector)Marshal.PtrToStructure(_this.Get()+ConstantCurve__Offset, typeof(FInterpCurveVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstantCurve__Offset, false);}
			
		}
		
		static readonly int bLockAxes__Offset;
		/// <summary>If true, X == Y == Z ie. only one degree of freedom. If false, each axis is picked independently.</summary>
		public bool bLockAxes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockAxes__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int LockedAxes__Offset;
		public EDistributionVectorLockFlags LockedAxes
		{
			get{ CheckIsValid();return (EDistributionVectorLockFlags)Marshal.PtrToStructure(_this.Get()+LockedAxes__Offset, typeof(EDistributionVectorLockFlags));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LockedAxes__Offset, false);}
			
		}
		
		static UDistributionVectorConstantCurve()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DistributionVectorConstantCurve");
			ConstantCurve__Offset=GetPropertyOffset(NativeClassPtr,"ConstantCurve");
			bLockAxes__Offset=GetPropertyOffset(NativeClassPtr,"bLockAxes");
			LockedAxes__Offset=GetPropertyOffset(NativeClassPtr,"LockedAxes");
			
		}
		
	}
	
}
#endif
#endif
