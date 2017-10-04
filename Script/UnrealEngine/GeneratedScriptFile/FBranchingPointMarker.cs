using System;
namespace UnrealEngine
{
	/// <summary>
	/// AnimNotifies marked as BranchingPoints will create these markers on their Begin/End times.
	///       They create stopping points when the Montage is being ticked to dispatch events.
	/// </summary>
	public partial struct FBranchingPointMarker
	{
		public int NotifyIndex;
		public float TriggerTime;
		public EAnimNotifyEventType NotifyEventType;
		
	}
	
}
