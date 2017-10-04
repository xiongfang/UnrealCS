using System;
namespace UnrealEngine
{
	/// <summary>Sample data</summary>
	public partial struct FBlendSample
	{
		public UAnimSequence Animation;
		/// <summary>blend 0->x, blend 1->y, blend 2->z</summary>
		public FVector SampleValue;
		public float RateScale;
		public bool bIsValid;
		
	}
	
}
