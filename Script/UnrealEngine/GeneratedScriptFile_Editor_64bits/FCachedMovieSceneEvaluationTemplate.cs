#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=584)]
	public partial struct FCachedMovieSceneEvaluationTemplate
	{
		[FieldOffset(560)]
		public FMovieSceneTrackCompilationParams CachedCompilationParams;
		public TStructArray<FMovieSceneSequenceCachedSignature> CachedSignatures
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneSequenceCachedSignature>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+568, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+568, false);}}}
			
		}
		/// <summary>Evaluation field for efficient runtime evaluation</summary>
		[FieldOffset(160)]
		public FMovieSceneEvaluationField EvaluationField;
		/// <summary>Map of all sequences found in this template (recursively)</summary>
		[FieldOffset(208)]
		public FMovieSceneSequenceHierarchy Hierarchy;
		[FieldOffset(368)]
		public FMovieSceneGenerationLedger Ledger;
		/// <summary>When set, this template contains legacy track instances that require the initialization of a legacy sequence instance</summary>
		public bool bHasLegacyTrackInstances
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 536, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 536, 1, 0, 1, 1); } }}
			
		}
		/// <summary>Primarily used in editor to keep stale tracks around during template regeneration to ensure we can call OnEndEvaluation on them.</summary>
		public bool bKeepStaleTracks
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 536, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 536, 1, 0, 2, 2); } }}
			
		}
		
	}
	
}
#endif
#endif
