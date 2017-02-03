#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FNetDriverDefinition
	{
		[FieldOffset(0)]
		public FName DefName;
		[FieldOffset(8)]
		public FName DriverClassName;
		[FieldOffset(16)]
		public FName DriverClassNameFallback;
		
	}
	
}
#endif
#endif
