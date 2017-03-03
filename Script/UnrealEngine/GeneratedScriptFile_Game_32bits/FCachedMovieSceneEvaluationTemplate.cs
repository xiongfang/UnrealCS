#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=404)]
	public partial struct FCachedMovieSceneEvaluationTemplate
	{
		[FieldOffset(120)]
		public FMovieSceneEvaluationField EvaluationField;
		[FieldOffset(156)]
		public FMovieSceneSequenceHierarchy Hierarchy;
		[FieldOffset(276)]
		public FMovieSceneGenerationLedger Ledger;
		public bool bHasLegacyTrackInstances
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 400, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 400, 1, 0, 1, 1); } }}
			
		}
		public bool bKeepStaleTracks
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 400, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 400, 1, 0, 2, 2); } }}
			
		}
		
	}
	
}
#endif
#endif
