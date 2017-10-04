using System;
namespace UnrealEngine
{
	public partial class UInterpTrackAnimControl:UInterpTrackFloatBase
	{
		/// <summary>
		/// Name of slot to use when playing animation. Passed to Actor.
		/// When multiple tracks use the same slot name, they are each given a different ChannelIndex when SetAnimPosition is called.
		/// </summary>
		public FName SlotName;
		
		/// <summary>Skip all anim notifiers *</summary>
		public bool bSkipAnimNotifiers;
		
		
	}
	
}
