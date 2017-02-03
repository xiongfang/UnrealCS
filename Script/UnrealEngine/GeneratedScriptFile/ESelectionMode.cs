using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ESelectionMode:byte
	{
		/// <summary>Nothing can be selected and there is no hover cue for selection.  You can still handle mouse button events though.</summary>
		None=0,
		/// <summary>A single item can be selected at once, or no item may be selected.</summary>
		Single=1,
		/// <summary>A single item can be selected at once, or no item may be selected.  You can click the item to toggle selection on and off.</summary>
		SingleToggle=2,
		/// <summary>Multiple items can be selected at the same time.</summary>
		Multi=3,
		ESelectionMode_MAX=4,
		
	}
	
}
