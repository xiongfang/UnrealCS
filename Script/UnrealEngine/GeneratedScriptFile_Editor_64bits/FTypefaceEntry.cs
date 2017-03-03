#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A single entry in a typeface</summary>
	[StructLayout(LayoutKind.Explicit,Size=72)]
	public partial struct FTypefaceEntry
	{
		/// <summary>Name used to identify this font within its typeface</summary>
		[FieldOffset(0)]
		public FName Name;
		/// <summary>Raw font data for this font</summary>
		[FieldOffset(16)]
		public FFontData Font;
		
	}
	
}
#endif
#endif
