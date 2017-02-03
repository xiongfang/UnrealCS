#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A string asset reference</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FStringAssetReference
	{
		[FieldOffset(0)]
		public FString AssetLongPathname;
		
	}
	
}
#endif
#endif
