using System;
namespace UnrealEngine
{
	public partial class UMovieScene3DPathSection:UMovieScene3DConstraintSection
	{
		/// <summary>Timing Curve</summary>
		public FRichCurve TimingCurve;
		
		/// <summary>Follow Curve</summary>
		public bool bFollow;
		
		/// <summary>Reverse Timing</summary>
		public bool bReverse;
		
		/// <summary>Force Upright</summary>
		public bool bForceUpright;
		
		
	}
	
}
