#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>todo: Make this class better suited to multiple import paths - maybe have FAssetImportInfo use a map rather than array?</summary>
	public partial class UAssetImportData
	{
		static readonly int SourceFilePath__Offset;
		/// <summary>Path to the resource used to construct this static mesh. Relative to the object's package, BaseDir() or absolute</summary>
		public FString SourceFilePath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFilePath__Offset, typeof(FString));}
			
		}
		
		static readonly int SourceFileTimestamp__Offset;
		/// <summary>Date/Time-stamp of the file from the last import</summary>
		public FString SourceFileTimestamp
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFileTimestamp__Offset, typeof(FString));}
			
		}
		
		static readonly int SourceData__Offset;
		/// <summary>Source file data describing the files that were used to import this asset.</summary>
		public FAssetImportInfo SourceData
		{
			get{ CheckIsValid();return (FAssetImportInfo)Marshal.PtrToStructure(_this.Get()+SourceData__Offset, typeof(FAssetImportInfo));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SourceData__Offset, false);}
			
		}
		
		static UAssetImportData()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AssetImportData");
			SourceFilePath__Offset=GetPropertyOffset(NativeClassPtr,"SourceFilePath");
			SourceFileTimestamp__Offset=GetPropertyOffset(NativeClassPtr,"SourceFileTimestamp");
			SourceData__Offset=GetPropertyOffset(NativeClassPtr,"SourceData");
			
		}
		
	}
	
}
#endif
#endif
