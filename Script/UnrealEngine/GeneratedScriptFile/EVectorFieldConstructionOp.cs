using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Operation used to construct the vector field from a 2D texture.</summary>
	public enum EVectorFieldConstructionOp:byte
	{
		VFCO_Extrude=0,
		VFCO_Revolve=1,
		VFCO_MAX=2,
		
	}
	
}
