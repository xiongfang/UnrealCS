using System;
namespace UnrealEngine
{
	public partial struct FVectorCurve
	{
		/// <summary>Curve data for float.</summary>
		public FRichCurve FloatCurves;
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
