using System;
namespace UnrealEngine
{
	public partial class UGameUserSettings:UObject
	{
		/// <summary>Enables or disables HDR display output. Can be called again to change the desired nit level</summary>
		public extern void EnableHDRDisplayOutput(bool bEnable,int DisplayNits=1000);
		/// <summary>Whether the curently running system supports HDR display output</summary>
		public extern bool SupportsHDRDisplayOutput();
		/// <summary>Applies the settings stored in ScalabilityQuality and saves settings</summary>
		public extern virtual void ApplyHardwareBenchmarkResults();
		/// <summary>Runs the hardware benchmark and populates ScalabilityQuality as well as the last benchmark results config members, but does not apply the settings it determines. Designed to be called in conjunction with ApplyHardwareBenchmarkResults</summary>
		public extern virtual void RunHardwareBenchmark(int WorkScale=10,float CPUMultiplier=1.000000f,float GPUMultiplier=1.000000f);
		/// <summary>Returns the game local machine settings (resolution, windowing mode, scalability settings, etc...)</summary>
		public extern static UGameUserSettings GetGameUserSettings();
		/// <summary>@return The default window mode when no mode is set</summary>
		public extern static EWindowMode GetDefaultWindowMode();
		/// <summary>@return The default window position when no position is set</summary>
		public extern static FIntPoint GetDefaultWindowPosition();
		/// <summary>@return The default resolution when no resolution is set</summary>
		public extern static FIntPoint GetDefaultResolution();
		/// <summary>Gets the desired resolution quality based on DesiredScreenHeight and the current screen resolution</summary>
		public extern virtual float GetDefaultResolutionScale();
		public extern virtual void SetToDefaults();
		/// <summary>This function resets all settings to the current system settings</summary>
		public extern virtual void ResetToCurrentSettings();
		/// <summary>Save the user settings to persistent storage (automatically happens as part of ApplySettings)</summary>
		public extern virtual void SaveSettings();
		/// <summary>Loads the user settings from persistent storage</summary>
		public extern virtual void LoadSettings(bool bForceReload=false);
		/// <summary>Validates and resets bad user settings to default. Deletes stale user settings file if necessary.</summary>
		public extern virtual void ValidateSettings();
		/// <summary>Checks if any user settings is different from current</summary>
		public extern virtual bool IsDirty();
		/// <summary>Returns the post-processing quality (0..3, higher is better)</summary>
		public extern int GetFoliageQuality();
		/// <summary>Sets the post-processing quality (0..3, higher is better)</summary>
		public extern void SetFoliageQuality(int Value);
		/// <summary>Returns the post-processing quality (0..3, higher is better)</summary>
		public extern int GetPostProcessingQuality();
		/// <summary>Sets the post-processing quality (0..3, higher is better)</summary>
		public extern void SetPostProcessingQuality(int Value);
		/// <summary>Returns the visual effects quality (0..3, higher is better)</summary>
		public extern int GetVisualEffectQuality();
		/// <summary>Sets the visual effects quality (0..3, higher is better)</summary>
		public extern void SetVisualEffectQuality(int Value);
		/// <summary>Returns the texture quality (0..3, higher is better)</summary>
		public extern int GetTextureQuality();
		/// <summary>Sets the texture quality (0..3, higher is better)</summary>
		public extern void SetTextureQuality(int Value);
		/// <summary>Returns the anti-aliasing quality (0..3, higher is better)</summary>
		public extern int GetAntiAliasingQuality();
		/// <summary>Sets the anti-aliasing quality (0..3, higher is better)</summary>
		public extern void SetAntiAliasingQuality(int Value);
		/// <summary>Returns the shadow quality (0..3, higher is better)</summary>
		public extern int GetShadowQuality();
		/// <summary>Sets the shadow quality (0..3, higher is better)</summary>
		public extern void SetShadowQuality(int Value);
		/// <summary>Returns the view distance quality (0..3, higher is better)</summary>
		public extern int GetViewDistanceQuality();
		/// <summary>Sets the view distance quality (0..3, higher is better)</summary>
		public extern void SetViewDistanceQuality(int Value);
		/// <summary>Sets the current resolution scale as a normalized 0..1 value between MinScaleValue and MaxScaleValue</summary>
		public extern void SetResolutionScaleNormalized(float NewScaleNormalized);
		/// <summary>Sets the current resolution scale</summary>
		public extern void SetResolutionScaleValueEx(float NewScaleValue);
		/// <summary>Returns the current resolution scale and the range</summary>
		public extern void GetResolutionScaleInformationEx(out float CurrentScaleNormalized,out float CurrentScaleValue,out float MinScaleValue,out float MaxScaleValue);
		/// <summary>Returns the overall scalability level (can return -1 if the settings are custom)</summary>
		public extern int GetOverallScalabilityLevel();
		/// <summary>
		/// Changes all scalability settings at once based on a single overall quality level
		/// @param Value 0:low, 1:medium, 2:high, 3:epic
		/// </summary>
		public extern virtual void SetOverallScalabilityLevel(int Value);
		/// <summary>Gets the user's frame rate limit (0 indiciates the frame rate limit is disabled)</summary>
		public extern float GetFrameRateLimit();
		/// <summary>Sets the user's frame rate limit (0 will disable frame rate limiting)</summary>
		public extern void SetFrameRateLimit(float NewLimit);
		/// <summary>Returns the user's audio quality level setting</summary>
		public extern int GetAudioQualityLevel();
		/// <summary>Sets the user's audio quality level setting</summary>
		public extern void SetAudioQualityLevel(int QualityLevel);
		/// <summary>Set scalability settings to sensible fallback values, for use when the benchmark fails or potentially causes a crash</summary>
		public extern void SetBenchmarkFallbackValues();
		/// <summary>Revert video mode (fullscreenmode/resolution) back to the last user confirmed values</summary>
		public extern void RevertVideoMode();
		/// <summary>Mark current video mode settings (fullscreenmode/resolution) as being confirmed by the user</summary>
		public extern void ConfirmVideoMode();
		/// <summary>Checks if the vsync user setting is different from current system setting</summary>
		public extern bool IsVSyncDirty();
		/// <summary>Checks if the FullscreenMode user setting is different from current</summary>
		public extern bool IsFullscreenModeDirty();
		/// <summary>Checks if the Screen Resolution user setting is different from current</summary>
		public extern bool IsScreenResolutionDirty();
		/// <summary>Returns the user setting for vsync.</summary>
		public extern bool IsVSyncEnabled();
		/// <summary>Sets the user setting for vsync. See UGameUserSettings::bUseVSync.</summary>
		public extern void SetVSyncEnabled(bool bEnable);
		/// <summary>Returns the user setting for game window fullscreen mode.</summary>
		public extern EWindowMode GetPreferredFullscreenMode();
		/// <summary>Sets the user setting for the game window fullscreen mode. See UGameUserSettings::FullscreenMode.</summary>
		public extern void SetFullscreenMode(EWindowMode InFullscreenMode);
		/// <summary>Returns the last confirmed user setting for game window fullscreen mode.</summary>
		public extern EWindowMode GetLastConfirmedFullscreenMode();
		/// <summary>Returns the user setting for game window fullscreen mode.</summary>
		public extern EWindowMode GetFullscreenMode();
		/// <summary>Sets the user setting for game screen resolution, in pixels.</summary>
		public extern void SetScreenResolution(FIntPoint Resolution);
		/// <summary>Returns user's desktop resolution, in pixels.</summary>
		public extern FIntPoint GetDesktopResolution();
		/// <summary>Returns the last confirmed user setting for game screen resolution, in pixels.</summary>
		public extern FIntPoint GetLastConfirmedScreenResolution();
		/// <summary>Returns the user setting for game screen resolution, in pixels.</summary>
		public extern FIntPoint GetScreenResolution();
		public extern void ApplyResolutionSettings(bool bCheckForCommandLineOverrides);
		public extern virtual void ApplyNonResolutionSettings();
		/// <summary>Applies all current user settings to the game and saves to permanent storage (e.g. file), optionally checking for command line overrides.</summary>
		public extern virtual void ApplySettings(bool bCheckForCommandLineOverrides);
		/// <summary>Whether to use VSync or not. (public to allow UI to connect to it)</summary>
		public bool bUseVSync;
		
