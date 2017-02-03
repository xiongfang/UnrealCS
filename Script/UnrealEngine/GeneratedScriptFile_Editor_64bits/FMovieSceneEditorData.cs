#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Editor only data that needs to be saved between sessions for editing but has no runtime purpose</summary>
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FMovieSceneEditorData
	{
		/// <summary>User-defined working range in which the entire sequence should reside.</summary>
		[FieldOffset(80)]
		public FFloatRange WorkingRange;
		/// <summary>The last view-range that the user was observing</summary>
		[FieldOffset(96)]
		public FFloatRange ViewRange;
		
	}
	
}
#endif
#endif
