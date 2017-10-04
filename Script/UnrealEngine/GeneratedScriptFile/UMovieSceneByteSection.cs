using System;
namespace UnrealEngine
{
	public partial class UMovieSceneByteSection:UMovieSceneSection
	{
		/// <summary>
		/// Ordered curve data // @todo Sequencer This could be optimized by packing the bytes separately
		/// // but that may not be worth the effort
		/// </summary>
		public FIntegralCurve ByteCurve;
		
		
	}
	
}
