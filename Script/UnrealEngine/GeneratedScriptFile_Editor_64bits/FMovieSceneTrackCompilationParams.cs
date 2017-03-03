#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Movie scene compilation parameters. Serialized items contribute to a compiled template's cached hash</summary>
	[StructLayout(LayoutKind.Explicit,Size=1)]
	public partial struct FMovieSceneTrackCompilationParams
	{
		/// <summary>Whether we're generating for an editor preview, or for efficient runtime evaluation</summary>
		public bool bForEditorPreview
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
