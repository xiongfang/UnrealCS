using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionReflectionVectorWS:UMaterialExpression
	{
		/// <summary>Defaults to Reflection Vector if not specified</summary>
		public FExpressionInput CustomWorldNormal;
		
		/// <summary>(true): The specified world normal will be normalized. (false): WorldNormal will just be used as is, faster but possible artifacts if normal length isn't 1</summary>
		public bool bNormalizeCustomWorldNormal;
		
		
	}
	
}
