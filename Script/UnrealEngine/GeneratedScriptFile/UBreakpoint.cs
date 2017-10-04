using System;
namespace UnrealEngine
{
	public partial class UBreakpoint:UObject
	{
		/// <summary>Is the breakpoint currently enabled?</summary>
		public bool bEnabled;
		
		/// <summary>Node that the breakpoint is placed on</summary>
		public UEdGraphNode Node;
		
		/// <summary>Is this breakpoint auto-generated, and should be removed when next hit?</summary>
		public bool bStepOnce;
		
		public bool bStepOnce_WasPreviouslyDisabled;
		
		public bool bStepOnce_RemoveAfterHit;
		
		
	}
	
}
