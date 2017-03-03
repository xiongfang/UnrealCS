#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=544)]
	public partial struct FCachedMovieSceneEvaluationTemplate
	{
		[FieldOffset(160)]
		public FMovieSceneEvaluationField EvaluationField;
		[FieldOffset(208)]
		public FMovieSceneSequenceHierarchy Hierarchy;
		[FieldOffset(368)]
		public FMovieSceneGenerationLedger Ledger;
		public bool bHasLegacyTrackInstances
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 536, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 536, 1, 0, 1, 1); } }}
			
		}
		public bool bKeepStaleTracks
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 536, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 536, 1, 0, 2, 2); } }}
			
		}
		
	}
	
}
#endif
#endif
