#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FAudioQualitySettings
	{
		[FieldOffset(0)]
		public FText DisplayName;
		/// <summary>
		/// The number of audio channels that can be used at once
		/// NOTE: Some platforms may cap this value to a lower setting regardless of what the settings request
		/// </summary>
		[FieldOffset(24)]
		public int MaxChannels;
		
	}
	
}
#endif
#endif
