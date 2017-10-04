using System;
namespace UnrealEngine
{
	/// <summary>Holds settings for the editor Launch On With Map Iterations test.</summary>
	public partial struct FLaunchOnTestSettings
	{
		/// <summary>Map to be used for the Launch On test *</summary>
		public FFilePath LaunchOnTestmap;
		/// <summary>This is the device to be used for launch on. Example: WindowsNoEditor, Android, IOS, Linux</summary>
		public FString DeviceID;
		
	}
	
}
