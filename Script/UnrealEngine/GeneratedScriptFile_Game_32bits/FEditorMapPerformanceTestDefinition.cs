#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FEditorMapPerformanceTestDefinition
	{
		[FieldOffset(0)]
		public FStringAssetReference PerformanceTestmap;
		[FieldOffset(12)]
		public int TestTimer;
		
	}
	
}
#endif
#endif
