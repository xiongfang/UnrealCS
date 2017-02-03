#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A string class reference</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FStringClassReference
	{
		[FieldOffset(0)]
		public FString AssetLongPathname;
		
	}
	
}
#endif
#endif
