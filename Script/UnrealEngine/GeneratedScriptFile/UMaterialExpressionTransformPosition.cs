using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTransformPosition:UMaterialExpression
	{
		/// <summary>input expression for this transform</summary>
		public FExpressionInput Input;
		
		/// <summary>source format of the position that will be transformed</summary>
		public EMaterialPositionTransformSource TransformSourceType;
		
		/// <summary>type of transform to apply to the input expression</summary>
		public EMaterialPositionTransformSource TransformType;
		
		
	}
	
}
