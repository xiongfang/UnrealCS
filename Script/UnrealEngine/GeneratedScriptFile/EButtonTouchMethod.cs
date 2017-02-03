using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Ways in which touch interactions trigger a "Clicked" event.</summary>
	public enum EButtonTouchMethod:byte
	{
		/// <summary>Most buttons behave this way.</summary>
		DownAndUp=0,
		/// <summary>
		/// Inside a list, buttons can only be clicked with precise tap.
		/// Moving the pointer will scroll the list.
		/// </summary>
		PreciseTap=1,
		EButtonTouchMethod_MAX=2,
		
	}
	
}
