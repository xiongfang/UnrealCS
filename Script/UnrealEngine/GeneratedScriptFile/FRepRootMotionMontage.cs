using System;
namespace UnrealEngine
{
	/// <summary>Replicated data when playing a root motion montage.</summary>
	public partial struct FRepRootMotionMontage
	{
		/// <summary>Whether this has useful/active data.</summary>
		public bool bIsActive;
		/// <summary>AnimMontage providing Root Motion</summary>
		public UAnimMontage AnimMontage;
		/// <summary>Track position of Montage</summary>
		public float Position;
		/// <summary>Location</summary>
		public FVector_NetQuantize100 Location;
		/// <summary>Rotation</summary>
		public FRotator Rotation;
		/// <summary>Movement Relative to Base</summary>
		public UPrimitiveComponent MovementBase;
		/// <summary>Bone on the MovementBase, if a skeletal mesh.</summary>
		public FName MovementBaseBoneName;
		/// <summary>Additional replicated flag, if MovementBase can't be resolved on the client. So we don't use wrong data.</summary>
		public bool bRelativePosition;
		/// <summary>Whether rotation is relative or absolute.</summary>
		public bool bRelativeRotation;
		/// <summary>State of Root Motion Sources on Authority</summary>
		public FRootMotionSourceGroup AuthoritativeRootMotion;
		/// <summary>Acceleration</summary>
		public FVector_NetQuantize10 Acceleration;
		/// <summary>Velocity</summary>
		public FVector_NetQuantize10 LinearVelocity;
		
	}
	
}
