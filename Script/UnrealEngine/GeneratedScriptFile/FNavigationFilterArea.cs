using System;
namespace UnrealEngine
{
	public partial struct FNavigationFilterArea
	{
		/// <summary>navigation area class</summary>
		public TSubclassOf<UNavArea>  AreaClass;
		/// <summary>override for travel cost</summary>
		public float TravelCostOverride;
		/// <summary>override for entering cost</summary>
		public float EnteringCostOverride;
		/// <summary>mark as excluded</summary>
		public bool bIsExcluded;
		public bool bOverrideTravelCost;
		public bool bOverrideEnteringCost;
		
	}
	
}
