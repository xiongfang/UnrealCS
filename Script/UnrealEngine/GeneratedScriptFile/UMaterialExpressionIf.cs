using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionIf:UMaterialExpression
	{
		public FExpressionInput A;
		
		/// <summary>Defaults to 'ConstB' if not specified</summary>
		public FExpressionInput B;
		
		public FExpressionInput AGreaterThanB;
		
		/// <summary>Defaults to 'A > B' if not specified</summary>
		public FExpressionInput AEqualsB;
		
		public FExpressionInput ALessThanB;
		
		public float EqualsThreshold;
		
		/// <summary>only used if B is not hooked up</summary>
		public float ConstB;
		
		public float ConstAEqualsB;
		
		
	}
	
}
