#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=152)]
	public partial struct FMovieSceneSkeletalAnimationParams
	{
		/// <summary>The animation this section plays</summary>
		/// <summary>The offset into the beginning of the animation clip</summary>
		[FieldOffset(8)]
		public float StartOffset;
		/// <summary>The offset into the end of the animation clip</summary>
		[FieldOffset(12)]
		public float EndOffset;
		/// <summary>The playback rate of the animation clip</summary>
		[FieldOffset(16)]
		public float PlayRate;
		/// <summary>Reverse the playback of the animation clip</summary>
		public bool bReverse
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 20, 1, 0, 1, 1); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 20, 1, 0, 1, 1); } }}
			
		}
		/// <summary>The slot name to use for the animation</summary>
		[FieldOffset(24)]
		public FName SlotName;
		/// <summary>The weight curve for this animation section</summary>
		[FieldOffset(40)]
		public FRichCurve Weight;
		
	}
	
}
#endif
#endif
