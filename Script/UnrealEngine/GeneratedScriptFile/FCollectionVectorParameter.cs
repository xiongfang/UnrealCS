using System;
namespace UnrealEngine
{
	/// <summary>A vector parameter</summary>
	public partial struct FCollectionVectorParameter
	{
		public FLinearColor DefaultValue;
		/// <summary>The name of the parameter.  Changing this name will break any blueprints that reference the parameter.</summary>
		public FName ParameterName;
		/// <summary>Uniquely identifies the parameter, used for fixing up materials that reference this parameter when renaming.</summary>
		public FGuid Id;
		
	}
	
}
