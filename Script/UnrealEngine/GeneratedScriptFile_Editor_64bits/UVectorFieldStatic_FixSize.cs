#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UVectorFieldStatic
	{
		static readonly int SizeX__Offset;
		/// <summary>Size of the vector field volume.</summary>
		public int SizeX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeX__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeX__Offset, false);}
			
		}
		
		static readonly int SizeY__Offset;
		/// <summary>Size of the vector field volume.</summary>
		public int SizeY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeY__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeY__Offset, false);}
			
		}
		
		static readonly int SizeZ__Offset;
		/// <summary>Size of the vector field volume.</summary>
		public int SizeZ
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SizeZ__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SizeZ__Offset, false);}
			
		}
		
		static readonly int SourceFilePath__Offset;
		public FString SourceFilePath
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+SourceFilePath__Offset, typeof(FString));}
			
		}
		
		static readonly int AssetImportData__Offset;
		public UAssetImportData AssetImportData
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AssetImportData__Offset); if (v == IntPtr.Zero)return null; UAssetImportData retValue = new UAssetImportData(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + AssetImportData__Offset, value._this.Get()); }
			
		}
		
		static UVectorFieldStatic()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("VectorFieldStatic");
			SizeX__Offset=GetPropertyOffset(NativeClassPtr,"SizeX");
			SizeY__Offset=GetPropertyOffset(NativeClassPtr,"SizeY");
			SizeZ__Offset=GetPropertyOffset(NativeClassPtr,"SizeZ");
			SourceFilePath__Offset=GetPropertyOffset(NativeClassPtr,"SourceFilePath");
			AssetImportData__Offset=GetPropertyOffset(NativeClassPtr,"AssetImportData");
			
		}
		
	}
	
}
#endif
#endif
