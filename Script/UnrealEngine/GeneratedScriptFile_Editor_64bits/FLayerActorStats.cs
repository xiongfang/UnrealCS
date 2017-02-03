#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FLayerActorStats
	{
		/// <summary>A Type of Actor currently associated with the Layer</summary>
		/// <summary>The total number of Actors of Type assigned to the Layer</summary>
		[FieldOffset(8)]
		public int Total;
		
	}
	
}
#endif
#endif
