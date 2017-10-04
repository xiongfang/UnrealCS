using System;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationPrimitiveCylinder:UParticleModuleLocationPrimitiveBase
	{
		/// <summary>If true, get the particle velocity form the radial distance inside the primitive.</summary>
		public bool RadialVelocity;
		
		/// <summary>The radius of the cylinder.</summary>
		public FRawDistributionFloat StartRadius;
		
		/// <summary>The height of the cylinder, centered about the location.</summary>
		public FRawDistributionFloat StartHeight;
		
		/// <summary>
		/// Determine particle particle system axis that should represent the height of the cylinder.
		/// Can be one of the following:
		///   PMLPC_HEIGHTAXIS_X - Orient the height along the particle system X-axis.
		///   PMLPC_HEIGHTAXIS_Y - Orient the height along the particle system Y-axis.
		///   PMLPC_HEIGHTAXIS_Z - Orient the height along the particle system Z-axis.
		/// </summary>
		public CylinderHeightAxis HeightAxis;
		
		
	}
	
}
