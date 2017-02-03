#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FDialogueWaveParameter
	{
		/// <summary>The dialogue wave to play.</summary>
		/// <summary>The context to use for the dialogue wave.</summary>
		[FieldOffset(8)]
		public FDialogueContext Context;
		
	}
	
}
#endif
#endif
