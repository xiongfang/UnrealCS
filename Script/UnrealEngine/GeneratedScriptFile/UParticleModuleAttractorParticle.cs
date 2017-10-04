using System;
namespace UnrealEngine
{
	public partial class UParticleModuleAttractorParticle:UParticleModuleAttractorBase
	{
		/// <summary>The source emitter for attractors</summary>
		public FName EmitterName;
		
		/// <summary>
		/// The radial range of the attraction around the source particle.
		/// Particle-life relative.
		/// </summary>
		public FRawDistributionFloat Range;
		
		/// <summary>The strength curve is a function of distance or of time.</summary>
		public bool bStrengthByDistance;
		
		/// <summary>
		/// The strength of the attraction (negative values repel).
		/// Particle-life relative if StrengthByDistance is false.
		/// </summary>
		public FRawDistributionFloat Strength;
		
		/// <summary>If true, the velocity adjustment will be applied to the base velocity.</summary>
		public bool bAffectBaseVelocity;
		
		/// <summary>
		/// The method to use when selecting an attractor target particle from the emitter.
		/// One of the following:
		/// Random          - Randomly select a particle from the source emitter.
		/// Sequential  - Select a particle using a sequential order.
		/// </summary>
		public EAttractorParticleSelectionMethod SelectionMethod;
		
		/// <summary>Whether the particle should grab a new particle if it's source expires.</summary>
		public bool bRenewSource;
		
		/// <summary>Whether the particle should inherit the source veloctiy if it expires.</summary>
		public bool bInheritSourceVel;
		
		public int LastSelIndex;
		
		
	}
	
}
