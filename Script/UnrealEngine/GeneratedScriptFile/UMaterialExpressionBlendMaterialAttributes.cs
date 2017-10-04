using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionBlendMaterialAttributes:UMaterialExpression
	{
		public FMaterialAttributesInput A;
		
		public FMaterialAttributesInput B;
		
		public FExpressionInput Alpha;
		
		/// <summary>Optionally skip blending attributes of this type.</summary>
		public EMaterialAttributeBlend PixelAttributeBlendType;
		
		/// <summary>Optionally skip blending attributes of this type.</summary>
		public EMaterialAttributeBlend VertexAttributeBlendType;
		
		
	}
	
}
