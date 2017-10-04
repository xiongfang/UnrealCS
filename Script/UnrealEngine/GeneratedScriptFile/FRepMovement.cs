using System;
namespace UnrealEngine
{
	/// <summary>
	/// Replicated movement data of our RootComponent.
	/// Struct used for efficient replication as velocity and location are generally replicated together (this saves a repindex)
	/// and velocity.Z is commonly zero (most position replications are for walking pawns).
	/// </summary>
	public partial struct FRepMovement
	{
		public FVector LinearVelocity;
		public FVector AngularVelocity;
		public FVector Location;
		public FRotator Rotation;
		/// <summary>If set, RootComponent should be sleeping.</summary>
		public bool bSimulatedPhysicSleep;
		/// <summary>If set, additional physic data (angular velocity) will be replicated.</summary>
		public bool bRepPhysics;
		
	}
	
}
