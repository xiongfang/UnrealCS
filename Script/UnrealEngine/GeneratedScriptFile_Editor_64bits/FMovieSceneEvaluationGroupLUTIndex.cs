#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Lookup table index for a group of evaluation templates</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FMovieSceneEvaluationGroupLUTIndex
	{
		/// <summary>Whether this group requires a flush of the execution stack immediately or not (generally false)</summary>
		public bool bRequiresImmediateFlush
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		/// <summary>The offset within FMovieSceneEvaluationGroup::SegmentPtrLUT that this index starts</summary>
		[FieldOffset(4)]
		public int LUTOffset;
		/// <summary>The number of initialization pointers are stored after &FMovieSceneEvaluationGroup::SegmentPtrLUT[0] + LUTOffset.</summary>
		[FieldOffset(8)]
		public int NumInitPtrs;
		/// <summary>The number of evaluation pointers are stored after &FMovieSceneEvaluationGroup::SegmentPtrLUT[0] + LUTOffset + NumInitPtrs.</summary>
		[FieldOffset(12)]
		public int NumEvalPtrs;
		
	}
	
}
#endif
#endif
