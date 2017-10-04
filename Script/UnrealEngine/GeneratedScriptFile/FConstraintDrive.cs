using System;
namespace UnrealEngine
{
	public partial struct FConstraintDrive
	{
		/// <summary>The spring strength of the drive. Force proportional to the position error.</summary>
		public float Stiffness;
		/// <summary>The damping strength of the drive. Force proportional to the velocity error.</summary>
		public float Damping;
		/// <summary>The force limit of the drive.</summary>
		public float MaxForce;
		/// <summary>Enables/Disables position drive (orientation if using angular drive)</summary>
		public bool bEnablePositionDrive;
		/// <summary>Enables/Disables velocity drive (angular velocity if using angular drive)</summary>
		public bool bEnableVelocityDrive;
		
	}
	
}
