using System;
namespace UnrealEngine
{
	public partial class APhysicsVolume:AVolume
	{
		/// <summary>Terminal velocity of pawns using CharacterMovement when falling.</summary>
		public float TerminalVelocity;
		
		/// <summary>Determines which PhysicsVolume takes precedence if they overlap (higher number = higher priority).</summary>
		public int Priority;
		
		/// <summary>This property controls the amount of friction applied by the volume as pawns using CharacterMovement move through it. The higher this value, the harder it will feel to move through</summary>
		public float FluidFriction;
		
		/// <summary>True if this volume contains a fluid like water</summary>
		public bool bWaterVolume;
		
		/// <summary>By default, the origin of an AActor must be inside a PhysicsVolume for it to affect the actor. However if this flag is true, the other actor only has to touch the volume to be affected by it.</summary>
		public bool bPhysicsOnContact;
		
		
	}
	
}
