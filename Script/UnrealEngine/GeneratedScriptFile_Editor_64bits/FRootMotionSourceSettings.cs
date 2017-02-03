#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Structure for RootMotionSource option flags
	/// (used for convenience instead of having to manually manipulate flag bitfields)
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=1)]
	public partial struct FRootMotionSourceSettings
	{
		[FieldOffset(0)]
		public byte Flags;
		
	}
	
}
#endif
#endif
