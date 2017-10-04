using System;
namespace UnrealEngine
{
	public partial class UDestructibleComponent:USkinnedMeshComponent
	{
		public extern UDestructibleMesh GetDestructibleMesh();
		public extern void SetDestructibleMesh(UDestructibleMesh NewMesh);
		/// <summary>Take radius damage</summary>
		public extern void ApplyRadiusDamage(float BaseDamage,FVector HurtOrigin,float DamageRadius,float ImpulseStrength,bool bFullDamage);
		/// <summary>Take damage</summary>
		public extern void ApplyDamage(float DamageAmount,FVector HitLocation,FVector ImpulseDir,float ImpulseStrength);
		/// <summary>If set, use this actor's fracture effects instead of the asset's fracture effects.</summary>
		public bool bFractureEffectOverride;
		
		/// <summary>
		/// Enable "hard sleeping" for destruction-generated PxActors.  This means that they turn kinematic
		/// when they sleep, but can be made dynamic again by application of enough damage.
		/// </summary>
		public bool bEnableHardSleeping;
		
		/// <summary>The minimum size required to treat chunks as Large.</summary>
		public float LargeChunkThreshold;
		
		/// <summary>Provide a blueprint interface for setting the destructible mesh</summary>
		public UDestructibleMesh DestructibleMesh;
		
		
	}
	
}
