using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UForceFeedbackComponent:USceneComponent 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int BP_GetAttenuationSettingsToApply(IntPtr _this,out FForceFeedbackAttenuationSettings OutAttenuationSettings);
public  bool BP_GetAttenuationSettingsToApply(out FForceFeedbackAttenuationSettings OutAttenuationSettings)
{
	CheckIsValid();
	int ___ret = BP_GetAttenuationSettingsToApply(_this.Get(),out OutAttenuationSettings);
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void AdjustAttenuation(IntPtr _this,ref FForceFeedbackAttenuationSettings InAttenuationSettings);
/// <summary>Modify the attenuation settings of the component</summary>
public  void AdjustAttenuation(FForceFeedbackAttenuationSettings InAttenuationSettings)
{
	CheckIsValid();
	AdjustAttenuation(_this.Get(),ref InAttenuationSettings);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetIntensityMultiplier(IntPtr _this,float NewIntensityMultiplier);
/// <summary>Set a new intensity multiplier</summary>
public  void SetIntensityMultiplier(float NewIntensityMultiplier)
{
	CheckIsValid();
	SetIntensityMultiplier(_this.Get(),NewIntensityMultiplier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Stop(IntPtr _this);
/// <summary>Stop playing the feedback effect</summary>
public  void Stop()
{
	CheckIsValid();
	Stop(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void Play(IntPtr _this,float StartTime);
/// <summary>Start a feedback effect playing</summary>
public  void Play(float StartTime=0.000000f)
{
	CheckIsValid();
	Play(_this.Get(),StartTime);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetForceFeedbackEffect(IntPtr _this,IntPtr NewForceFeedbackEffect);
/// <summary>Set what force feedback effect is played by this component</summary>
public  void SetForceFeedbackEffect(UForceFeedbackEffect NewForceFeedbackEffect)
{
	CheckIsValid();
	SetForceFeedbackEffect(_this.Get(),NewForceFeedbackEffect);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
