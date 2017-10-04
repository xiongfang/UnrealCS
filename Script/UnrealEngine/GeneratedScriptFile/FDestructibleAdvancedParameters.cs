using System;
namespace UnrealEngine
{
	/// <summary>Parameters that are less-often used.</summary>
	public partial struct FDestructibleAdvancedParameters
	{
		/// <summary>
		/// Limits the amount of damage applied to a chunk.  This is useful for preventing the entire destructible
		/// from getting pulverized by a very large application of damage.  This can easily happen when impact damage is
		/// used, and the damage amount is proportional to the impact force (see forceToDamage).
		/// </summary>
		public float DamageCap;
		/// <summary>
		/// Large impact force may be reported if rigid bodies are spawned inside one another.  In this case the realative velocity of the two
		/// objects will be low.  This variable allows the user to set a minimum velocity threshold for impacts to ensure that the objects are
		/// moving at a min velocity in order for the impact force to be considered.
		/// </summary>
		public float ImpactVelocityThreshold;
		/// <summary>
		/// If greater than 0, the chunks' speeds will not be allowed to exceed this value.  Use 0
		/// to disable this feature (this is the default).
		/// </summary>
		public float MaxChunkSpeed;
		/// <summary>
		/// Scale factor used to apply an impulse force along the normal of chunk when fractured.  This is used
		/// in order to "push" the pieces out as they fracture.
		/// </summary>
		public float FractureImpulseScale;
		
	}
	
}
