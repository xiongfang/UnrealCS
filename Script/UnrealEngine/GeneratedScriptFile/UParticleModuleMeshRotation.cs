using System;
namespace UnrealEngine
{
	public partial class UParticleModuleMeshRotation:UParticleModuleRotationBase
	{
		/// <summary>
		/// Initial rotation in ROTATIONS PER SECOND (1 = 360 degrees).
		/// The value is retrieved using the EmitterTime.
		/// </summary>
		public FRawDistributionVector StartRotation;
		
		/// <summary>If true, apply the parents rotation as well.</summary>
		public bool bInheritParent;
		
		
	}
	
}
