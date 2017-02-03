using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Whether or not the timeline should be finished after the specified length, or the last keyframe in the tracks</summary>
	public enum ETimelineLengthMode:byte
	{
		TL_TimelineLength=0,
		TL_LastKeyFrame=1,
		TL_MAX=2,
		
	}
	
}
