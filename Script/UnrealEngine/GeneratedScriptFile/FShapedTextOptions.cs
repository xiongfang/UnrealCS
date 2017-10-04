using System;
namespace UnrealEngine
{
	/// <summary>
	/// Common data for all widgets that use shaped text.
	/// Contains the common options that should be exposed for the underlying Slate widget.
	/// </summary>
	public partial struct FShapedTextOptions
	{
		public bool bOverride_TextShapingMethod;
		public bool bOverride_TextFlowDirection;
		
	}
	
}
