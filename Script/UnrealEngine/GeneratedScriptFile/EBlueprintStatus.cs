using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates states a blueprint can be in.</summary>
	public enum EBlueprintStatus:byte
	{
		/// <summary>Blueprint is in an unknown state.</summary>
		BS_Unknown=0,
		/// <summary>Blueprint has been modified but not recompiled.</summary>
		BS_Dirty=1,
		/// <summary>Blueprint tried but failed to be compiled.</summary>
		BS_Error=2,
		/// <summary>Blueprint has been compiled since it was last modified.</summary>
		BS_UpToDate=3,
		/// <summary>Blueprint is in the process of being created for the first time.</summary>
		BS_BeingCreated=4,
		/// <summary>Blueprint has been compiled since it was last modified. There are warnings.</summary>
		BS_UpToDateWithWarnings=5,
		BS_MAX=6,
		
	}
	
}
