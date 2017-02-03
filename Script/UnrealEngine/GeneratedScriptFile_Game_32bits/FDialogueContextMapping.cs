#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FDialogueContextMapping
	{
		[FieldOffset(0)]
		public FDialogueContext Context;
		[FieldOffset(20)]
		public FString LocalizationKeyFormat;
		
	}
	
}
#endif
#endif
