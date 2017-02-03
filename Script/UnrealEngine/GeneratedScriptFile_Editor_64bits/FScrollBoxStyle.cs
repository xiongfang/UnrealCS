#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SScrollBox</summary>
	[StructLayout(LayoutKind.Explicit,Size=616)]
	public partial struct FScrollBoxStyle
	{
		/// <summary>Brush used to draw the top shadow of a scrollbox</summary>
		[FieldOffset(8)]
		public FSlateBrush TopShadowBrush;
		/// <summary>Brush used to draw the bottom shadow of a scrollbox</summary>
		[FieldOffset(160)]
		public FSlateBrush BottomShadowBrush;
		/// <summary>Brush used to draw the left shadow of a scrollbox</summary>
		[FieldOffset(312)]
		public FSlateBrush LeftShadowBrush;
		/// <summary>Brush used to draw the right shadow of a scrollbox</summary>
		[FieldOffset(464)]
		public FSlateBrush RightShadowBrush;
		
	}
	
}
#endif
#endif
