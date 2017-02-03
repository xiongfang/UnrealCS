#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FDistanceDatum
	{
		/// <summary>
		/// The FadeInDistance at which to start hearing this sound.
		///        * If you want to hear the sound up close then setting this to 0 might be a good option.
		/// </summary>
		[FieldOffset(0)]
		public float FadeInDistanceStart;
		/// <summary>The distance at which this sound has faded in completely.</summary>
		[FieldOffset(4)]
		public float FadeInDistanceEnd;
		/// <summary>The distance at which this sound starts fading out.</summary>
		[FieldOffset(8)]
		public float FadeOutDistanceStart;
		/// <summary>The distance at which this sound is no longer audible.</summary>
		[FieldOffset(12)]
		public float FadeOutDistanceEnd;
		/// <summary>The volume for which this Input should be played.</summary>
		[FieldOffset(16)]
		public float Volume;
		
	}
	
}
#endif
#endif
