#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SProgressBar</summary>
	[StructLayout(LayoutKind.Explicit,Size=464)]
	public partial struct FProgressBarStyle
	{
		/// <summary>Background image to use for the progress bar</summary>
		[FieldOffset(8)]
		public FSlateBrush BackgroundImage;
		/// <summary>Foreground image to use for the progress bar</summary>
		[FieldOffset(160)]
		public FSlateBrush FillImage;
		/// <summary>Image to use for marquee mode</summary>
		[FieldOffset(312)]
		public FSlateBrush MarqueeImage;
		
	}
	
}
#endif
#endif
