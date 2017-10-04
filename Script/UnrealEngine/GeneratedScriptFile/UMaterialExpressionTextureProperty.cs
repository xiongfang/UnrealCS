using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureProperty:UMaterialExpression
	{
		/// <summary>Texture Object to access the property from.</summary>
		public FExpressionInput TextureObject;
		
		/// <summary>Texture property to be accessed</summary>
		public EMaterialExposedTextureProperty Property;
		
		
	}
	
}
