using System;
namespace UnrealEngine
{
	public partial class UMaterialInstanceConstant:UMaterialInstance
	{
		/// <summary>
		/// Unique ID for this material instance's parameter set
		/// Updated on changes in the editor to allow those changes to be detected
		/// </summary>
		public FGuid ParameterStateId;
		
		
	}
	
}