		/// <summary>Game screen resolution width, in pixels.</summary>
		public uint ResolutionSizeX;
		
		/// <summary>Game screen resolution height, in pixels.</summary>
		public uint ResolutionSizeY;
		
		/// <summary>Game screen resolution width, in pixels.</summary>
		public uint LastUserConfirmedResolutionSizeX;
		
		/// <summary>Game screen resolution height, in pixels.</summary>
		public uint LastUserConfirmedResolutionSizeY;
		
		/// <summary>Window PosX</summary>
		public int WindowPosX;
		
		/// <summary>Window PosY</summary>
		public int WindowPosY;
		
		/// <summary>
		/// Game window fullscreen mode
		///      0 = Fullscreen
		///      1 = Windowed fullscreen
		///      2 = Windowed
		/// </summary>
		public int FullscreenMode;
		
		/// <summary>Last user confirmed fullscreen mode setting.</summary>
		public int LastConfirmedFullscreenMode;
		
		/// <summary>Fullscreen mode to use when toggling between windowed and fullscreen. Same values as r.FullScreenMode.</summary>
		public int PreferredFullscreenMode;
		
		/// <summary>All settings will be wiped and set to default if the serialized version differs from UE_GAMEUSERSETTINGS_VERSION.</summary>
		public uint Version;
		
		public int AudioQualityLevel;
		
		/// <summary>Frame rate cap</summary>
		public float FrameRateLimit;
		
		/// <summary>Desired screen width used to calculate the resolution scale when user changes display mode</summary>
		public int DesiredScreenWidth;
		
		/// <summary>If true, the desired screen height will be used to scale the render resolution automatically.</summary>
		public bool bUseDesiredScreenHeight;
		
		/// <summary>Desired screen height used to calculate the resolution scale when user changes display mode</summary>
		public int DesiredScreenHeight;
		
		/// <summary>Result of the last benchmark; calculated resolution to use.</summary>
		public float LastRecommendedScreenWidth;
		
		/// <summary>Result of the last benchmark; calculated resolution to use.</summary>
		public float LastRecommendedScreenHeight;
		
		/// <summary>Result of the last benchmark (CPU); -1 if there has not been a benchmark run</summary>
		public float LastCPUBenchmarkResult;
		
		/// <summary>Result of the last benchmark (GPU); -1 if there has not been a benchmark run</summary>
		public float LastGPUBenchmarkResult;
		
		/// <summary>Multiplier used against the last GPU benchmark</summary>
		public float LastGPUBenchmarkMultiplier;
		
		/// <summary>HDR</summary>
		public bool bUseHDRDisplayOutput;
		
		/// <summary>HDR</summary>
		public int HDRDisplayOutputNits;
		
		
	}
	
}
