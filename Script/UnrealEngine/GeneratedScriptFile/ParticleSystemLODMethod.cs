using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>ParticleSystemLODMethod</summary>
	public enum ParticleSystemLODMethod:byte
	{
		/// <summary>Automatically set the LOD level, checking every LODDistanceCheckTime seconds.</summary>
		utomatic=0,
		/// <summary>LOD level is directly set by the game code.</summary>
		irectSet=1,
		/// <summary>LOD level is determined at Activation time, then left alone unless directly set by game code.</summary>
		ctivateAutomatic=2,
		AX=3,
		
	}
	
}
