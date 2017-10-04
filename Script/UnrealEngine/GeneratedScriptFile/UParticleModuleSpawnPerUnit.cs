using System;
namespace UnrealEngine
{
	public partial class UParticleModuleSpawnPerUnit:UParticleModuleSpawnBase
	{
		/// <summary>
		/// The scalar to apply to the distance traveled.
		/// The value from SpawnPerUnit is divided by this value to give the actual
		/// number of particles per unit.
		/// </summary>
		public float UnitScalar;
		
		/// <summary>
		/// The amount to spawn per meter distribution.
		/// The value is retrieved using the EmitterTime.
		/// </summary>
		public FRawDistributionFloat SpawnPerUnit;
		
		/// <summary>
		/// If true, process the default spawn rate when not moving...
		/// When not moving, skip the default spawn rate.
		/// If false, return the bProcessSpawnRate setting.
		/// </summary>
		public bool bIgnoreSpawnRateWhenMoving;
		
		/// <summary>
		/// The tolerance for moving vs. not moving w.r.t. the bIgnoreSpawnRateWhenMoving flag.
		/// Ie, if (DistanceMoved < (UnitScalar x MovementTolerance)) then consider it not moving.
		/// </summary>
		public float MovementTolerance;
		
		/// <summary>
		/// The maximum valid movement for a single frame.
		/// If 0.0, then the check is not performed.
		/// Currently, if the distance moved between frames is greater than this
		/// then NO particles will be spawned.
		/// This is primiarily intended to cover cases where the PSystem is
		/// attached to teleporting objects.
		/// </summary>
		public float MaxFrameDistance;
		
		/// <summary>If true, ignore the X-component of the movement</summary>
		public bool bIgnoreMovementAlongX;
		
		/// <summary>If true, ignore the Y-component of the movement</summary>
		public bool bIgnoreMovementAlongY;
		
		/// <summary>If true, ignore the Z-component of the movement</summary>
		public bool bIgnoreMovementAlongZ;
		
		
	}
	
}
