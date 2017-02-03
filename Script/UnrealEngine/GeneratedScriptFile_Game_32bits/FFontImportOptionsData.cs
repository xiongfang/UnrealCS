#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FFontImportOptionsData
	{
		[FieldOffset(0)]
		public FString FontName;
		[FieldOffset(12)]
		public float Height;
		public bool bEnableAntialiasing
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		public bool bEnableBold
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 2, 2); } }}
			
		}
		public bool bEnableItalic
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 4, 4); } }}
			
		}
		public bool bEnableUnderline
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 8, 8); } }}
			
		}
		public bool bAlphaOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 16, 16); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 16, 16); } }}
			
		}
		[FieldOffset(17)]
		public EFontImportCharacterSet CharacterSet;
		[FieldOffset(20)]
		public FString Chars;
		[FieldOffset(32)]
		public FString UnicodeRange;
		[FieldOffset(44)]
		public FString CharsFilePath;
		[FieldOffset(56)]
		public FString CharsFileWildcard;
		public bool bCreatePrintableOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 68, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 68, 1, 0, 1, 1); } }}
			
		}
		public bool bIncludeASCIIRange
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 68, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 68, 1, 0, 2, 2); } }}
			
		}
		[FieldOffset(72)]
		public FLinearColor ForegroundColor;
		public bool bEnableDropShadow
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 88, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 88, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(92)]
		public int TexturePageWidth;
		[FieldOffset(96)]
		public int TexturePageMaxHeight;
		[FieldOffset(100)]
		public int XPadding;
		[FieldOffset(104)]
		public int YPadding;
		[FieldOffset(108)]
		public int ExtendBoxTop;
		[FieldOffset(112)]
		public int ExtendBoxBottom;
		[FieldOffset(116)]
		public int ExtendBoxRight;
		[FieldOffset(120)]
		public int ExtendBoxLeft;
		public bool bEnableLegacyMode
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 124, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 124, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(128)]
		public int Kerning;
		public bool bUseDistanceFieldAlpha
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 132, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 132, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(136)]
		public int DistanceFieldScaleFactor;
		[FieldOffset(140)]
		public float DistanceFieldScanRadiusScale;
		
	}
	
}
#endif
#endif
