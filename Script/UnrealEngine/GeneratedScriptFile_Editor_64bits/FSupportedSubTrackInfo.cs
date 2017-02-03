#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Helper struct for creating sub tracks supported by this track</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSupportedSubTrackInfo
	{
		/// <summary>The sub track class which is supported by this track</summary>
		/// <summary>The name of the subtrack</summary>
		[FieldOffset(8)]
		public FString SubTrackName;
		/// <summary>Index into the any subtrack group this subtrack belongs to (can be -1 for no group)</summary>
		[FieldOffset(24)]
		public int GroupIndex;
		
	}
	
}
#endif
#endif
