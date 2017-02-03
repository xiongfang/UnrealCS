using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EOpacitySourceMode:byte
	{
		OSM_Alpha=0,
		OSM_ColorBrightness=1,
		OSM_RedChannel=2,
		OSM_GreenChannel=3,
		OSM_BlueChannel=4,
		OSM_MAX=5,
		
	}
	
}
