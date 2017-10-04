using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFeatureLevelSwitch:UMaterialExpression
	{
		/// <summary>Default connection, used when a certain feature level doesn't have an override.</summary>
		public FExpressionInput Default;
		
		public FExpressionInput Inputs;
		
		
	}
	
}
