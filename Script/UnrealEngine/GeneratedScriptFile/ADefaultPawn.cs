using System;
namespace UnrealEngine
{
	public partial class ADefaultPawn:APawn
	{
		/// <summary>
		/// Called via input to look up at a given rate (or down if Rate is negative).
		/// @param Rate   This is a normalized rate, i.e. 1.0 means 100% of desired turn rate
		/// </summary>
		public extern void LookUpAtRate(float Rate);
		/// <summary>
		/// Called via input to turn at a given rate.
		/// @param Rate  This is a normalized rate, i.e. 1.0 means 100% of desired turn rate
		/// </summary>
		public extern void TurnAtRate(float Rate);
		/// <summary>
		/// Input callback to move up in world space (or down if Val is negative).
		/// @param Val Amount of movement in the world up direction (or down if negative).
		/// @see APawn::AddMovementInput()
		/// </summary>
		public extern virtual void MoveUp_World(float Val);
		/// <summary>
		/// Input callback to strafe right in local space (or left if Val is negative).
		/// @param Val Amount of movement in the right direction (or left if negative).
		/// @see APawn::AddMovementInput()
		/// </summary>
		public extern virtual void MoveRight(float Val);
		/// <summary>
		/// Input callback to move forward in local space (or backward if Val is negative).
		/// @param Val Amount of movement in the forward direction (or backward if negative).
		/// @see APawn::AddMovementInput()
		/// </summary>
		public extern virtual void MoveForward(float Val);
		/// <summary>Base turn rate, in deg/sec. Other scaling may affect final turn rate.</summary>
		public float BaseTurnRate;
		
		/// <summary>Base lookup rate, in deg/sec. Other scaling may affect final lookup rate.</summary>
		public float BaseLookUpRate;
		
		/// <summary>DefaultPawn movement component</summary>
		public UPawnMovementComponent MovementComponent;
		
		public USphereComponent CollisionComponent;
		
		public UStaticMeshComponent MeshComponent;
		
		/// <summary>If true, adds default input bindings for movement and camera look.</summary>
		public bool bAddDefaultMovementBindings;
		
		
	}
	
}
