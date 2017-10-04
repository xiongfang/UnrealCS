using System;
namespace UnrealEngine
{
	public partial struct FParticleBurst
	{
		/// <summary>The number of particles to burst</summary>
		public int Count;
		/// <summary>If >= 0, use as a range [CountLow..Count]</summary>
		public int CountLow;
		/// <summary>The time at which to burst them (0..1: emitter lifetime)</summary>
		public float Time;
		
	}
	
}
