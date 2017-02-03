using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EQuitPreference:byte
	{
		/// <summary>Exit the game completely.</summary>
		Quit=0,
		/// <summary>Move the application to the background.</summary>
		Background=1,
		EQuitPreference_MAX=2,
		
	}
	
}
