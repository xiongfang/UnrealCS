#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=176)]
	public partial struct FFontImportOptionsData
	{
		[FieldOffset(0)]
		public FString FontName;
		[FieldOffset(16)]
		public float Height;
		public bool bEnableAntialiasing
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 1, 1); } }}
			
		}
		public bool bEnableBold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 2, 2); } }}
			
		}
		public bool bEnableItalic
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 4, 4); } }}
			
		}
		public bool bEnableUnderline
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 8, 8); } }}
			
		}
		public bool bAlphaOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 16, 16); } }}
			
		}
		[FieldOffset(24)]
		public EFontImportCharacterSet CharacterSet;
		[FieldOffset(32)]
		public FString Chars;
		[FieldOffset(48)]
		public FString UnicodeRange;
		[FieldOffset(64)]
		public FString CharsFilePath;
		[FieldOffset(80)]
		public FString CharsFileWildcard;
		public bool bCreatePrintableOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 96, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 96, 1, 0, 1, 1); } }}
			
		}
		public bool bIncludeASCIIRange
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 96, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 96, 1, 0, 2, 2); } }}
			
		}
		[FieldOffset(100)]
		public FLinearColor ForegroundColor;
		public bool bEnableDropShadow
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 116, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 116, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(120)]
		public int TexturePageWidth;
		[FieldOffset(124)]
		public int TexturePageMaxHeight;
		[FieldOffset(128)]
		public int XPadding;
		[FieldOffset(132)]
		public int YPadding;
		[FieldOffset(136)]
		public int ExtendBoxTop;
		[FieldOffset(140)]
		public int ExtendBoxBottom;
		[FieldOffset(144)]
		public int ExtendBoxRight;
		[FieldOffset(148)]
		public int ExtendBoxLeft;
		public bool bEnableLegacyMode
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 152, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 152, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(156)]
		public int Kerning;
		public bool bUseDistanceFieldAlpha
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 160, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 160, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(164)]
		public int DistanceFieldScaleFactor;
		[FieldOffset(168)]
		public float DistanceFieldScanRadiusScale;
		
	}
	
}
#endif
#endif
