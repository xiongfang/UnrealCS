#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// SoundNodeDistanceCrossFade
	/// This node's purpose is to play different sounds based on the distance to the listener.
	/// The node mixes between the N different sounds which are valid for the distance.  One should
	/// think of a SoundNodeDistanceCrossFade as Mixer node which determines the set of nodes to
	/// "mix in" based on their distance to the sound.
	/// Example:
	/// You have a gun that plays a fire sound.  At long distances you want a different sound than
	/// if you were up close.   So you use a SoundNodeDistanceCrossFade which will calculate the distance
	/// a listener is from the sound and play either:  short distance, long distance, mix of short and long sounds.
	/// A SoundNodeDistanceCrossFade differs from an SoundNodeAttenuation in that any sound is only going
	/// be played if it is within the MinRadius and MaxRadius.  So if you want the short distance sound to be
	/// heard by people close to it, the MinRadius should probably be 0
	/// The volume curve for a SoundNodeDistanceCrossFade will look like this:
	///                          Volume (of the input)
	///    FadeInDistance.Max --> _________________ <-- FadeOutDistance.Min
	///                          /                 \
	///                         /                   \
	///                        /                     \
	/// FadeInDistance.Min -->/                       \ <-- FadeOutDistance.Max
	/// </summary>
	public partial class USoundNodeDistanceCrossFade
	{
		static readonly int CrossFadeInput__Offset;
		/// <summary>
		/// Each input needs to have the correct data filled in so the SoundNodeDistanceCrossFade is able
		/// to determine which sounds to play
		/// </summary>
		public TStructArray<FDistanceDatum> CrossFadeInput
		{
			get{ CheckIsValid();return new TStructArray<FDistanceDatum>((FScriptArray)Marshal.PtrToStructure(_this.Get()+CrossFadeInput__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+CrossFadeInput__Offset, false);}
			
		}
		
		static USoundNodeDistanceCrossFade()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeDistanceCrossFade");
			CrossFadeInput__Offset=GetPropertyOffset(NativeClassPtr,"CrossFadeInput");
			
		}
		
	}
	
}
#endif
#endif
