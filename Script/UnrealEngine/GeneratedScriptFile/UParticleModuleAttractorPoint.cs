using System;
namespace UnrealEngine
{
	public partial class UParticleModuleAttractorPoint:UParticleModuleAttractorBase
	{
		/// <summary>The position of the point attractor from the source of the emitter.</summary>
		public FRawDistributionVector Position;
		
		/// <summary>The radial range of the attractor.</summary>
		public FRawDistributionFloat Range;
		
		/// <summary>The strength of the point attractor.</summary>
		public FRawDistributionFloat Strength;
		
		/// <summary>The strength curve is a function of distance or of time.</summary>
		public bool StrengthByDistance;
		
		/// <summary>If true, the velocity adjustment will be applied to the base velocity.</summary>
		public bool bAffectBaseVelocity;
		
		/// <summary>If true, set the velocity.</summary>
		public bool bOverrideVelocity;
		
		/// <summary>If true, treat the position as world space.  So don't transform the the point to localspace.</summary>
		public bool bUseWorldSpacePosition;
		
		/// <summary>Whether particles can move along the positive X axis.</summary>
		public bool Positive_X;
		
		/// <summary>Whether particles can move along the positive Y axis.</summary>
		public bool Positive_Y;
		
		/// <summary>Whether particles can move along the positive Z axis.</summary>
		public bool Positive_Z;
		
		/// <summary>Whether particles can move along the negative X axis.</summary>
		public bool Negative_X;
		
		/// <summary>Whether particles can move along the negative Y axis.</summary>
		public bool Negative_Y;
		
		/// <summary>Whether particles can move along the negative Z axis.</summary>
		public bool Negative_Z;
		
		
	}
	
}
