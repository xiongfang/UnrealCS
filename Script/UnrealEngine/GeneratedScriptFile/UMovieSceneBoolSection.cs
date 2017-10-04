using System;
namespace UnrealEngine
{
	public partial class UMovieSceneBoolSection:UMovieSceneSection
	{
		/// <summary>The default value to use when no keys are present - use GetCurve().SetDefaultValue()</summary>
		public bool DefaultValue;
		
		/// <summary>
		/// Ordered curve data // @todo Sequencer This could be optimized by packing the bools separately
		/// // but that may not be worth the effort
		/// </summary>
		public FIntegralCurve BoolCurve;
		
		
	}
	
}
