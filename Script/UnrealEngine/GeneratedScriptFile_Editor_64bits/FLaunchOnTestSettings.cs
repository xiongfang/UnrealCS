#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the editor Launch On With Map Iterations test.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FLaunchOnTestSettings
	{
		/// <summary>Map to be used for the Launch On test *</summary>
		[FieldOffset(0)]
		public FFilePath LaunchOnTestmap;
		/// <summary>This is the device to be used for launch on. Example: WindowsNoEditor, Android, IOS, Linux</summary>
		[FieldOffset(16)]
		public FString DeviceID;
		
	}
	
}
#endif
#endif
