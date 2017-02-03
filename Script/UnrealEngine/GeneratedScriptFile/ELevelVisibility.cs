using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Visibility options for the level visibility section.</summary>
	public enum ELevelVisibility:byte
	{
		/// <summary>The streamed levels should be visible.</summary>
		Visible=0,
		/// <summary>The streamed levels should be hidden.</summary>
		Hidden=1,
		ELevelVisibility_MAX=2,
		
	}
	
}
