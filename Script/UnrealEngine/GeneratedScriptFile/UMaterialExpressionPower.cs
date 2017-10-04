using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionPower:UMaterialExpression
	{
		public FExpressionInput Base;
		
		/// <summary>Defaults to 'ConstExponent' if not specified</summary>
		public FExpressionInput Exponent;
		
		/// <summary>only used if Exponent is not hooked up</summary>
		public float ConstExponent;
		
		
	}
	
}
