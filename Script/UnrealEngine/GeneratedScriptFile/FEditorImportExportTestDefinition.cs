using System;
namespace UnrealEngine
{
	/// <summary>Holds settings for the asset import / export automation test</summary>
	public partial struct FEditorImportExportTestDefinition
	{
		/// <summary>The file to import</summary>
		public FFilePath ImportFilePath;
		/// <summary>The file extension to use when exporting this asset.  Used to find a supporting exporter</summary>
		public FString ExportFileExtension;
		/// <summary>If true, the export step will be skipped</summary>
		public bool bSkipExport;
		
	}
	
}
