#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Helper structure, used to associate GameModes for a map via its filename prefix.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FGameModePrefix
	{
		/// <summary>map prefix, e.g. "DM"</summary>
		[FieldOffset(0)]
		public FString Prefix;
		/// <summary>GameMode used if none specified on the URL</summary>
		[FieldOffset(16)]
		public FString GameMode;
		
	}
	
}
#endif
#endif
