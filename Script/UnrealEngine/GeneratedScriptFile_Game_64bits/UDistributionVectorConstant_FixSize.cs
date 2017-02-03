#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDistributionVectorConstant
	{
		static readonly int Constant__Offset;
		public FVector Constant
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+Constant__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Constant__Offset, false);}
			
		}
		
		static readonly int bLockAxes__Offset;
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
		
		static UDistributionVectorConstant()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DistributionVectorConstant");
			Constant__Offset=GetPropertyOffset(NativeClassPtr,"Constant");
			bLockAxes__Offset=GetPropertyOffset(NativeClassPtr,"bLockAxes");
			LockedAxes__Offset=GetPropertyOffset(NativeClassPtr,"LockedAxes");
			
		}
		
	}
	
}
#endif
#endif
