#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FSlateColor
	{
		[FieldOffset(0)]
		public FLinearColor SpecifiedColor;
		[FieldOffset(16)]
		public ESlateColorStylingMode ColorUseRule;
		
	}
	
}
#endif
#endif
