using System;
namespace UnrealEngine
{
	public partial class UExporter:UObject
	{
		/// <summary>Supported class of this exporter</summary>
		public TSubclassOf<UObject>  SupportedClass;
		
		/// <summary>
		/// The root scope of objects to be exported, only used if PPF_ExportsNotFullyQualfied is set
		/// Objects being exported that are contained within ExportRootScope will use just their name instead of a full path
		/// </summary>
		public UObject ExportRootScope;
		
		/// <summary>Index into FormatExtension/FormatDescription of the preferred export format.</summary>
		public int PreferredFormatIndex;
		
		/// <summary>Current indentation of spaces of the exported text</summary>
		public int TextIndent;
		
		/// <summary>If true, this will export the data as text</summary>
		public bool bText;
		
		/// <summary>If true, this will export only the selected objects</summary>
		public bool bSelectedOnly;
		
		/// <summary>If true, this will force the exporter code to create a file-based Ar (this can keep large output files from taking too much memory)</summary>
		public bool bForceFileOperations;
		
		
	}
	
}
