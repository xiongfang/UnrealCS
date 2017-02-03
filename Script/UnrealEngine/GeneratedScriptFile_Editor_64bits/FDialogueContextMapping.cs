#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FDialogueContextMapping
	{
		/// <summary>The context of the dialogue.</summary>
		[FieldOffset(0)]
		public FDialogueContext Context;
		/// <summary>The soundwave to play for this dialogue.</summary>
		/// <summary>
		/// The format string to use when generating the localization key for this context. This must be unique within the owner dialogue wave.
		/// Available format markers:
		///   * {ContextHash} - A hash generated from the speaker and target voices.
		/// </summary>
		[FieldOffset(32)]
		public FString LocalizationKeyFormat;
		/// <summary>Cached object for playing the soundwave with subtitle information included.</summary>
		
	}
	
}
#endif
#endif
