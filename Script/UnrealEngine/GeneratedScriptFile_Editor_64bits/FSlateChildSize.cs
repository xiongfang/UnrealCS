#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A struct exposing size param related properties to UMG.</summary>
	[StructLayout(LayoutKind.Explicit,Size=8)]
	public partial struct FSlateChildSize
	{
		/// <summary>The parameter of the size rule.</summary>
		[FieldOffset(0)]
		public float Value;
		/// <summary>The sizing rule of the content.</summary>
		[FieldOffset(4)]
		public ESlateSizeRule SizeRule;
		
	}
	
}
#endif
#endif
