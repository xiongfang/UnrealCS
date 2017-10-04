using System;
namespace UnrealEngine
{
	public partial class UNavRelevantComponent:UActorComponent
	{
		public extern void SetNavigationRelevancy(bool bRelevant);
		/// <summary>attach navigation data to entry for owner's root component (depends on its relevancy)</summary>
		public bool bAttachToOwnersRoot;
		
		public UObject CachedNavParent;
		
		
	}
	
}
