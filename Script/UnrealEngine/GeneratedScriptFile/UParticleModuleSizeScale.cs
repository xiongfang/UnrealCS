using System;
namespace UnrealEngine
{
	public partial class UParticleModuleSizeScale:UParticleModuleSizeBase
	{
		/// <summary>
		/// The amount the BaseSize should be scaled before being used as the size of the particle.
		/// The value is retrieved using the RelativeTime of the particle during its update.
		/// NOTE: this module overrides any size adjustments made prior to this module in that frame.
		/// </summary>
		public FRawDistributionVector SizeScale;
		
		/// <summary>Ignored</summary>
		public bool EnableX;
		
		/// <summary>Ignored</summary>
		public bool EnableY;
		
		/// <summary>Ignored</summary>
		public bool EnableZ;
		
		
	}
	
}
