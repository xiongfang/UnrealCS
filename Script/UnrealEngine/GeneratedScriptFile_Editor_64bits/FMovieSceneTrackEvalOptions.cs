#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Generic evaluation options for any track</summary>
	[StructLayout(LayoutKind.Explicit,Size=4)]
	public partial struct FMovieSceneTrackEvalOptions
	{
		/// <summary>true when the value of bEvaluateNearestSection is to be considered for the track</summary>
		public bool bCanEvaluateNearestSection
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 1, 1); } }}
			
		}
		/// <summary>When evaluating empty space on a track, will evaluate the last position of the previous section (if possible), or the first position of the next section, in that order of preference.</summary>
		public bool bEvaluateNearestSection
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 2, 2); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 2, 2); } }}
			
		}
		/// <summary>Evaluate this track as part of its parent sub-section's pre-roll, if applicable</summary>
		public bool bEvaluateInPreroll
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 4, 4); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 4, 4); } }}
			
		}
		/// <summary>Evaluate this track as part of its parent sub-section's post-roll, if applicable</summary>
		public bool bEvaluateInPostroll
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 0, 1, 0, 8, 8); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 0, 1, 0, 8, 8); } }}
			
		}
		
	}
	
}
#endif
#endif
