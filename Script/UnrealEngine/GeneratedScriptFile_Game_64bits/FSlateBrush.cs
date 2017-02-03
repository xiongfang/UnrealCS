#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FSlateBrush
	{
		[FieldOffset(8)]
		public FVector2D ImageSize;
		[FieldOffset(16)]
		public ESlateBrushDrawType DrawAs;
		[FieldOffset(20)]
		public FMargin Margin;
		[FieldOffset(36)]
		public FLinearColor Tint;
		[FieldOffset(56)]
		public FSlateColor TintColor;
		[FieldOffset(96)]
		public ESlateBrushTileType Tiling;
		[FieldOffset(97)]
		public ESlateBrushMirrorType Mirroring;
		[FieldOffset(98)]
		public ESlateBrushImageType ImageType;
		[FieldOffset(112)]
		public FName ResourceName;
		public bool bIsDynamicallyLoaded
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 120, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 120, 1, 0, 1, 255); } }}
			
		}
		public bool bHasUObject
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 121, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 121, 1, 0, 1, 255); } }}
			
		}
		[FieldOffset(124)]
		public FBox2D UVRegion;
		
	}
	
}
#endif
#endif
