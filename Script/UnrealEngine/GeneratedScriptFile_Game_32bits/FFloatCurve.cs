#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=108)]
	public partial struct FFloatCurve
	{
		[FieldOffset(24)]
		public FRichCurve FloatCurve;
		[FieldOffset(0)]
		public FName LastObservedName;
		[FieldOffset(8)]
		public FSmartName Name;
		[FieldOffset(20)]
		public int CurveTypeFlags;
		
	}
	
}
#endif
#endif
