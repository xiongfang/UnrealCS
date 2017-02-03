using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enum used to define which way data flows into or out of this pin.</summary>
	public enum EEdGraphPinDirection:byte
	{
		EGPD_Input=0,
		EGPD_Output=1,
		EGPD_MAX=2,
		
	}
	
}
