using System;
namespace UnrealEngine
{
	public partial class UParticleModuleOrbit:UParticleModuleOrbitBase
	{
		/// <summary>
		/// Orbit modules will chain together in the order they appear in the module stack.
		/// The combination of a module with the one prior to it is defined by using one
		/// of the following enumerations:
		///         EOChainMode_Add         Add the values to the previous results
		///         EOChainMode_Scale       Multiply the values by the previous results
		///         EOChainMode_Link        'Break' the chain and apply the values from the previous results
		/// </summary>
		public EOrbitChainMode ChainMode;
		
		/// <summary>The amount to offset the sprite from the particle position.</summary>
		public FRawDistributionVector OffsetAmount;
		
		/// <summary>The options associated with the OffsetAmount look-up.</summary>
		public FOrbitOptions OffsetOptions;
		
		/// <summary>
		/// The amount (in 'turns') to rotate the offset about the particle position.
		///         0.0 = no rotation
		///         0.5     = 180 degree rotation
		///         1.0 = 360 degree rotation
		/// </summary>
		public FRawDistributionVector RotationAmount;
		
		/// <summary>The options associated with the RotationAmount look-up.</summary>
		public FOrbitOptions RotationOptions;
		
		/// <summary>
		/// The rate (in 'turns') at which to rotate the offset about the particle positon.
		///         0.0 = no rotation
		///         0.5     = 180 degree rotation
		///         1.0 = 360 degree rotation
		/// </summary>
		public FRawDistributionVector RotationRateAmount;
		
		/// <summary>The options associated with the RotationRateAmount look-up.</summary>
		public FOrbitOptions RotationRateOptions;
		
		
	}
	
}
