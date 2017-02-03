using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum FNavigationSystemRunMode:byte
	{
		InvalidMode=0,
		GameMode=1,
		EditorMode=2,
		SimulationMode=3,
		PIEMode=4,
		FNavigationSystemRunMode_MAX=5,
		
	}
	
}
