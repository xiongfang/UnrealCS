using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionLinearInterpolate:UMaterialExpression
	{
		/// <summary>Defaults to 'ConstA' if not specified</summary>
		public FExpressionInput A;
		
		/// <summary>Defaults to 'ConstB' if not specified</summary>
		public FExpressionInput B;
		
		/// <summary>Defaults to 'ConstAlpha' if not specified</summary>
		public FExpressionInput Alpha;
		
		/// <summary>only used if A is not hooked up</summary>
		public float ConstA;
		
		/// <summary>only used if B is not hooked up</summary>
		public float ConstB;
		
		/// <summary>only used if Alpha is not hooked up</summary>
		public float ConstAlpha;
		
		
	}
	
}
