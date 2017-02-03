#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleOrbit
	{
		static readonly int ChainMode__Offset;
		public EOrbitChainMode ChainMode
		{
			get{ CheckIsValid();return (EOrbitChainMode)Marshal.PtrToStructure(_this.Get()+ChainMode__Offset, typeof(EOrbitChainMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ChainMode__Offset, false);}
			
		}
		
		static readonly int OffsetAmount__Offset;
		public FRawDistributionVector OffsetAmount
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+OffsetAmount__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OffsetAmount__Offset, false);}
			
		}
		
		static readonly int OffsetOptions__Offset;
		public FOrbitOptions OffsetOptions
		{
			get{ CheckIsValid();return (FOrbitOptions)Marshal.PtrToStructure(_this.Get()+OffsetOptions__Offset, typeof(FOrbitOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OffsetOptions__Offset, false);}
			
		}
		
		static readonly int RotationAmount__Offset;
		public FRawDistributionVector RotationAmount
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+RotationAmount__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationAmount__Offset, false);}
			
		}
		
		static readonly int RotationOptions__Offset;
		public FOrbitOptions RotationOptions
		{
			get{ CheckIsValid();return (FOrbitOptions)Marshal.PtrToStructure(_this.Get()+RotationOptions__Offset, typeof(FOrbitOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationOptions__Offset, false);}
			
		}
		
		static readonly int RotationRateAmount__Offset;
		public FRawDistributionVector RotationRateAmount
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+RotationRateAmount__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationRateAmount__Offset, false);}
			
		}
		
		static readonly int RotationRateOptions__Offset;
		public FOrbitOptions RotationRateOptions
		{
			get{ CheckIsValid();return (FOrbitOptions)Marshal.PtrToStructure(_this.Get()+RotationRateOptions__Offset, typeof(FOrbitOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationRateOptions__Offset, false);}
			
		}
		
		static UParticleModuleOrbit()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleOrbit");
			ChainMode__Offset=GetPropertyOffset(NativeClassPtr,"ChainMode");
			OffsetAmount__Offset=GetPropertyOffset(NativeClassPtr,"OffsetAmount");
			OffsetOptions__Offset=GetPropertyOffset(NativeClassPtr,"OffsetOptions");
			RotationAmount__Offset=GetPropertyOffset(NativeClassPtr,"RotationAmount");
			RotationOptions__Offset=GetPropertyOffset(NativeClassPtr,"RotationOptions");
			RotationRateAmount__Offset=GetPropertyOffset(NativeClassPtr,"RotationRateAmount");
			RotationRateOptions__Offset=GetPropertyOffset(NativeClassPtr,"RotationRateOptions");
			
		}
		
	}
	
}
#endif
#endif
