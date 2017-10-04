using System;
namespace UnrealEngine
{
	public partial struct FSingleAnimationPlayData
	{
		/// <summary>
		/// @todo in the future, we should make this one UObject
		/// and have detail customization to display different things
		/// The default sequence to play on this skeletal mesh
		/// </summary>
		public UAnimationAsset AnimToPlay;
		/// <summary>Default setting for looping for SequenceToPlay. This is not current state of looping.</summary>
		public bool bSavedLooping;
		/// <summary>Default setting for playing for SequenceToPlay. This is not current state of playing.</summary>
		public bool bSavedPlaying;
		/// <summary>Default setting for position of SequenceToPlay to play.</summary>
		public float SavedPosition;
		/// <summary>Default setting for play rate of SequenceToPlay to play.</summary>
		public float SavedPlayRate;
		
	}
	
}
