using System;
namespace UnrealEngine
{
	/// <summary>Parameters that pertain to chunk damage.</summary>
	public partial struct FDestructibleDamageParameters
	{
		/// <summary>The damage amount which will cause a chunk to fracture (break free).</summary>
		public float DamageThreshold;
		/// <summary>Controls how easily damage spreads. DamageRadius = Damage*DamageSpread. All chunks within DamageRadius will take damage. Full damage is taken at zero distance, and zero damage at the DamageRadius.</summary>
		public float DamageSpread;
		/// <summary>
		/// Whether to apply damage to destructible when colliding with an object.
		/// @see ImpactDamage
		/// </summary>
		public bool bEnableImpactDamage;
		/// <summary>
		/// Controls how much damage is applied upon collision. Damage = ImpactDamage * ImpactForce.
		/// @see DepthParameters for per level control of ImpactDamage
		/// </summary>
		public float ImpactDamage;
		/// <summary>
		/// Max depth level where impact damage is enabled. @see DepthParameters for per level control of ImpactDamage
		/// If negative, impact damage is disabled
		/// </summary>
		public int DefaultImpactDamageDepth;
		/// <summary>
		/// By default, objects that collide with destructibles will bounce back. Custom resistance allows for finer control of how much a destructible "pushes back" against a colliding object.
		/// @see ImpactResistance
		/// </summary>
		public bool bCustomImpactResistance;
		/// <summary>
		/// Controls how much resistance is applied to colliding objects. Weak materials like glass should set this to a low value so that objects will pass right through them during fracture.
		/// @see DepthParameters for per level control of ImpactResistance
		/// </summary>
		public float ImpactResistance;
		
	}
	
}
