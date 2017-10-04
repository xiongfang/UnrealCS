using System;
namespace UnrealEngine
{
	/// <summary>Linear Drive</summary>
	public partial struct FLinearDriveConstraint
	{
		/// <summary>Target position the linear drive.</summary>
		public FVector PositionTarget;
		/// <summary>Target velocity the linear drive.</summary>
		public FVector VelocityTarget;
		public FConstraintDrive XDrive;
		public FConstraintDrive YDrive;
		public FConstraintDrive ZDrive;
		public bool bEnablePositionDrive;
		
	}
	
}
