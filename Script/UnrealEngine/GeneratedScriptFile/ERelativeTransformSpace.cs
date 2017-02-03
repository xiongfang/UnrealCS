using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The space for the transform</summary>
	public enum ERelativeTransformSpace:byte
	{
		/// <summary>World space transform.</summary>
		RTS_World=0,
		/// <summary>Actor space transform.</summary>
		RTS_Actor=1,
		/// <summary>Component space transform.</summary>
		RTS_Component=2,
		/// <summary>Parent bone space transform</summary>
		RTS_ParentBoneSpace=3,
		RTS_MAX=4,
		
	}
	
}
