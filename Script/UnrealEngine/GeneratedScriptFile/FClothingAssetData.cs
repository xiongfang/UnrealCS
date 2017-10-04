using System;
namespace UnrealEngine
{
	public partial struct FClothingAssetData
	{
		/// <summary>User-defined asset name</summary>
		public FName AssetName;
		public FString ApexFileName;
		/// <summary>the flag whether cloth physics properties are changed from UE4 editor or not</summary>
		public bool bClothPropertiesChanged;
		public FClothPhysicsProperties PhysicsProperties;
		
	}
	
}
