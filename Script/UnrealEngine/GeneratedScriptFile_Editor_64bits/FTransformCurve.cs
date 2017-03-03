#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=1200)]
	public partial struct FTransformCurve
	{
		/// <summary>Curve data for each transform.</summary>
		[FieldOffset(48)]
		public FVectorCurve TranslationCurve;
		/// <summary>
		/// Rotation curve - right now we use euler because quat also doesn't provide linear interpolation - curve editor can't handle quat interpolation
		/// If you hit gimbal lock, you should add extra key to fix it. This will cause gimbal lock.
		/// @TODO: Eventually we'll need FRotationCurve that would contain rotation curve - that will interpolate as slerp or as quaternion
		/// </summary>
		[FieldOffset(432)]
		public FVectorCurve RotationCurve;
		[FieldOffset(816)]
		public FVectorCurve ScaleCurve;
		/// <summary>
		/// Last observed name of the curve. We store this so we can recover from situations that
		/// mean the skeleton doesn't have a mapped name for our UID (such as a user saving the an
		/// animation but not the skeleton).
		/// </summary>
		[FieldOffset(0)]
		public FName LastObservedName;
		[FieldOffset(12)]
		public FSmartName Name;
		/// <summary>Curve Type Flags</summary>
		[FieldOffset(44)]
		public int CurveTypeFlags;
		
	}
	
}
#endif
#endif
