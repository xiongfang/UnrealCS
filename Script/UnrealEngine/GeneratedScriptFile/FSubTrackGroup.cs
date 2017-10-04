using System;
namespace UnrealEngine
{
	/// <summary>A small structure holding data for grouping subtracks. (For UI drawing purposes)</summary>
	public partial struct FSubTrackGroup
	{
		/// <summary>Name of the subtrack  group</summary>
		public FString GroupName;
		/// <summary>If this group is collapsed</summary>
		public bool bIsCollapsed;
		/// <summary>If this group is selected</summary>
		public bool bIsSelected;
		
	}
	
}
