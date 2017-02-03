using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ERootMotionMode:byte
	{
		/// <summary>Leave root motion in animation.</summary>
		NoRootMotionExtraction=0,
		/// <summary>Extract root motion but do not apply it.</summary>
		IgnoreRootMotion=1,
		/// <summary>Root motion is taken from all animations contributing to the final pose, not suitable for network multiplayer setups.</summary>
		RootMotionFromEverything=2,
		/// <summary>Root motion is only taken from montages, suitable for network multiplayer setups.</summary>
		RootMotionFromMontagesOnly=3,
		ERootMotionMode_MAX=4,
		
	}
	
}
