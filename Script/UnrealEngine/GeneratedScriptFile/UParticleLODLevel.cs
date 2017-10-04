using System;
namespace UnrealEngine
{
	public partial class UParticleLODLevel:UObject
	{
		/// <summary>The index value of the LOD level</summary>
		public int Level;
		
		/// <summary>True if the LOD level is enabled, meaning it should be updated and rendered.</summary>
		public bool bEnabled;
		
		/// <summary>The required module for this LOD level</summary>
		public UParticleModuleRequired RequiredModule;
		
		/// <summary>Module<SINGULAR> used for emitter type "extension".</summary>
		public UParticleModuleTypeDataBase TypeDataModule;
		
		/// <summary>The SpawnRate/Burst module - required by all emitters.</summary>
		public UParticleModuleSpawn SpawnModule;
		
		/// <summary>The optional EventGenerator module.</summary>
		public UParticleModuleEventGenerator EventGenerator;
		
		public bool ConvertedModules;
		
		public int PeakActiveParticles;
		
		
	}
	
}
