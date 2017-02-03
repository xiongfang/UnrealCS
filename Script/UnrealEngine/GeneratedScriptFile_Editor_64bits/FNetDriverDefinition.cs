#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Container for describing various types of netdrivers available to the engine
	/// The engine will try to construct a netdriver of a given type and, failing that,
	/// the fallback version.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FNetDriverDefinition
	{
		/// <summary>Unique name of this net driver definition</summary>
		[FieldOffset(0)]
		public FName DefName;
		/// <summary>Class name of primary net driver</summary>
		[FieldOffset(12)]
		public FName DriverClassName;
		/// <summary>Class name of the fallback net driver if the main net driver class fails to initialize</summary>
		[FieldOffset(24)]
		public FName DriverClassNameFallback;
		
	}
	
}
#endif
#endif
