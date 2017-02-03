#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A subtitle localized to a specific language.</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FLocalizedSubtitle
	{
		/// <summary>The 3-letter language for this subtitle</summary>
		[FieldOffset(0)]
		public FString LanguageExt;
		/// <summary>
		/// Subtitle cues.  If empty, use SoundNodeWave's SpokenText as the subtitle.  Will often be empty,
		/// as the contents of the subtitle is commonly identical to what is spoken.
		/// </summary>
		public TStructArray<FSubtitleCue> Subtitles
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FSubtitleCue>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>true if this sound is considered to contain mature content.</summary>
		public bool bMature
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 1, 1); } }}
			
		}
		/// <summary>true if the subtitles have been split manually.</summary>
		public bool bManualWordWrap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 2, 2); } }}
			
		}
		/// <summary>true if the subtitles should be displayed one line at a time.</summary>
		public bool bSingleLine
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 32, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 32, 1, 0, 4, 4); } }}
			
		}
		
	}
	
}
#endif
#endif
