using System;
namespace UnrealEngine
{
	public partial class UCurveBase:UObject
	{
		/// <summary>Get the value range across all curves</summary>
		public extern void GetValueRange(out float MinValue,out float MaxValue);
		/// <summary>Get the time range across all curves</summary>
		public extern void GetTimeRange(out float MinTime,out float MaxTime);
		public UAssetImportData AssetImportData;
		
		/// <summary>The filename imported to create this object. Relative to this object's package, BaseDir() or absolute</summary>
		public FString ImportPath;
		
		
	}
	
}
