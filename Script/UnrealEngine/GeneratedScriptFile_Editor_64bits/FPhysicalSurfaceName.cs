#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure that represents the name of physical surfaces.</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FPhysicalSurfaceName
	{
		[FieldOffset(0)]
		public EPhysicalSurface Type;
		[FieldOffset(4)]
		public FName Name;
		
	}
	
}
#endif
#endif
