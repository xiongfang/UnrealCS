using System;
namespace UnrealEngine
{
	public partial class UMaterialExpressionFontSampleParameter:UMaterialExpressionFontSample
	{
		/// <summary>name to be referenced when we want to find and set thsi parameter</summary>
		public FName ParameterName;
		
		/// <summary>GUID that should be unique within the material, this is used for parameter renaming.</summary>
		public FGuid ExpressionGUID;
		
		/// <summary>The name of the parameter Group to display in MaterialInstance Editor. Default is None group</summary>
		public FName Group;
		
		
	}
	
}
