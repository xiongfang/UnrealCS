using System;
namespace UnrealEngine
{
	public partial class UForceFeedbackComponent:USceneComponent
	{
		public extern bool BP_GetAttenuationSettingsToApply(out FForceFeedbackAttenuationSettings OutAttenuationSettings);
		/// <summary>Modify the attenuation settings of the component</summary>
		public extern void AdjustAttenuation(FForceFeedbackAttenuationSettings InAttenuationSettings);
		/// <summary>Set a new intensity multiplier</summary>
		public extern void SetIntensityMultiplier(float NewIntensityMultiplier);
		/// <summary>Stop playing the feedback effect</summary>
		public extern virtual void Stop();
		/// <summary>Start a feedback effect playing</summary>
		public extern virtual void Play(float StartTime=0.000000f);
		/// <summary>Set what force feedback effect is played by this component</summary>
		public extern void SetForceFeedbackEffect(UForceFeedbackEffect NewForceFeedbackEffect);
		/// <summary>The feedback effect to be played</summary>
		public UForceFeedbackEffect ForceFeedbackEffect;
		
		/// <summary>Auto destroy this component on completion</summary>
		public bool bAutoDestroy;
		
		/// <summary>Stop effect when owner is destroyed</summary>
		public bool bStopWhenOwnerDestroyed;
		
		public bool bLooping;
		
		/// <summary>Should the Attenuation Settings asset be used (false) or should the properties set directly on the component be used for attenuation properties</summary>
		public bool bOverrideAttenuation;
		
		/// <summary>The intensity multiplier to apply to effects generated by this component</summary>
		public float IntensityMultiplier;
		
		/// <summary>If bOverrideSettings is false, the asset to use to determine attenuation properties for effects generated by this component</summary>
		public UForceFeedbackAttenuation AttenuationSettings;
		
		/// <summary>If bOverrideSettings is true, the attenuation properties to use for effects generated by this component</summary>
		public FForceFeedbackAttenuationSettings AttenuationOverrides;
		
		
	}
	
}
