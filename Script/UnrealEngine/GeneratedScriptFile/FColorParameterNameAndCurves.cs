using System;
namespace UnrealEngine
{
	/// <summary>Structure representing an animated vector parameter and it's associated animation curve.</summary>
	public partial struct FColorParameterNameAndCurves
	{
		/// <summary>The name of the vector parameter which is being animated.</summary>
		public FName ParameterName;
		public int Index;
		/// <summary>The curve which contains the animation data for the red component of the color parameter.</summary>
		public FRichCurve RedCurve;
		/// <summary>The curve which contains the animation data for the green component of the color parameter.</summary>
		public FRichCurve GreenCurve;
		/// <summary>The curve which contains the animation data for the blue component of the color parameter.</summary>
		public FRichCurve BlueCurve;
		/// <summary>The curve which contains the animation data for the alpha component of the color parameter.</summary>
		public FRichCurve AlphaCurve;
		
	}
	
}
