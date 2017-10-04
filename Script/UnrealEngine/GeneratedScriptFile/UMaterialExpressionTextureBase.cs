using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionTextureBase:UMaterialExpression
	{
		public UTexture Texture;
		
		public EMaterialSamplerType SamplerType;
		
		/// <summary>Is default selected texture when using mesh paint mode texture painting</summary>
		public bool IsDefaultMeshpaintTexture;
		
		
	}
	
}
