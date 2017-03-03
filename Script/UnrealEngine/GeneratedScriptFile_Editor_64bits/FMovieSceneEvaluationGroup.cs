#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Holds segment pointers for all segments that are active for a given range of the sequence</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FMovieSceneEvaluationGroup
	{
		/// <summary>Array of indices that define all the flush groups in the range.</summary>
		public TStructArray<FMovieSceneEvaluationGroupLUTIndex> LUTIndices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneEvaluationGroupLUTIndex>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>A grouping of evaluation pointers that occur in this range of the sequence</summary>
		public TStructArray<FMovieSceneEvaluationFieldSegmentPtr> SegmentPtrLUT
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneEvaluationFieldSegmentPtr>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
