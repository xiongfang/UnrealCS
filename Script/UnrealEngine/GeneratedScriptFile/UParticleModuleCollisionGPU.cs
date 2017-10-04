using System;
namespace UnrealEngine
{
	public partial class UParticleModuleCollisionGPU:UParticleModuleCollisionBase
	{
		/// <summary>The bounciness of the particle.</summary>
		public FRawDistributionFloat Resilience;
		
		/// <summary>Scales the bounciness of the particle over its life.</summary>
		public FRawDistributionFloat ResilienceScaleOverLife;
		
		/// <summary>
		/// Friction applied to all particles during a collision or while moving
		/// along a surface.
		/// </summary>
		public float Friction;
		
		/// <summary>Controls how wide the bouncing particles are distributed (0 = disabled).</summary>
		public float RandomSpread;
		
		/// <summary>Controls bouncing particles distribution (1 = uniform distribution; 2 = squared distribution).</summary>
		public float RandomDistribution;
		
		/// <summary>Scale applied to the size of the particle to obtain the collision radius.</summary>
		public float RadiusScale;
		
		/// <summary>Bias applied to the collision radius.</summary>
		public float RadiusBias;
		
		/// <summary>How particles respond to a collision event.</summary>
		public EParticleCollisionResponse Response;
		
		public EParticleCollisionMode CollisionMode;
		
		
	}
	
}
