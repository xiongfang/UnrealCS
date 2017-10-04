using System;
namespace UnrealEngine
{
	public partial class UMovieScene2DTransformSection:UMovieSceneSection
	{
		/// <summary>Translation curves</summary>
		public FRichCurve Translation;
		
		/// <summary>Rotation curve</summary>
		public FRichCurve Rotation;
		
		/// <summary>Scale curves</summary>
		public FRichCurve Scale;
		
		/// <summary>Shear curve</summary>
		public FRichCurve Shear;
		
		
	}
	
}
