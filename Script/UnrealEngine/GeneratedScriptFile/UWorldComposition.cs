using System;
namespace UnrealEngine
{
	public partial class UWorldComposition:UObject
	{
		/// <summary>Time threshold between tile streaming state changes</summary>
		public double TilesStreamingTimeThreshold;
		
		/// <summary>Whether all distance dependent tiles should be loaded and visible during cinematic</summary>
		public bool bLoadAllTilesDuringCinematic;
		
		/// <summary>Whether to rebase origin in 3D space, otherwise only on XY plane</summary>
		public bool bRebaseOriginIn3DSpace;
		
		/// <summary>Maximum distance to current view point where we should initiate origin rebasing</summary>
		public float RebaseOriginDistance;
		
		
	}
	
}
