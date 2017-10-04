using System;
namespace UnrealEngine
{
	public partial class USoundNodeRandom:USoundNode
	{
		/// <summary>
		/// If greater than 0, then upon each level load such a number of inputs will be randomly selected
		/// and the rest will be removed. This can be used to cut down the memory usage of large randomizing
		/// cues.
		/// </summary>
		public int PreselectAtLevelLoad;
		
		/// <summary>
		/// Determines whether or not this SoundNodeRandom should randomize with or without
		/// replacement.
		/// WithoutReplacement means that only nodes left will be valid for
		/// selection.  So with that, you are guarenteed to have only one occurrence of the
		/// sound played until all of the other sounds in the set have all been played.
		/// WithReplacement means that a node will be chosen and then placed back into the set.
		/// So one could play the same sound over and over if the probabilities don't go your way :-)
		/// </summary>
		public bool bRandomizeWithoutReplacement;
		
		/// <summary>Counter var so we don't have to count all of the used sounds each time we choose a sound *</summary>
		public int NumRandomUsed;
		
		
	}
	
}
