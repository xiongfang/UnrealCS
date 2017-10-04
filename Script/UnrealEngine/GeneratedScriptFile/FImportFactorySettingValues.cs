using System;
namespace UnrealEngine
{
	/// <summary>Holds UProperty names and values to customize factory settings</summary>
	public partial struct FImportFactorySettingValues
	{
		/// <summary>Name of the property to change.  Nested settings can be modified using "Outer.Property</summary>
		public FString SettingName;
		/// <summary>Value to import for the specified property.</summary>
		public FString Value;
		
	}
	
}
