using System;
namespace UnrealEngine
{
	public partial class UNavigationQueryFilter:UObject
	{
		/// <summary>required flags of navigation nodes</summary>
		public FNavigationFilterFlags IncludeFlags;
		
		/// <summary>forbidden flags of navigation nodes</summary>
		public FNavigationFilterFlags ExcludeFlags;
		
		
	}
	
}
