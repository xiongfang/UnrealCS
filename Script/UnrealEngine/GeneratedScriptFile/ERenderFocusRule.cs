using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>When to render the Focus Brush for widgets that have user focus. Based on the EFocusCause.</summary>
	public enum ERenderFocusRule:byte
	{
		/// <summary>Focus Brush will always be rendered for widgets that have user focus.</summary>
		Always=0,
		/// <summary>Focus Brush will be rendered for widgets that have user focus not set based on pointer causes.</summary>
		NonPointer=1,
		/// <summary>Focus Brush will be rendered for widgets that have user focus only if the focus was set by navigation.</summary>
		NavigationOnly=2,
		/// <summary>Focus Brush will not be rendered.</summary>
		Never=3,
		ERenderFocusRule_MAX=4,
		
	}
	
}
