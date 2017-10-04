using System;
namespace UnrealEngine
{
	public partial class UDeviceProfile:UTextureLODSettings
	{
		/// <summary>The type of this profile, I.e. IOS, Windows, PS4 etc</summary>
		public FString DeviceType;
		
		/// <summary>The name of the parent profile of this object</summary>
		public FString BaseProfileName;
		
		/// <summary>The parent object of this profile, it is the object matching this DeviceType with the BaseProfileName</summary>
		public UObject Parent;
		
		
	}
	
}
