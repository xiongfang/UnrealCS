#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FLocalizedSubtitle
	{
		[FieldOffset(0)]
		public FString LanguageExt;
		public TStructArray<FSubtitleCue> Subtitles
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FSubtitleCue>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+12, false);}}}
			
		}
		public bool bMature
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 1); } }}
			
		}
		public bool bManualWordWrap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 2, 2); } }}
			
		}
		public bool bSingleLine
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 4, 4); } }}
			
		}
		
	}
	
}
#endif
#endif
