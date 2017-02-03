#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Cached camera POV info, stored as optimization so we only
	/// need to do a full camera update once per tick.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=1312)]
	public partial struct FCameraCacheEntry
	{
		/// <summary>World time this entry was created.</summary>
		[FieldOffset(0)]
		public float TimeStamp;
		/// <summary>Camera POV to cache.</summary>
		[FieldOffset(16)]
		public FMinimalViewInfo POV;
		
	}
	
}
#endif
#endif
