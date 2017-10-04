using System;
namespace UnrealEngine
{
	/// <summary>Struct encapsulating settings for reverb effects.</summary>
	public partial struct FReverbSettings
	{
		/// <summary>Whether to apply the reverb settings below.</summary>
		public bool bApplyReverb;
		/// <summary>The reverb preset to employ.</summary>
		public ReverbPreset ReverbType;
		/// <summary>The reverb asset to employ.</summary>
		public UReverbEffect ReverbEffect;
		/// <summary>Volume level of the reverb affect.</summary>
		public float Volume;
		/// <summary>Time to fade from the current reverb settings into this setting, in seconds.</summary>
		public float FadeTime;
		
	}
	
}
