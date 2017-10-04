using System;
namespace UnrealEngine
{
	public partial class ALevelStreamingVolume:AVolume
	{
		/// <summary>If true, this streaming volume should only be used for editor streaming level previs.</summary>
		public bool bEditorPreVisOnly;
		
		/// <summary>
		/// If true, this streaming volume is ignored by the streaming volume code.  Used to either
		/// disable a level streaming volume without disassociating it from the level, or to toggle
		/// the control of a level's streaming between Kismet and volume streaming.
		/// </summary>
		public bool bDisabled;
		
		/// <summary>Determines what this volume is used for, e.g. whether to control loading, loading and visibility or just visibilty (blocking on load)</summary>
		public EStreamingVolumeUsage StreamingUsage;
		
		
	}
	
}
