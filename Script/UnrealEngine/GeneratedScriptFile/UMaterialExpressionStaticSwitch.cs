using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionStaticSwitch:UMaterialExpression
	{
		public bool DefaultValue;
		
		public FExpressionInput A;
		
		public FExpressionInput B;
		
		/// <summary>Ignored if not specified</summary>
		public FExpressionInput Value;
		
		
	}
	
}
