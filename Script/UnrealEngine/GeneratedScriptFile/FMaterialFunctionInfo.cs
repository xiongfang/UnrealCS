using System;
namespace UnrealEngine
{
	/// <summary>Stores information about a function that this material references, used to know when the material needs to be recompiled.</summary>
	public partial struct FMaterialFunctionInfo
	{
		/// <summary>Id that the function had when this material was last compiled.</summary>
		public FGuid StateId;
		/// <summary>The function which this material has a dependency on.</summary>
		public UMaterialFunction Function;
		
	}
	
}
