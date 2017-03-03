#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Informational meta data that applies to a given time range</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FMovieSceneEvaluationMetaData
	{
		/// <summary>Array of sequences that are active in this time range.</summary>
		public TStructArray<FMovieSceneSequenceID> ActiveSequences
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FMovieSceneSequenceID>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
