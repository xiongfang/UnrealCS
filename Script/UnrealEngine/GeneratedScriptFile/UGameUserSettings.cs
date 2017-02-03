using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UGameUserSettings:UObject 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ApplyHardwareBenchmarkResults(IntPtr _this);
/// <summary>Applies the settings stored in ScalabilityQuality and saves settings</summary>
public  void ApplyHardwareBenchmarkResults()
{
	CheckIsValid();
	ApplyHardwareBenchmarkResults(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RunHardwareBenchmark(IntPtr _this,int WorkScale,float CPUMultiplier,float GPUMultiplier);
/// <summary>Runs the hardware benchmark and populates ScalabilityQuality as well as the last benchmark results config members, but does not apply the settings it determines. Designed to be called in conjunction with ApplyHardwareBenchmarkResults</summary>
public  void RunHardwareBenchmark(int WorkScale=10,float CPUMultiplier=1.000000f,float GPUMultiplier=1.000000f)
{
	CheckIsValid();
	RunHardwareBenchmark(_this.Get(),WorkScale,CPUMultiplier,GPUMultiplier);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static IntPtr GetGameUserSettings(IntPtr _this);
/// <summary>Returns the game local machine settings (resolution, windowing mode, scalability settings, etc...)</summary>
public static UGameUserSettings GetGameUserSettings()
{
	IntPtr ___ret = GetGameUserSettings(IntPtr.Zero);
	if(___ret==IntPtr.Zero) return null; UGameUserSettings ___ret2= new UGameUserSettings(){ _this = ___ret }; return ___ret2;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetDefaultWindowMode(IntPtr _this);
/// <summary>@return The default window mode when no mode is set</summary>
public static EWindowMode GetDefaultWindowMode()
{
	int ___ret = GetDefaultWindowMode(IntPtr.Zero);
	return (EWindowMode)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FIntPoint GetDefaultWindowPosition(IntPtr _this);
/// <summary>@return The default window position when no position is set</summary>
public static FIntPoint GetDefaultWindowPosition()
{
	FIntPoint ___ret = GetDefaultWindowPosition(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FIntPoint GetDefaultResolution(IntPtr _this);
/// <summary>@return The default resolution when no resolution is set</summary>
public static FIntPoint GetDefaultResolution()
{
	FIntPoint ___ret = GetDefaultResolution(IntPtr.Zero);
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetDefaultResolutionScale(IntPtr _this);
/// <summary>Gets the desired resolution quality based on DesiredScreenHeight and the current screen resolution</summary>
public  float GetDefaultResolutionScale()
{
	CheckIsValid();
	float ___ret = GetDefaultResolutionScale(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetToDefaults(IntPtr _this);
public  void SetToDefaults()
{
	CheckIsValid();
	SetToDefaults(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ResetToCurrentSettings(IntPtr _this);
/// <summary>This function resets all settings to the current system settings</summary>
public  void ResetToCurrentSettings()
{
	CheckIsValid();
	ResetToCurrentSettings(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SaveSettings(IntPtr _this);
/// <summary>Save the user settings to persistent storage (automatically happens as part of ApplySettings)</summary>
public  void SaveSettings()
{
	CheckIsValid();
	SaveSettings(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void LoadSettings(IntPtr _this,int bForceReload);
/// <summary>Loads the user settings from persistent storage</summary>
public  void LoadSettings(bool bForceReload=false)
{
	CheckIsValid();
	LoadSettings(_this.Get(),bForceReload?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ValidateSettings(IntPtr _this);
/// <summary>Validates and resets bad user settings to default. Deletes stale user settings file if necessary.</summary>
public  void ValidateSettings()
{
	CheckIsValid();
	ValidateSettings(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsDirty(IntPtr _this);
/// <summary>Checks if any user settings is different from current</summary>
public  bool IsDirty()
{
	CheckIsValid();
	int ___ret = IsDirty(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetFoliageQuality(IntPtr _this);
/// <summary>Returns the post-processing quality (0..3, higher is better)</summary>
public  int GetFoliageQuality()
{
	CheckIsValid();
	int ___ret = GetFoliageQuality(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFoliageQuality(IntPtr _this,int Value);
/// <summary>Sets the post-processing quality (0..3, higher is better)</summary>
public  void SetFoliageQuality(int Value)
{
	CheckIsValid();
	SetFoliageQuality(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetPostProcessingQuality(IntPtr _this);
/// <summary>Returns the post-processing quality (0..3, higher is better)</summary>
public  int GetPostProcessingQuality()
{
	CheckIsValid();
	int ___ret = GetPostProcessingQuality(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetPostProcessingQuality(IntPtr _this,int Value);
/// <summary>Sets the post-processing quality (0..3, higher is better)</summary>
public  void SetPostProcessingQuality(int Value)
{
	CheckIsValid();
	SetPostProcessingQuality(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetVisualEffectQuality(IntPtr _this);
/// <summary>Returns the visual effects quality (0..3, higher is better)</summary>
public  int GetVisualEffectQuality()
{
	CheckIsValid();
	int ___ret = GetVisualEffectQuality(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVisualEffectQuality(IntPtr _this,int Value);
/// <summary>Sets the visual effects quality (0..3, higher is better)</summary>
public  void SetVisualEffectQuality(int Value)
{
	CheckIsValid();
	SetVisualEffectQuality(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetTextureQuality(IntPtr _this);
/// <summary>Returns the texture quality (0..3, higher is better)</summary>
public  int GetTextureQuality()
{
	CheckIsValid();
	int ___ret = GetTextureQuality(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetTextureQuality(IntPtr _this,int Value);
/// <summary>Sets the texture quality (0..3, higher is better)</summary>
public  void SetTextureQuality(int Value)
{
	CheckIsValid();
	SetTextureQuality(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetAntiAliasingQuality(IntPtr _this);
/// <summary>Returns the anti-aliasing quality (0..3, higher is better)</summary>
public  int GetAntiAliasingQuality()
{
	CheckIsValid();
	int ___ret = GetAntiAliasingQuality(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAntiAliasingQuality(IntPtr _this,int Value);
/// <summary>Sets the anti-aliasing quality (0..3, higher is better)</summary>
public  void SetAntiAliasingQuality(int Value)
{
	CheckIsValid();
	SetAntiAliasingQuality(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetShadowQuality(IntPtr _this);
/// <summary>Returns the shadow quality (0..3, higher is better)</summary>
public  int GetShadowQuality()
{
	CheckIsValid();
	int ___ret = GetShadowQuality(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetShadowQuality(IntPtr _this,int Value);
/// <summary>Sets the shadow quality (0..3, higher is better)</summary>
public  void SetShadowQuality(int Value)
{
	CheckIsValid();
	SetShadowQuality(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetViewDistanceQuality(IntPtr _this);
/// <summary>Returns the view distance quality (0..3, higher is better)</summary>
public  int GetViewDistanceQuality()
{
	CheckIsValid();
	int ___ret = GetViewDistanceQuality(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetViewDistanceQuality(IntPtr _this,int Value);
/// <summary>Sets the view distance quality (0..3, higher is better)</summary>
public  void SetViewDistanceQuality(int Value)
{
	CheckIsValid();
	SetViewDistanceQuality(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetResolutionScaleNormalized(IntPtr _this,float NewScaleNormalized);
/// <summary>Sets the current resolution scale as a normalized 0..1 value between MinScaleValue and MaxScaleValue</summary>
public  void SetResolutionScaleNormalized(float NewScaleNormalized)
{
	CheckIsValid();
	SetResolutionScaleNormalized(_this.Get(),NewScaleNormalized);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetResolutionScaleValueEx(IntPtr _this,float NewScaleValue);
/// <summary>Sets the current resolution scale</summary>
public  void SetResolutionScaleValueEx(float NewScaleValue)
{
	CheckIsValid();
	SetResolutionScaleValueEx(_this.Get(),NewScaleValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void GetResolutionScaleInformationEx(IntPtr _this,out float CurrentScaleNormalized,out float CurrentScaleValue,out float MinScaleValue,out float MaxScaleValue);
/// <summary>Returns the current resolution scale and the range</summary>
public  void GetResolutionScaleInformationEx(out float CurrentScaleNormalized,out float CurrentScaleValue,out float MinScaleValue,out float MaxScaleValue)
{
	CheckIsValid();
	GetResolutionScaleInformationEx(_this.Get(),out CurrentScaleNormalized,out CurrentScaleValue,out MinScaleValue,out MaxScaleValue);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetOverallScalabilityLevel(IntPtr _this);
/// <summary>Returns the overall scalability level (can return -1 if the settings are custom)</summary>
public  int GetOverallScalabilityLevel()
{
	CheckIsValid();
	int ___ret = GetOverallScalabilityLevel(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetOverallScalabilityLevel(IntPtr _this,int Value);
/// <summary>
/// Changes all scalability settings at once based on a single overall quality level
/// @param Value 0:low, 1:medium, 2:high, 3:epic
/// </summary>
public  void SetOverallScalabilityLevel(int Value)
{
	CheckIsValid();
	SetOverallScalabilityLevel(_this.Get(),Value);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static float GetFrameRateLimit(IntPtr _this);
/// <summary>Gets the user's frame rate limit (0 indiciates the frame rate limit is disabled)</summary>
public  float GetFrameRateLimit()
{
	CheckIsValid();
	float ___ret = GetFrameRateLimit(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFrameRateLimit(IntPtr _this,float NewLimit);
/// <summary>Sets the user's frame rate limit (0 will disable frame rate limiting)</summary>
public  void SetFrameRateLimit(float NewLimit)
{
	CheckIsValid();
	SetFrameRateLimit(_this.Get(),NewLimit);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetAudioQualityLevel(IntPtr _this);
/// <summary>Returns the user's audio quality level setting</summary>
public  int GetAudioQualityLevel()
{
	CheckIsValid();
	int ___ret = GetAudioQualityLevel(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetAudioQualityLevel(IntPtr _this,int QualityLevel);
/// <summary>Sets the user's audio quality level setting</summary>
public  void SetAudioQualityLevel(int QualityLevel)
{
	CheckIsValid();
	SetAudioQualityLevel(_this.Get(),QualityLevel);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetBenchmarkFallbackValues(IntPtr _this);
/// <summary>Set scalability settings to sensible fallback values, for use when the benchmark fails or potentially causes a crash</summary>
public  void SetBenchmarkFallbackValues()
{
	CheckIsValid();
	SetBenchmarkFallbackValues(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void RevertVideoMode(IntPtr _this);
/// <summary>Revert video mode (fullscreenmode/resolution) back to the last user confirmed values</summary>
public  void RevertVideoMode()
{
	CheckIsValid();
	RevertVideoMode(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ConfirmVideoMode(IntPtr _this);
/// <summary>Mark current video mode settings (fullscreenmode/resolution) as being confirmed by the user</summary>
public  void ConfirmVideoMode()
{
	CheckIsValid();
	ConfirmVideoMode(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsVSyncDirty(IntPtr _this);
/// <summary>Checks if the vsync user setting is different from current system setting</summary>
public  bool IsVSyncDirty()
{
	CheckIsValid();
	int ___ret = IsVSyncDirty(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsFullscreenModeDirty(IntPtr _this);
/// <summary>Checks if the FullscreenMode user setting is different from current</summary>
public  bool IsFullscreenModeDirty()
{
	CheckIsValid();
	int ___ret = IsFullscreenModeDirty(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsScreenResolutionDirty(IntPtr _this);
/// <summary>Checks if the Screen Resolution user setting is different from current</summary>
public  bool IsScreenResolutionDirty()
{
	CheckIsValid();
	int ___ret = IsScreenResolutionDirty(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int IsVSyncEnabled(IntPtr _this);
/// <summary>Returns the user setting for vsync.</summary>
public  bool IsVSyncEnabled()
{
	CheckIsValid();
	int ___ret = IsVSyncEnabled(_this.Get());
	return ___ret!=0;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetVSyncEnabled(IntPtr _this,int bEnable);
/// <summary>Sets the user setting for vsync. See UGameUserSettings::bUseVSync.</summary>
public  void SetVSyncEnabled(bool bEnable)
{
	CheckIsValid();
	SetVSyncEnabled(_this.Get(),bEnable?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetFullscreenMode(IntPtr _this,int InFullscreenMode);
/// <summary>Sets the user setting for the game window fullscreen mode. See UGameUserSettings::FullscreenMode.</summary>
public  void SetFullscreenMode(EWindowMode InFullscreenMode)
{
	CheckIsValid();
	SetFullscreenMode(_this.Get(),(int)InFullscreenMode);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetLastConfirmedFullscreenMode(IntPtr _this);
/// <summary>Returns the last confirmed user setting for game window fullscreen mode.</summary>
public  EWindowMode GetLastConfirmedFullscreenMode()
{
	CheckIsValid();
	int ___ret = GetLastConfirmedFullscreenMode(_this.Get());
	return (EWindowMode)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static int GetFullscreenMode(IntPtr _this);
/// <summary>Returns the user setting for game window fullscreen mode.</summary>
public  EWindowMode GetFullscreenMode()
{
	CheckIsValid();
	int ___ret = GetFullscreenMode(_this.Get());
	return (EWindowMode)___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void SetScreenResolution(IntPtr _this,ref FIntPoint Resolution);
/// <summary>Sets the user setting for game screen resolution, in pixels.</summary>
public  void SetScreenResolution(FIntPoint Resolution)
{
	CheckIsValid();
	SetScreenResolution(_this.Get(),ref Resolution);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FIntPoint GetDesktopResolution(IntPtr _this);
/// <summary>Returns user's desktop resolution, in pixels.</summary>
public  FIntPoint GetDesktopResolution()
{
	CheckIsValid();
	FIntPoint ___ret = GetDesktopResolution(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FIntPoint GetLastConfirmedScreenResolution(IntPtr _this);
/// <summary>Returns the last confirmed user setting for game screen resolution, in pixels.</summary>
public  FIntPoint GetLastConfirmedScreenResolution()
{
	CheckIsValid();
	FIntPoint ___ret = GetLastConfirmedScreenResolution(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static FIntPoint GetScreenResolution(IntPtr _this);
/// <summary>Returns the user setting for game screen resolution, in pixels.</summary>
public  FIntPoint GetScreenResolution()
{
	CheckIsValid();
	FIntPoint ___ret = GetScreenResolution(_this.Get());
	return ___ret;
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ApplyResolutionSettings(IntPtr _this,int bCheckForCommandLineOverrides);
public  void ApplyResolutionSettings(bool bCheckForCommandLineOverrides)
{
	CheckIsValid();
	ApplyResolutionSettings(_this.Get(),bCheckForCommandLineOverrides?1:0);
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ApplyNonResolutionSettings(IntPtr _this);
public  void ApplyNonResolutionSettings()
{
	CheckIsValid();
	ApplyNonResolutionSettings(_this.Get());
	
}
[MethodImplAttribute(MethodImplOptions.InternalCall)]
extern static void ApplySettings(IntPtr _this,int bCheckForCommandLineOverrides);
/// <summary>Applies all current user settings to the game and saves to permanent storage (e.g. file), optionally checking for command line overrides.</summary>
public  void ApplySettings(bool bCheckForCommandLineOverrides)
{
	CheckIsValid();
	ApplySettings(_this.Get(),bCheckForCommandLineOverrides?1:0);
	
}
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public extern static new IntPtr StaticClass();
}
}
