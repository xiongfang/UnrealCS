#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Memory layout optimized primarily for speed of searching the applicable ranges</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FMovieSceneEvaluationField
	{
		/// <summary>Ranges stored separately for fast (cache efficient) lookup. Each index has a corresponding entry in FMovieSceneEvaluationField::Groups.</summary>
		public TStructArray<FFloatRange> Ranges
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FFloatRange>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>Groups that store segment pointers for each of the above ranges. Each index has a corresponding entry in FMovieSceneEvaluationField::Ranges.</summary>
		public TStructArray<FMovieSceneEvaluationGroup> Groups
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneEvaluationGroup>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>Meta data that maps to entries in the 'Ranges' array.</summary>
		public TStructArray<FMovieSceneEvaluationMetaData> MetaData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneEvaluationMetaData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
