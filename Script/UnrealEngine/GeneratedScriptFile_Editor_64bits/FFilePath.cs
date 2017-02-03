#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure for file paths that are displayed in the UI.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FFilePath
	{
		/// <summary>The path to the file.</summary>
		[FieldOffset(0)]
		public FString FilePath;
		
	}
	
}
#endif
#endif
