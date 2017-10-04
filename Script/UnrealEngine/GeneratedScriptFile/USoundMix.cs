using System;
namespace UnrealEngine
{
	public partial class USoundMix:UObject
	{
		/// <summary>Whether to apply the EQ effect</summary>
		public bool bApplyEQ;
		
		public float EQPriority;
		
		public FAudioEQEffect EQSettings;
		
		/// <summary>Initial delay in seconds before the the mix is applied.</summary>
		public float InitialDelay;
		
		/// <summary>Time taken in seconds for the mix to fade in.</summary>
		public float FadeInTime;
		
		/// <summary>Duration of mix, negative means it will be applied until another mix is set.</summary>
		public float Duration;
		
		/// <summary>Time taken in seconds for the mix to fade out.</summary>
		public float FadeOutTime;
		
		/// <summary>Transient property used to trigger real-time updates of the active EQ filter for editor previewing</summary>
		public bool bChanged;
		
		
	}
	
}
