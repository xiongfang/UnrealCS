#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FImportFactorySettingValues
	{
		[FieldOffset(0)]
		public FString SettingName;
		[FieldOffset(12)]
		public FString Value;
		
	}
	
}
#endif
#endif
