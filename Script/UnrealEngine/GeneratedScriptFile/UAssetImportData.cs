using System;
namespace UnrealEngine
{
	public partial class UAssetImportData:UObject
	{
		/// <summary>Path to the resource used to construct this static mesh. Relative to the object's package, BaseDir() or absolute</summary>
		public FString SourceFilePath;
		
		/// <summary>Date/Time-stamp of the file from the last import</summary>
		public FString SourceFileTimestamp;
		
		/// <summary>Source file data describing the files that were used to import this asset.</summary>
		public FAssetImportInfo SourceData;
		
		
	}
	
}
