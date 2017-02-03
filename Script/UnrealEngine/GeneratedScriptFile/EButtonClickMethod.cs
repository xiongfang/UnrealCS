using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates different methods that a button click can be triggered. Normally, DownAndUp is appropriate.</summary>
	public enum EButtonClickMethod:byte
	{
		/// <summary>
		/// User must press the button, then release while over the button to trigger the click.
		/// This is the most common type of button.
		/// </summary>
		DownAndUp=0,
		/// <summary>Click will be triggered immediately on mouse down, and mouse will not be captured.</summary>
		MouseDown=1,
		/// <summary>
		/// Click will always be triggered when mouse button is released over the button,
		/// even if the button wasn't pressed down over it.
		/// </summary>
		MouseUp=2,
		/// <summary>
		/// Inside a list, buttons can only be clicked with precise tap.
		/// Moving the pointer will scroll the list, also allows drag-droppable buttons.
		/// </summary>
		PreciseClick=3,
		EButtonClickMethod_MAX=4,
		
	}
	
}
