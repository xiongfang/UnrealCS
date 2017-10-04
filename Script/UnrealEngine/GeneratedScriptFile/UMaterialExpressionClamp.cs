using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionClamp:UMaterialExpression
	{
		public FExpressionInput Input;
		
		/// <summary>Defaults to 'MinDefault' if not specified</summary>
		public FExpressionInput Min;
		
		/// <summary>Defaults to 'MaxDefault' if not specified</summary>
		public FExpressionInput Max;
		
		public EClampMode ClampMode;
		
		public float MinDefault;
		
		public float MaxDefault;
		
		
	}
	
}
