#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Information about the sprite category</summary>
	[StructLayout(LayoutKind.Explicit,Size=64)]
	public partial struct FSpriteCategoryInfo
	{
		/// <summary>Sprite category that the component belongs to</summary>
		[FieldOffset(0)]
		public FName Category;
		/// <summary>Localized name of the sprite category</summary>
		[FieldOffset(16)]
		public FText DisplayName;
		/// <summary>Localized description of the sprite category</summary>
		[FieldOffset(40)]
		public FText Description;
		
	}
	
}
#endif
#endif
