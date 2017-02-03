#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FImportFactorySettingValues
	{
		[FieldOffset(0)]
		public FString SettingName;
		[FieldOffset(16)]
		public FString Value;
		
	}
	
}
#endif
#endif
