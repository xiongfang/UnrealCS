using System;
namespace UnrealEngine
{
	/// <summary>Stores information about a parameter collection that this material references, used to know when the material needs to be recompiled.</summary>
	public partial struct FMaterialParameterCollectionInfo
	{
		/// <summary>Id that the collection had when this material was last compiled.</summary>
		public FGuid StateId;
		/// <summary>The collection which this material has a dependency on.</summary>
		public UMaterialParameterCollection ParameterCollection;
		
	}
	
}
