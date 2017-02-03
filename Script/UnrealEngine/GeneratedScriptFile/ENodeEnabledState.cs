using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum to indicate a node's enabled state.</summary>
	public enum ENodeEnabledState:byte
	{
		/// <summary>Node is enabled.</summary>
		Enabled=0,
		/// <summary>Node is disabled.</summary>
		Disabled=1,
		/// <summary>Node is enabled for development only.</summary>
		DevelopmentOnly=2,
		ENodeEnabledState_MAX=3,
		
	}
	
}
