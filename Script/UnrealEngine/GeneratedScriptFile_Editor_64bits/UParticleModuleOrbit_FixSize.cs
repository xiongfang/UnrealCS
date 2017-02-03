#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleOrbit
	{
		static readonly int ChainMode__Offset;
		/// <summary>
		/// Orbit modules will chain together in the order they appear in the module stack.
		/// The combination of a module with the one prior to it is defined by using one
		/// of the following enumerations:
		///         EOChainMode_Add         Add the values to the previous results
		///         EOChainMode_Scale       Multiply the values by the previous results
		///         EOChainMode_Link        'Break' the chain and apply the values from the previous results
		/// </summary>
		public EOrbitChainMode ChainMode
		{
			get{ CheckIsValid();return (EOrbitChainMode)Marshal.PtrToStructure(_this.Get()+ChainMode__Offset, typeof(EOrbitChainMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ChainMode__Offset, false);}
			
		}
		
		static readonly int OffsetAmount__Offset;
		/// <summary>The amount to offset the sprite from the particle position.</summary>
		public FRawDistributionVector OffsetAmount
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+OffsetAmount__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OffsetAmount__Offset, false);}
			
		}
		
		static readonly int OffsetOptions__Offset;
		/// <summary>The options associated with the OffsetAmount look-up.</summary>
		public FOrbitOptions OffsetOptions
		{
			get{ CheckIsValid();return (FOrbitOptions)Marshal.PtrToStructure(_this.Get()+OffsetOptions__Offset, typeof(FOrbitOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OffsetOptions__Offset, false);}
			
		}
		
		static readonly int RotationAmount__Offset;
		/// <summary>
		/// The amount (in 'turns') to rotate the offset about the particle position.
		///         0.0 = no rotation
		///         0.5     = 180 degree rotation
		///         1.0 = 360 degree rotation
		/// </summary>
		public FRawDistributionVector RotationAmount
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+RotationAmount__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationAmount__Offset, false);}
			
		}
		
		static readonly int RotationOptions__Offset;
		/// <summary>The options associated with the RotationAmount look-up.</summary>
		public FOrbitOptions RotationOptions
		{
			get{ CheckIsValid();return (FOrbitOptions)Marshal.PtrToStructure(_this.Get()+RotationOptions__Offset, typeof(FOrbitOptions));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationOptions__Offset, false);}
			
		}
		
		static readonly int RotationRateAmount__Offset;
		/// <summary>
		/// The rate (in 'turns') at which to rotate the offset about the particle positon.
		///         0.0 = no rotation
		///         0.5     = 180 degree rotation
		///         1.0 = 360 degree rotation
		/// </summary>
		public FRawDistributionVector RotationRateAmount
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+RotationRateAmount__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RotationRateAmount__Offset, false);}
			
		}
		
		static readonly int RotationRateOptions__Offset;
		/// <summary>The options associated with the RotationRateAmount look-up.</summary>
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
