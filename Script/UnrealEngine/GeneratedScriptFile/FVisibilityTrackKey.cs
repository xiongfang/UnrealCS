using System;
namespace UnrealEngine
{
	/// <summary>Information for one toggle in the track.</summary>
	public partial struct FVisibilityTrackKey
	{
		public float Time;
		public EVisibilityTrackAction Action;
		/// <summary>Condition that must be satisfied for this key event to fire</summary>
		public EVisibilityTrackCondition ActiveCondition;
		
	}
	
}
