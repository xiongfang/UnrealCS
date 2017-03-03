#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds settings for the asset import / export automation test</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FEditorMapPerformanceTestDefinition
	{
		/// <summary>Map to be used for the Performance Capture *</summary>
		[FieldOffset(0)]
		public FStringAssetReference PerformanceTestmap;
		/// <summary>This is the length of time in seconds that this test will run for before stopping.</summary>
		[FieldOffset(16)]
		public int TestTimer;
		
	}
	
}
#endif
#endif
