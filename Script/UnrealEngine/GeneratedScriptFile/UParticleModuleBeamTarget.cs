using System;
namespace UnrealEngine
{
	public partial class UParticleModuleBeamTarget:UParticleModuleBeamBase
	{
		/// <summary>The method flag.</summary>
		public Beam2SourceTargetMethod TargetMethod;
		
		/// <summary>The target point sources of each beam, when using the end point method.</summary>
		public FName TargetName;
		
		/// <summary>Default target-point information to use if the beam method is endpoint.</summary>
		public FRawDistributionVector Target;
		
		/// <summary>Whether to treat the as an absolute position in world space.</summary>
		public bool bTargetAbsolute;
		
		/// <summary>Whether to lock the Target to the life of the particle.</summary>
		public bool bLockTarget;
		
		/// <summary>The method to use for the Target tangent.</summary>
		public Beam2SourceTargetTangentMethod TargetTangentMethod;
		
		/// <summary>The tangent for the Target point for each beam.</summary>
		public FRawDistributionVector TargetTangent;
		
		/// <summary>Whether to lock the Target to the life of the particle.</summary>
		public bool bLockTargetTangent;
		
		/// <summary>The strength of the tangent from the Target point for each beam.</summary>
		public FRawDistributionFloat TargetStrength;
		
		/// <summary>Whether to lock the Target to the life of the particle.</summary>
		public bool bLockTargetStength;
		
		/// <summary>Default target-point information to use if the beam method is endpoint.</summary>
		public float LockRadius;
		
		
	}
	
}
