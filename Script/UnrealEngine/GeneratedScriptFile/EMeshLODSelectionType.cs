using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EMeshLODSelectionType:byte
	{
		/// <summary>Whether or not to export all of the LODs found in the source meshes</summary>
		AllLODs=0,
		/// <summary>Whether or not to export all of the LODs found in the source meshes</summary>
		SpecificLOD=1,
		/// <summary>Whether or not to calculate the appropriate LOD model for the given screen size</summary>
		CalculateLOD=2,
		EMeshLODSelectionType_MAX=3,
		
	}
	
}
