using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EInputConsumeOptions:byte
	{
		/// <summary>This component consumes all input and no components lower in the stack are processed.</summary>
		ICO_ConsumeAll=0,
		/// <summary>This component consumes all events for a keys it has bound (whether or not they are handled successfully).  Components lower in the stack will not receive events from these keys.</summary>
		ICO_ConsumeBoundKeys=1,
		/// <summary>All input events will be available to components lower in the stack.</summary>
		ICO_ConsumeNone=2,
		ICO_MAX=3,
		
	}
	
}
