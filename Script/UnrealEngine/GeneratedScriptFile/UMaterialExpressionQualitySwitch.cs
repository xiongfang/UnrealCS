using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionQualitySwitch:UMaterialExpression
	{
		/// <summary>Default connection, used when a specific quality level input is missing.</summary>
		public FExpressionInput Default;
		
		public FExpressionInput Inputs;
		
		
	}
	
}
