#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=36)]
	public partial struct FMovieSceneEvaluationField
	{
		public TStructArray<FFloatRange> Ranges
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FFloatRange>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		public TStructArray<FMovieSceneEvaluationGroup> Groups
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneEvaluationGroup>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+12, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+12, false);}}}
			
		}
		public TStructArray<FMovieSceneEvaluationMetaData> MetaData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneEvaluationMetaData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+24, false);}}}
			
		}
		
	}
	
}
#endif
#endif
