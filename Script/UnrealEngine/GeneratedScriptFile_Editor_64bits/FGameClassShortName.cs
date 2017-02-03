#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Configurable shortened aliases for GameMode classes.  For convenience when typing urls, for instance.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FGameClassShortName
	{
		/// <summary>Abbreviation that can be used as an alias for the class name</summary>
		[FieldOffset(0)]
		public FString ShortName;
		/// <summary>The class name to use when the alias is specified in a URL</summary>
		[FieldOffset(16)]
		public FString GameClassName;
		
	}
	
}
#endif
#endif
