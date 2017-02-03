#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleAccelerationOverLifetime
	{
		static readonly int AccelOverLife__Offset;
		/// <summary>
		/// The acceleration of the particle over its lifetime.
		/// Value is obtained using the RelativeTime of the partice.
		/// The current and base velocity values of the particle
		/// are then updated using the formula
		///         velocity += acceleration* DeltaTime
		/// where DeltaTime is the time passed since the last frame.
		/// </summary>
		public FRawDistributionVector AccelOverLife
		{
			get{ CheckIsValid();return (FRawDistributionVector)Marshal.PtrToStructure(_this.Get()+AccelOverLife__Offset, typeof(FRawDistributionVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AccelOverLife__Offset, false);}
			
		}
		
		static UParticleModuleAccelerationOverLifetime()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleAccelerationOverLifetime");
			AccelOverLife__Offset=GetPropertyOffset(NativeClassPtr,"AccelOverLife");
			
		}
		
	}
	
}
#endif
#endif
