using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionCollectionParameter:UMaterialExpression
	{
		/// <summary>The Parameter Collection to use.</summary>
		public UMaterialParameterCollection Collection;
		
		/// <summary>Name of the parameter being referenced.</summary>
		public FName ParameterName;
		
		/// <summary>Id that is set from the name, and used to handle renaming of collection parameters.</summary>
		public FGuid ParameterId;
		
		
	}
	
}
