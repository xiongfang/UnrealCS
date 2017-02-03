#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=28)]
	public partial struct FWidgetTransform
	{
		[FieldOffset(0)]
		public FVector2D Translation;
		[FieldOffset(8)]
		public FVector2D Scale;
		[FieldOffset(16)]
		public FVector2D Shear;
		[FieldOffset(24)]
		public float Angle;
		
	}
	
}
#endif
#endif
