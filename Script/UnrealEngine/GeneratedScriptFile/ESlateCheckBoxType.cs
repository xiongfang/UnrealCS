using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Type of check box</summary>
	public enum ESlateCheckBoxType:byte
	{
		/// <summary>Traditional check box with check button and label (or other content)</summary>
		CheckBox=0,
		/// <summary>Toggle button.  You provide button content (such as an image), and the user can press to toggle it.</summary>
		ToggleButton=1,
		ESlateCheckBoxType_MAX=2,
		
	}
	
}
