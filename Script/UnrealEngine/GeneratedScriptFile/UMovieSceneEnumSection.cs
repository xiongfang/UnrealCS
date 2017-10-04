using System;
namespace UnrealEngine
{
	public partial class UMovieSceneEnumSection:UMovieSceneSection
	{
		/// <summary>
		/// Ordered curve data // @todo Sequencer This could be optimized by packing the enums separately
		/// // but that may not be worth the effort
		/// </summary>
		public FIntegralCurve EnumCurve;
		
		
	}
	
}
