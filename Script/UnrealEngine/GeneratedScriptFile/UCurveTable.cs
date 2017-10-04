using System;
namespace UnrealEngine
{
	public partial class UCurveTable:UObject
	{
		public UAssetImportData AssetImportData;
		
		/// <summary>The filename imported to create this object. Relative to this object's package, BaseDir() or absolute</summary>
		public FString ImportPath;
		
		
	}
	
}
