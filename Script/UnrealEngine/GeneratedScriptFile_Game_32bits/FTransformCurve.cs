#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=852)]
	public partial struct FTransformCurve
	{
		[FieldOffset(24)]
		public FVectorCurve TranslationCurve;
		[FieldOffset(300)]
		public FVectorCurve RotationCurve;
		[FieldOffset(576)]
		public FVectorCurve ScaleCurve;
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
