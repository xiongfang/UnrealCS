#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=368)]
	public partial struct FVectorCurve
	{
		[FieldOffset(32)]
		public FRichCurve FloatCurves;
		[FieldOffset(0)]
		public FName LastObservedName;
		[FieldOffset(8)]
		public FSmartName Name;
		[FieldOffset(24)]
		public int CurveTypeFlags;
		
	}
	
}
#endif
#endif
