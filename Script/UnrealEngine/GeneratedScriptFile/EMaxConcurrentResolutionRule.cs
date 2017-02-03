using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMaxConcurrentResolutionRule:byte
	{
		/// <summary>When Max Concurrent sounds are active do not start a new sound.</summary>
		PreventNew=0,
		/// <summary>When Max Concurrent sounds are active stop the oldest and start a new one.</summary>
		StopOldest=1,
		/// <summary>When Max Concurrent sounds are active stop the furthest sound.  If all sounds are the same distance then do not start a new sound.</summary>
		StopFarthestThenPreventNew=2,
		/// <summary>When Max Concurrent sounds are active stop the furthest sound.  If all sounds are the same distance then stop the oldest.</summary>
		StopFarthestThenOldest=3,
		/// <summary>Stop the lowest priority sound in the group. If all sounds are the same priority, then it will stop the oldest sound in the group.</summary>
		StopLowestPriority=4,
		/// <summary>Stop the sound that is quietest in the group.</summary>
		StopQuietest=5,
		/// <summary>Stop the lowest priority sound in the group. If all sounds are the same priority, then it won't play a new sound.</summary>
		StopLowestPriorityThenPreventNew=6,
		EMaxConcurrentResolutionRule_MAX=7,
		
	}
	
}
