#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FEditorMapPerformanceTestDefinition
	{
		[FieldOffset(0)]
		public FStringAssetReference PerformanceTestmap;
		[FieldOffset(16)]
		public int TestTimer;
		
	}
	
}
#endif
#endif
