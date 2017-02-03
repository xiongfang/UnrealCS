#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSupportedAreaData
	{
		[FieldOffset(0)]
		public FString AreaClassName;
		[FieldOffset(16)]
		public int AreaID;
		
	}
	
}
#endif
#endif
