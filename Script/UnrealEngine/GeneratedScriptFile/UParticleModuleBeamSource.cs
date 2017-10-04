using System;
namespace UnrealEngine
{
	public partial class UParticleModuleBeamSource:UParticleModuleBeamBase
	{
		/// <summary>The method flag.</summary>
		public Beam2SourceTargetMethod SourceMethod;
		
		/// <summary>The strength of the tangent from the source point for each beam.</summary>
		public FName SourceName;
		
		/// <summary>Whether to treat the as an absolute position in world space.</summary>
		public bool bSourceAbsolute;
		
		/// <summary>Default source-point to use.</summary>
		public FRawDistributionVector Source;
		
		/// <summary>Whether to lock the source to the life of the particle.</summary>
		public bool bLockSource;
		
		/// <summary>The method to use for the source tangent.</summary>
		public Beam2SourceTargetTangentMethod SourceTangentMethod;
		
		/// <summary>The tangent for the source point for each beam.</summary>
		public FRawDistributionVector SourceTangent;
		
		/// <summary>Whether to lock the source to the life of the particle.</summary>
		public bool bLockSourceTangent;
		
		/// <summary>The strength of the tangent from the source point for each beam.</summary>
		public FRawDistributionFloat SourceStrength;
		
		/// <summary>Whether to lock the source to the life of the particle.</summary>
		public bool bLockSourceStength;
		
		
	}
	
}
