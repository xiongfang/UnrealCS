using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Smoothing approach used by network interpolation for Characters.</summary>
	public enum ENetworkSmoothingMode:byte
	{
		/// <summary>No smoothing, only change position as network position updates are received.</summary>
		Disabled=0,
		/// <summary>Linear interpolation from source to target.</summary>
		Linear=1,
		/// <summary>Exponential. Faster as you are further from target.</summary>
		Exponential=2,
		/// <summary>Special linear interpolation designed specifically for replays. Not intended as a selectable mode in-editor.</summary>
		Replay=3,
		ENetworkSmoothingMode_MAX=4,
		
	}
	
}
