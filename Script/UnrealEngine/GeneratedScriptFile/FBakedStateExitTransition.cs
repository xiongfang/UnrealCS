using System;
namespace UnrealEngine
{
	public partial struct FBakedStateExitTransition
	{
		/// <summary>The node property index for this rule</summary>
		public int CanTakeDelegateIndex;
		/// <summary>The blend graph result node index</summary>
		public int CustomResultNodeIndex;
		/// <summary>The index into the machine table of transitions</summary>
		public int TransitionIndex;
		/// <summary>What the transition rule node needs to return to take this transition (for bidirectional transitions)</summary>
		public bool bDesiredTransitionReturnValue;
		/// <summary>Automatic Transition Rule based on animation remaining time.</summary>
		public bool bAutomaticRemainingTimeRule;
		
	}
	
}
