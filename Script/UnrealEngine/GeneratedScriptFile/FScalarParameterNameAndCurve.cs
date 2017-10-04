using System;
namespace UnrealEngine
{
	/// <summary>Structure representing an animated scalar parameter and it's associated animation curve.</summary>
	public partial struct FScalarParameterNameAndCurve
	{
		/// <summary>The name of the scalar parameter which is being animated.</summary>
		public FName ParameterName;
		public int Index;
		/// <summary>The curve which contains the animation data for the scalar parameter.</summary>
		public FRichCurve ParameterCurve;
		
	}
	
}
