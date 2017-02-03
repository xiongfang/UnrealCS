using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A priority for sorting scene elements by depth.
	/// Elements with higher priority occlude elements with lower priority, disregarding distance.
	/// </summary>
	public enum ESceneDepthPriorityGroup:byte
	{
		/// <summary>World scene DPG.</summary>
		SDPG_World=0,
		/// <summary>Foreground scene DPG.</summary>
		SDPG_Foreground=1,
		SDPG_MAX=2,
		
	}
	
}
