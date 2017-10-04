using System;
namespace UnrealEngine
{
	/// <summary>Lookup table index for a group of evaluation templates</summary>
	public partial struct FMovieSceneEvaluationGroupLUTIndex
	{
		/// <summary>Whether this group requires a flush of the execution stack immediately or not (generally false)</summary>
		public bool bRequiresImmediateFlush;
		/// <summary>The offset within FMovieSceneEvaluationGroup::SegmentPtrLUT that this index starts</summary>
		public int LUTOffset;
		/// <summary>The number of initialization pointers are stored after &FMovieSceneEvaluationGroup::SegmentPtrLUT[0] + LUTOffset.</summary>
		public int NumInitPtrs;
		/// <summary>The number of evaluation pointers are stored after &FMovieSceneEvaluationGroup::SegmentPtrLUT[0] + LUTOffset + NumInitPtrs.</summary>
		public int NumEvalPtrs;
		
	}
	
}
