using System;
namespace UnrealEngine
{
	public partial class UTimelineTemplate:UObject
	{
		/// <summary>Length of this timeline</summary>
		public float TimelineLength;
		
		/// <summary>How we want the timeline to determine its own length (e.g. specified length, last keyframe)</summary>
		public ETimelineLengthMode LengthMode;
		
		/// <summary>If we want the timeline to auto-play</summary>
		public bool bAutoPlay;
		
		/// <summary>If we want the timeline to loop</summary>
		public bool bLoop;
		
		/// <summary>If we want the timeline to loop</summary>
		public bool bReplicated;
		
		/// <summary>Compiler Validated As Wired up</summary>
		public bool bValidatedAsWired;
		
		/// <summary>If we want the timeline to ignore global time dilation</summary>
		public bool bIgnoreTimeDilation;
		
		public FGuid TimelineGuid;
		
		
	}
	
}
