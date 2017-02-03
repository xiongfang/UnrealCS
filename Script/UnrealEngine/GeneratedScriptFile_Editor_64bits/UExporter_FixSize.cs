#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UExporter
	{
		static readonly int SupportedClass__Offset;
		/// <summary>Supported class of this exporter</summary>
		public TSubclassOf<UObject>  SupportedClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SupportedClass__Offset); return v; }
			
		}
		
		static readonly int ExportRootScope__Offset;
		/// <summary>
		/// The root scope of objects to be exported, only used if PPF_ExportsNotFullyQualfied is set
		/// Objects being exported that are contained within ExportRootScope will use just their name instead of a full path
		/// </summary>
		public UObject ExportRootScope
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ExportRootScope__Offset); if (v == IntPtr.Zero)return null; UObject retValue = new UObject(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int FormatExtension__Offset;
		/// <summary>File extension to use for this exporter</summary>
		public TStructArray<FString> FormatExtension
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FormatExtension__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FormatExtension__Offset, false);}
			
		}
		
		static readonly int FormatDescription__Offset;
		/// <summary>Descriptiong of the export format</summary>
		public TStructArray<FString> FormatDescription
		{
			get{ CheckIsValid();return new TStructArray<FString>((FScriptArray)Marshal.PtrToStructure(_this.Get()+FormatDescription__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+FormatDescription__Offset, false);}
			
		}
		
		static readonly int PreferredFormatIndex__Offset;
		/// <summary>Index into FormatExtension/FormatDescription of the preferred export format.</summary>
		public int PreferredFormatIndex
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreferredFormatIndex__Offset, typeof(int));}
			
		}
		
		static readonly int TextIndent__Offset;
		/// <summary>Current indentation of spaces of the exported text</summary>
		public int TextIndent
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TextIndent__Offset, typeof(int));}
			
		}
		
		static readonly int bText__Offset;
		/// <summary>If true, this will export the data as text</summary>
		public bool bText
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bText__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bSelectedOnly__Offset;
		/// <summary>If true, this will export only the selected objects</summary>
		public bool bSelectedOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSelectedOnly__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bForceFileOperations__Offset;
		/// <summary>If true, this will force the exporter code to create a file-based Ar (this can keep large output files from taking too much memory)</summary>
		public bool bForceFileOperations
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceFileOperations__Offset, 1, 0, 4, 4);}
			
		}
		
		static UExporter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Exporter");
			SupportedClass__Offset=GetPropertyOffset(NativeClassPtr,"SupportedClass");
			ExportRootScope__Offset=GetPropertyOffset(NativeClassPtr,"ExportRootScope");
			FormatExtension__Offset=GetPropertyOffset(NativeClassPtr,"FormatExtension");
			FormatDescription__Offset=GetPropertyOffset(NativeClassPtr,"FormatDescription");
			PreferredFormatIndex__Offset=GetPropertyOffset(NativeClassPtr,"PreferredFormatIndex");
			TextIndent__Offset=GetPropertyOffset(NativeClassPtr,"TextIndent");
			bText__Offset=GetPropertyOffset(NativeClassPtr,"bText");
			bSelectedOnly__Offset=GetPropertyOffset(NativeClassPtr,"bSelectedOnly");
			bForceFileOperations__Offset=GetPropertyOffset(NativeClassPtr,"bForceFileOperations");
			
		}
		
	}
	
}
#endif
#endif
