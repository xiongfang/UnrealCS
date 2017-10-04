using System;
namespace UnrealEngine
{
	public partial struct FTransformCurve
	{
		/// <summary>Curve data for each transform.</summary>
		public FVectorCurve TranslationCurve;
		/// <summary>
		/// Rotation curve - right now we use euler because quat also doesn't provide linear interpolation - curve editor can't handle quat interpolation
		/// If you hit gimbal lock, you should add extra key to fix it. This will cause gimbal lock.
		/// @TODO: Eventually we'll need FRotationCurve that would contain rotation curve - that will interpolate as slerp or as quaternion
		/// </summary>
		public FVectorCurve RotationCurve;
		public FVectorCurve ScaleCurve;
		/// <summary>
		/// Last observed name of the curve. We store this so we can recover from situations that
		/// mean the skeleton doesn't have a mapped name for our UID (such as a user saving the an
		/// animation but not the skeleton).
		/// </summary>
		public FName LastObservedName;
		public FSmartName Name;
		/// <summary>Curve Type Flags</summary>
		public int CurveTypeFlags;
		
	}
	
}
