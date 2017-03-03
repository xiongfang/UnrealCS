#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1136)]
	public partial struct FTransformCurve
	{
		[FieldOffset(32)]
		public FVectorCurve TranslationCurve;
		[FieldOffset(400)]
		public FVectorCurve RotationCurve;
		[FieldOffset(768)]
		public FVectorCurve ScaleCurve;
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
