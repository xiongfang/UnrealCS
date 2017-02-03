using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Current state of the check box</summary>
	public enum ECheckBoxState:byte
	{
		/// <summary>Unchecked</summary>
		Unchecked=0,
		/// <summary>Checked</summary>
		Checked=1,
		/// <summary>Neither checked nor unchecked</summary>
		Undetermined=2,
		ECheckBoxState_MAX=3,
		
	}
	
}
