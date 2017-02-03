using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EUserDefinedStructureStatus:byte
	{
		/// <summary>Struct is in an unknown state.</summary>
		UDSS_UpToDate=0,
		/// <summary>Struct has been modified but not recompiled.</summary>
		UDSS_Dirty=1,
		/// <summary>Struct tried but failed to be compiled.</summary>
		UDSS_Error=2,
		/// <summary>Struct is a duplicate, the original one was changed.</summary>
		UDSS_Duplicate=3,
		UDSS_MAX=4,
		
	}
	
}
