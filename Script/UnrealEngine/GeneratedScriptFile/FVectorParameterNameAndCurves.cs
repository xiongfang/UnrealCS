using System;
namespace UnrealEngine
{
	/// <summary>Structure representing an animated vector parameter and it's associated animation curve.</summary>
	public partial struct FVectorParameterNameAndCurves
	{
		/// <summary>The name of the vector parameter which is being animated.</summary>
		public FName ParameterName;
		public int Index;
		/// <summary>The curve which contains the animation data for the x component of the vector parameter.</summary>
		public FRichCurve XCurve;
		/// <summary>The curve which contains the animation data for the y component of the vector parameter.</summary>
		public FRichCurve YCurve;
		/// <summary>The curve which contains the animation data for the z component of the vector parameter.</summary>
		public FRichCurve ZCurve;
		
	}
	
}
