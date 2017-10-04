using System;
namespace UnrealEngine
{
	public partial class UParticleModuleTrailSource:UParticleModuleTrailBase
	{
		/// <summary>The source method for the trail.</summary>
		public ETrail2SourceMethod SourceMethod;
		
		/// <summary>The name of the source - either the emitter or Actor.</summary>
		public FName SourceName;
		
		/// <summary>The strength of the tangent from the source point for each Trail.</summary>
		public FRawDistributionFloat SourceStrength;
		
		/// <summary>Whether to lock the source to the life of the particle.</summary>
		public bool bLockSourceStength;
		
		/// <summary>
		/// SourceOffsetCount
		/// The number of source offsets that can be expected to be found on the instance.
		/// These must be named
		///         TrailSourceOffset#
		/// </summary>
		public int SourceOffsetCount;
		
		/// <summary>Particle selection method, when using the SourceMethod of Particle.</summary>
		public EParticleSourceSelectionMethod SelectionMethod;
		
		/// <summary>Interhit particle rotation - only valid for SourceMethod of PET2SRCM_Particle.</summary>
		public bool bInheritRotation;
		
		
	}
	
}
