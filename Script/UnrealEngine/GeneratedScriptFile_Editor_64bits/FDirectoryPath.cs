#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure for directory paths that are displayed in the UI.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FDirectoryPath
	{
		/// <summary>The path to the directory.</summary>
		[FieldOffset(0)]
		public FString Path;
		
	}
	
}
#endif
#endif
