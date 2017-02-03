#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Imported spreadsheet table.</summary>
	public partial class UDataTable
	{
		static readonly int RowStruct__Offset;
		/// <summary>Structure to use for each row of the table, must inherit from FTableRowBase</summary>
		public UScriptStruct RowStruct
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RowStruct__Offset); if (v == IntPtr.Zero)return null; UScriptStruct retValue = new UScriptStruct(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AssetImportData__Offset;
		public UAssetImportData AssetImportData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AssetImportData__Offset); if (v == IntPtr.Zero)return null; UAssetImportData retValue = new UAssetImportData(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, value._this.Get()); }
			
		}
		
		static readonly int ImportPath__Offset;
		/// <summary>The filename imported to create this object. Relative to this object's package, BaseDir() or absolute</summary>
		public FString ImportPath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ImportPath__Offset, typeof(FString));}
			
		}
		
		static readonly int RowStructName__Offset;
		/// <summary>The name of the RowStruct we were using when we were last saved</summary>
		public FName RowStructName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+RowStructName__Offset, typeof(FName));}
			
		}
		
		static UDataTable()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DataTable");
			RowStruct__Offset=GetPropertyOffset(NativeClassPtr,"RowStruct");
			AssetImportData__Offset=GetPropertyOffset(NativeClassPtr,"AssetImportData");
			ImportPath__Offset=GetPropertyOffset(NativeClassPtr,"ImportPath");
			RowStructName__Offset=GetPropertyOffset(NativeClassPtr,"RowStructName");
			
		}
		
	}
	
}
#endif
#endif
