#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=148)]
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
		[FieldOffset(20)]
		public EFontImportCharacterSet CharacterSet;
		[FieldOffset(24)]
		public FString Chars;
		[FieldOffset(36)]
		public FString UnicodeRange;
		[FieldOffset(48)]
		public FString CharsFilePath;
		[FieldOffset(60)]
		public FString CharsFileWildcard;
		public bool bCreatePrintableOnly
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 72, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 72, 1, 0, 1, 1); } }}
			
		}
		public bool bIncludeASCIIRange
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 72, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 72, 1, 0, 2, 2); } }}
			
		}
		[FieldOffset(76)]
		public FLinearColor ForegroundColor;
		public bool bEnableDropShadow
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 92, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 92, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(96)]
		public int TexturePageWidth;
		[FieldOffset(100)]
		public int TexturePageMaxHeight;
		[FieldOffset(104)]
		public int XPadding;
		[FieldOffset(108)]
		public int YPadding;
		[FieldOffset(112)]
		public int ExtendBoxTop;
		[FieldOffset(116)]
		public int ExtendBoxBottom;
		[FieldOffset(120)]
		public int ExtendBoxRight;
		[FieldOffset(124)]
		public int ExtendBoxLeft;
		public bool bEnableLegacyMode
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 128, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 128, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(132)]
		public int Kerning;
		public bool bUseDistanceFieldAlpha
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 136, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 136, 1, 0, 1, 1); } }}
			
		}
		[FieldOffset(140)]
		public int DistanceFieldScaleFactor;
		[FieldOffset(144)]
		public float DistanceFieldScanRadiusScale;
		
	}
	
}
#endif
#endif
