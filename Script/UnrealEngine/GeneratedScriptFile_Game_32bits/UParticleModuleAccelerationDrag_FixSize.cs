#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAccelerationDrag
	{
		static readonly int DragCoefficient__Offset;
		public UDistributionFloat DragCoefficient
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DragCoefficient__Offset); if (v == IntPtr.Zero)return null; UDistributionFloat retValue = new UDistributionFloat(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DragCoefficientRaw__Offset;
		public FRawDistributionFloat DragCoefficientRaw
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+DragCoefficientRaw__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DragCoefficientRaw__Offset, false);}
			
		}
		
		static UParticleModuleAccelerationDrag()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleAccelerationDrag");
			DragCoefficient__Offset=GetPropertyOffset(NativeClassPtr,"DragCoefficient");
			DragCoefficientRaw__Offset=GetPropertyOffset(NativeClassPtr,"DragCoefficientRaw");
			
		}
		
	}
	
}
#endif
#endif
