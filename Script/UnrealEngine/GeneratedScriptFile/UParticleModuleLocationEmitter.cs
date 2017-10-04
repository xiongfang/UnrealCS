using System;
namespace UnrealEngine
{
	public partial class UParticleModuleLocationEmitter:UParticleModuleLocationBase
	{
		/// <summary>The name of the emitter to use that the source location for particle.</summary>
		public FName EmitterName;
		
		/// <summary>
		/// The method to use when selecting a spawn target particle from the emitter.
		/// Can be one of the following:
		///         ELESM_Random            Randomly select a particle from the source emitter.
		///         ELESM_Sequential        Step through each particle from the source emitter in order.
		/// </summary>
		public ELocationEmitterSelectionMethod SelectionMethod;
		
		/// <summary>If true, the spawned particle should inherit the velocity of the source particle.</summary>
		public bool InheritSourceVelocity;
		
		/// <summary>Amount to scale the source velocity by when inheriting it.</summary>
		public float InheritSourceVelocityScale;
		
		/// <summary>If true, the spawned particle should inherit the rotation of the source particle.</summary>
		public bool bInheritSourceRotation;
		
		/// <summary>Amount to scale the source rotation by when inheriting it.</summary>
		public float InheritSourceRotationScale;
		
		
	}
	
}
