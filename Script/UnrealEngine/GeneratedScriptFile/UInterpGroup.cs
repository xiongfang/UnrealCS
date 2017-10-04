using System;
namespace UnrealEngine
{
	public partial class UInterpGroup:UObject
	{
		/// <summary>
		/// Within an InterpData, all GroupNames must be unique.
		/// Used for naming Variable connectors on the Action in Kismet and finding each groups object.
		/// </summary>
		public FName GroupName;
		
		/// <summary>Colour used for drawing tracks etc. related to this group.</summary>
		public FColor GroupColor;
		
		/// <summary>Whether or not this group is folded away in the editor.</summary>
		public bool bCollapsed;
		
		/// <summary>Whether or not this group is visible in the editor.</summary>
		public bool bVisible;
		
		/// <summary>When enabled, this group is treated like a folder in the editor, which should only be used for organization.  Folders are never associated with actors and don't have a presence in the Kismet graph.</summary>
		public bool bIsFolder;
		
		/// <summary>When true, this group is considered a 'visual child' of another group.  This doesn't at all affect the behavior of the group, it's only for visual organization.  Also, it's implied that the parent is the next prior group in the array that doesn't have a parent.</summary>
		public bool bIsParented;
		
		/// <summary>When enabled, this group will be selected in the interp editor.</summary>
		public bool bIsSelected;
		
		
	}
	
}
