using System;
namespace UnrealEngine
{
	public partial struct FAnimSyncMarker
	{
		/// <summary>The name of this marker</summary>
		public FName MarkerName;
		/// <summary>Time in seconds of this marker</summary>
		public float Time;
		/// <summary>The editor track this marker sits on</summary>
		public int TrackIndex;
		
	}
	
}
