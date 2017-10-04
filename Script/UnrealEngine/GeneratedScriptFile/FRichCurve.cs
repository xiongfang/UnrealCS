using System;
namespace UnrealEngine
{
	/// <summary>A rich, editable float curve</summary>
	public partial struct FRichCurve
	{
		/// <summary>Pre-infinity extrapolation state</summary>
		public ERichCurveExtrapolation PreInfinityExtrap;
		/// <summary>Post-infinity extrapolation state</summary>
		public ERichCurveExtrapolation PostInfinityExtrap;
		/// <summary>Default value</summary>
		public float DefaultValue;
		/// <summary>Map of which key handles go to which indices.</summary>
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
