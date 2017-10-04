using System;
namespace UnrealEngine
{
	/// <summary>Lookup table for distributions.</summary>
	public partial struct FDistributionLookupTable
	{
		public byte Op;
		public byte EntryCount;
		public byte EntryStride;
		public byte SubEntryStride;
		public float TimeScale;
		public float TimeBias;
		public byte LockFlag;
		
	}
	
}
