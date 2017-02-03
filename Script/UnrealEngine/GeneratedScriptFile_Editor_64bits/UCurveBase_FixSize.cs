#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines a curve of interpolated points to evaluate over a given range</summary>
	public partial class UCurveBase
	{
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
		
		static UCurveBase()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CurveBase");
			AssetImportData__Offset=GetPropertyOffset(NativeClassPtr,"AssetImportData");
			ImportPath__Offset=GetPropertyOffset(NativeClassPtr,"ImportPath");
			
		}
		
	}
	
}
#endif
#endif
