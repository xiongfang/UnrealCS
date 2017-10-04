using System;
namespace UnrealEngine
{
	public partial class UDataTable:UObject
	{
		/// <summary>Structure to use for each row of the table, must inherit from FTableRowBase</summary>
		public UScriptStruct RowStruct;
		
		public UAssetImportData AssetImportData;
		
		/// <summary>The filename imported to create this object. Relative to this object's package, BaseDir() or absolute</summary>
		public FString ImportPath;
		
		/// <summary>The name of the RowStruct we were using when we were last saved</summary>
		public FName RowStructName;
		
		
	}
	
}
