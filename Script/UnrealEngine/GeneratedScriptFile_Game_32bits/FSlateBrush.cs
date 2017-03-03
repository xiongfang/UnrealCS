#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=116)]
	public partial struct FSlateBrush
	{
		[FieldOffset(4)]
		public FVector2D ImageSize;
		[FieldOffset(12)]
		public ESlateBrushDrawType DrawAs;
		[FieldOffset(16)]
		public FMargin Margin;
		[FieldOffset(32)]
		public FLinearColor Tint;
		[FieldOffset(48)]
		public FSlateColor TintColor;
		[FieldOffset(76)]
		public ESlateBrushTileType Tiling;
		[FieldOffset(77)]
		public ESlateBrushMirrorType Mirroring;
		[FieldOffset(78)]
		public ESlateBrushImageType ImageType;
		[FieldOffset(84)]
		public FName ResourceName;
		public bool bIsDynamicallyLoaded
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 92, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 92, 1, 0, 1, 255); } }}
			
		}
		public bool bHasUObject
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 93, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 93, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(96)]
		public FBox2D UVRegion;
		
	}
	
}
#endif
#endif
