#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionVectorUniformCurve
	{
		static readonly int ConstantCurve__Offset;
		public FInterpCurveTwoVectors ConstantCurve
		{
			get{ CheckIsValid();return (FInterpCurveTwoVectors)Marshal.PtrToStructure(_this.Get()+ConstantCurve__Offset, typeof(FInterpCurveTwoVectors));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ConstantCurve__Offset, false);}
			
		}
		
		static readonly int bLockAxes1__Offset;
		public bool bLockAxes1
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockAxes1__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bLockAxes2__Offset;
		public bool bLockAxes2
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockAxes2__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int LockedAxes__Offset;
		public EDistributionVectorLockFlags LockedAxes
		{
			get{ CheckIsValid();return (EDistributionVectorLockFlags)Marshal.PtrToStructure(_this.Get()+LockedAxes__Offset, typeof(EDistributionVectorLockFlags));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LockedAxes__Offset, false);}
			
		}
		
		static readonly int MirrorFlags__Offset;
		public EDistributionVectorMirrorFlags MirrorFlags
		{
			get{ CheckIsValid();return (EDistributionVectorMirrorFlags)Marshal.PtrToStructure(_this.Get()+MirrorFlags__Offset, typeof(EDistributionVectorMirrorFlags));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MirrorFlags__Offset, false);}
			
		}
		
		static readonly int bUseExtremes__Offset;
		public bool bUseExtremes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseExtremes__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseExtremes__Offset, 1,0,1,1);}
			
		}
		
		static UDistributionVectorUniformCurve()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DistributionVectorUniformCurve");
			ConstantCurve__Offset=GetPropertyOffset(NativeClassPtr,"ConstantCurve");
			bLockAxes1__Offset=GetPropertyOffset(NativeClassPtr,"bLockAxes1");
			bLockAxes2__Offset=GetPropertyOffset(NativeClassPtr,"bLockAxes2");
			LockedAxes__Offset=GetPropertyOffset(NativeClassPtr,"LockedAxes");
			MirrorFlags__Offset=GetPropertyOffset(NativeClassPtr,"MirrorFlags");
			bUseExtremes__Offset=GetPropertyOffset(NativeClassPtr,"bUseExtremes");
			
		}
		
	}
	
}
#endif
#endif
