#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SExpandableArea</summary>
	[StructLayout(LayoutKind.Explicit,Size=320)]
	public partial struct FExpandableAreaStyle
	{
		/// <summary>Image to use when the area is collapsed</summary>
		[FieldOffset(8)]
		public FSlateBrush CollapsedImage;
		/// <summary>Image to use when the area is expanded</summary>
		[FieldOffset(160)]
		public FSlateBrush ExpandedImage;
		/// <summary>How long the rollout animation lasts</summary>
		[FieldOffset(312)]
		public float RolloutAnimationSeconds;
		
	}
	
}
#endif
#endif
