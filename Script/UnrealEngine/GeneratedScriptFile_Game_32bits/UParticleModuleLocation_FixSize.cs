#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleLocation
	{
		static readonly int StartLocation__Offset;
		public FRawDistributionVector StartLocation
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartLocation__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartLocation__Offset, false);}
			
		}
		
		static readonly int DistributeOverNPoints__Offset;
		public float DistributeOverNPoints
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistributeOverNPoints__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistributeOverNPoints__Offset, false);}
			
		}
		
		static readonly int DistributeThreshold__Offset;
		public float DistributeThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistributeThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistributeThreshold__Offset, false);}
			
		}
		
		static UParticleModuleLocation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleLocation");
			StartLocation__Offset=GetPropertyOffset(NativeClassPtr,"StartLocation");
			DistributeOverNPoints__Offset=GetPropertyOffset(NativeClassPtr,"DistributeOverNPoints");
			DistributeThreshold__Offset=GetPropertyOffset(NativeClassPtr,"DistributeThreshold");
			
		}
		
	}
	
}
#endif
#endif
