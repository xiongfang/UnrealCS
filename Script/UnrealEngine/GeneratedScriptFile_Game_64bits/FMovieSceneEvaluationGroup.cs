#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FMovieSceneEvaluationGroup
	{
		public TStructArray<FMovieSceneEvaluationGroupLUTIndex> LUTIndices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneEvaluationGroupLUTIndex>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		public TStructArray<FMovieSceneEvaluationFieldSegmentPtr> SegmentPtrLUT
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneEvaluationFieldSegmentPtr>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		
	}
	
}
#endif
#endif
