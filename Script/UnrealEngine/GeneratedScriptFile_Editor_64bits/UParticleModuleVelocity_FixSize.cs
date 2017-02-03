#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleVelocity
	{
		static readonly int StartVelocity__Offset;
		/// <summary>
		/// The velocity to apply to a particle when it is spawned.
		/// Value is retrieved using the EmitterTime of the emitter.
		/// </summary>
		public FRawDistributionVector StartVelocity
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+StartVelocity__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartVelocity__Offset, false);}
			
		}
		
		static readonly int StartVelocityRadial__Offset;
		/// <summary>
		/// The velocity to apply to a particle along its radial direction.
		/// Direction is determined by subtracting the location of the emitter from the particle location at spawn.
		/// Value is retrieved using the EmitterTime of the emitter.
		/// </summary>
		public FRawDistributionFloat StartVelocityRadial
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+StartVelocityRadial__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartVelocityRadial__Offset, false);}
			
		}
		
		static UParticleModuleVelocity()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleVelocity");
			StartVelocity__Offset=GetPropertyOffset(NativeClassPtr,"StartVelocity");
			StartVelocityRadial__Offset=GetPropertyOffset(NativeClassPtr,"StartVelocityRadial");
			
		}
		
	}
	
}
#endif
#endif
