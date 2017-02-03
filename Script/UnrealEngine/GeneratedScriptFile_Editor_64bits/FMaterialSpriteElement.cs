#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FMaterialSpriteElement
	{
		/// <summary>The material that the sprite is rendered with.</summary>
		/// <summary>A curve that maps distance on the X axis to the sprite opacity on the Y axis.</summary>
		/// <summary>Whether the size is defined in screen-space or world-space.</summary>
		public bool bSizeIsInScreenSpace
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 1); } }}
			
		}
		/// <summary>The base width of the sprite, multiplied with the DistanceToSizeCurve.</summary>
		[FieldOffset(20)]
		public float BaseSizeX;
		/// <summary>The base height of the sprite, multiplied with the DistanceToSizeCurve.</summary>
		[FieldOffset(24)]
		public float BaseSizeY;
		/// <summary>A curve that maps distance on the X axis to the sprite size on the Y axis.</summary>
		
	}
	
}
#endif
#endif
