#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FDialogueContextMapping
	{
		[FieldOffset(0)]
		public FDialogueContext Context;
		[FieldOffset(32)]
		public FString LocalizationKeyFormat;
		
	}
	
}
#endif
#endif
