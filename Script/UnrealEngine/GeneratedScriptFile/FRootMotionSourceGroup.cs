using System;
namespace UnrealEngine
{
	/// <summary>Group of Root Motion Sources that are applied</summary>
	public partial struct FRootMotionSourceGroup
	{
		/// <summary>Whether this group has additive root motion sources</summary>
		public bool bHasAdditiveSources;
		/// <summary>Whether this group has override root motion sources</summary>
		public bool bHasOverrideSources;
		/// <summary>
		/// Saved off pre-additive-applied Velocity, used for being able to reliably add/remove additive
		/// velocity from currently computed Velocity (otherwise we would be removing additive velocity
		/// that no longer exists, like if you run into a wall and your Velocity becomes 0 - subtracting
		/// the velocity that we added heading into the wall last tick would make you go backwards. With
		/// this method we override that resulting Velocity due to obstructions
		/// </summary>
		public FVector_NetQuantize10 LastPreAdditiveVelocity;
		/// <summary>
		/// True when we had additive velocity applied last tick, checked to know if we should restore
		/// LastPreAdditiveVelocity before a Velocity computation
		/// </summary>
		public bool bIsAdditiveVelocityApplied;
		/// <summary>Aggregate Settings of the last group of accumulated sources</summary>
		public FRootMotionSourceSettings LastAccumulatedSettings;
		
	}
	
}
