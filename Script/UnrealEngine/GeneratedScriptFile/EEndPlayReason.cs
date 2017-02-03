using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EEndPlayReason:byte
	{
		/// <summary>When the Actor or Component is explicitly destroyed.</summary>
		Destroyed=0,
		/// <summary>When the world is being unloaded for a level transition.</summary>
		LevelTransition=1,
		/// <summary>When the world is being unloaded because PIE is ending.</summary>
		EndPlayInEditor=2,
		/// <summary>When the level it is a member of is streamed out.</summary>
		RemovedFromWorld=3,
		/// <summary>When the application is being exited.</summary>
		Quit=4,
		EEndPlayReason_MAX=5,
		
	}
	
}
