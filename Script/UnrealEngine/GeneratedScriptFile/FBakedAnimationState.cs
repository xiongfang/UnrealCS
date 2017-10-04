using System;
namespace UnrealEngine
{
	public partial struct FBakedAnimationState
	{
		/// <summary>The name of this state</summary>
		public FName StateName;
		/// <summary>The root node index (into the AnimNodeProperties array of the UAnimBlueprintGeneratedClass)</summary>
		public int StateRootNodeIndex;
		public int StartNotify;
		public int EndNotify;
		public int FullyBlendedNotify;
		public bool bIsAConduit;
		public int EntryRuleNodeIndex;
		/// <summary>Whether or not this state will ALWAYS reset it's state on reentry, regardless of remaining weight</summary>
		public bool bAlwaysResetOnEntry;
		
	}
	
}
