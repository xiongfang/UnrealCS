using System;
namespace UnrealEngine
{
	/// <summary>Container struct for holding options on the data updating for the module.</summary>
	public partial struct FOrbitOptions
	{
		/// <summary>Whether to process the data during spawning.</summary>
		public bool bProcessDuringSpawn;
		/// <summary>Whether to process the data during updating.</summary>
		public bool bProcessDuringUpdate;
		/// <summary>Whether to use emitter time during data retrieval.</summary>
		public bool bUseEmitterTime;
		
	}
	
}
