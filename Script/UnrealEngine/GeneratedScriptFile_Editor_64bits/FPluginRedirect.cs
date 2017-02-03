#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FPluginRedirect
	{
		[FieldOffset(0)]
		public FString OldPluginName;
		[FieldOffset(16)]
		public FString NewPluginName;
		
	}
	
}
#endif
#endif
