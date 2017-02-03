using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EAutoPossessAI:byte
	{
		/// <summary>Feature is disabled (do not automatically possess AI).</summary>
		Disabled=0,
		/// <summary>Only possess by an AI Controller if Pawn is placed in the world.</summary>
		PlacedInWorld=1,
		/// <summary>Only possess by an AI Controller if Pawn is spawned after the world has loaded.</summary>
		Spawned=2,
		/// <summary>Pawn is automatically possessed by an AI Controller whenever it is created.</summary>
		PlacedInWorldOrSpawned=3,
		EAutoPossessAI_MAX=4,
		
	}
	
}
