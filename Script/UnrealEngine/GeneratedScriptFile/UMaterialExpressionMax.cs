using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionMax:UMaterialExpression
	{
		/// <summary>Defaults to 'ConstA' if not specified</summary>
		public FExpressionInput A;
		
		/// <summary>Defaults to 'ConstB' if not specified</summary>
		public FExpressionInput B;
		
		/// <summary>only used if A is not hooked up</summary>
		public float ConstA;
		
		/// <summary>only used if B is not hooked up</summary>
		public float ConstB;
		
		
	}
	
}
