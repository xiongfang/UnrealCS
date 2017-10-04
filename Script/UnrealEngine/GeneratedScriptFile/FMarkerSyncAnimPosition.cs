using System;
namespace UnrealEngine
{
	/// <summary>
	/// Represent a current play position in an animation
	/// based on sync markers
	/// </summary>
	public partial struct FMarkerSyncAnimPosition
	{
		/// <summary>The marker we have passed</summary>
		public FName PreviousMarkerName;
		/// <summary>The marker we are heading towards</summary>
		public FName NextMarkerName;
		/// <summary>
		/// Value between 0 and 1 representing where we are:
		///       0   we are at PreviousMarker
		///       1   we are at NextMarker
		///       0.5 we are half way between the two
		/// </summary>
		public float PositionBetweenMarkers;
		
	}
	
}
