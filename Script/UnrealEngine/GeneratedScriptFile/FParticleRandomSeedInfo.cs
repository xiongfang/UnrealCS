using System;
namespace UnrealEngine
{
	public partial struct FParticleRandomSeedInfo
	{
		/// <summary>The name to expose to the placed instances for setting this seed</summary>
		public FName ParameterName;
		/// <summary>
		/// If true, the module will attempt to get the seed from the owner
		/// instance. If that fails, it will fall back to getting it from
		/// the RandomSeeds array.
		/// </summary>
		public bool bGetSeedFromInstance;
		/// <summary>
		/// If true, the seed value retrieved from the instance will be an
		/// index into the array of seeds.
		/// </summary>
		public bool bInstanceSeedIsIndex;
		/// <summary>
		/// If true, then reset the seed upon the emitter looping.
		/// For looping environmental effects this should likely be set to false to avoid
		/// a repeating pattern.
		/// </summary>
		public bool bResetSeedOnEmitterLooping;
		/// <summary>If true, then randomly select a seed entry from the RandomSeeds array</summary>
		public bool bRandomlySelectSeedArray;
		
	}
	
}
