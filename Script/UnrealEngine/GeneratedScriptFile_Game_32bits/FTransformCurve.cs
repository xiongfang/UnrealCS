#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=872)]
	public partial struct FTransformCurve
	{
		[FieldOffset(32)]
		public FVectorCurve TranslationCurve;
		[FieldOffset(312)]
		public FVectorCurve RotationCurve;
		[FieldOffset(592)]
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
