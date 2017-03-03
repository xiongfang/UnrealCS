#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Stores user settings for a game (for example graphics and sound settings), with the ability to save and load to and from a file.</summary>
	public partial class UGameUserSettings
	{
		static readonly int bUseVSync__Offset;
		/// <summary>Whether to use VSync or not. (public to allow UI to connect to it)</summary>
		public bool bUseVSync
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseVSync__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ResolutionSizeX__Offset;
		/// <summary>Game screen resolution width, in pixels.</summary>
		public uint ResolutionSizeX
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+ResolutionSizeX__Offset, typeof(uint));}
			
		}
		
		static readonly int ResolutionSizeY__Offset;
		/// <summary>Game screen resolution height, in pixels.</summary>
		public uint ResolutionSizeY
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+ResolutionSizeY__Offset, typeof(uint));}
			
		}
		
		static readonly int LastUserConfirmedResolutionSizeX__Offset;
		/// <summary>Game screen resolution width, in pixels.</summary>
		public uint LastUserConfirmedResolutionSizeX
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+LastUserConfirmedResolutionSizeX__Offset, typeof(uint));}
			
		}
		
		static readonly int LastUserConfirmedResolutionSizeY__Offset;
		/// <summary>Game screen resolution height, in pixels.</summary>
		public uint LastUserConfirmedResolutionSizeY
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+LastUserConfirmedResolutionSizeY__Offset, typeof(uint));}
			
		}
		
		static readonly int WindowPosX__Offset;
		/// <summary>Window PosX</summary>
		public int WindowPosX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+WindowPosX__Offset, typeof(int));}
			
		}
		
		static readonly int WindowPosY__Offset;
		/// <summary>Window PosY</summary>
		public int WindowPosY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+WindowPosY__Offset, typeof(int));}
			
		}
		
		static readonly int FullscreenMode__Offset;
		/// <summary>
		/// Game window fullscreen mode
		///      0 = Fullscreen
		///      1 = Windowed fullscreen
		///      2 = Windowed
		/// </summary>
		public int FullscreenMode
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+FullscreenMode__Offset, typeof(int));}
			
		}
		
		static readonly int LastConfirmedFullscreenMode__Offset;
		/// <summary>Last user confirmed fullscreen mode setting.</summary>
		public int LastConfirmedFullscreenMode
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LastConfirmedFullscreenMode__Offset, typeof(int));}
			
		}
		
		static readonly int PreferredFullscreenMode__Offset;
		/// <summary>Fullscreen mode to use when toggling between windowed and fullscreen. Same values as r.FullScreenMode.</summary>
		public int PreferredFullscreenMode
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreferredFullscreenMode__Offset, typeof(int));}
			
		}
		
		static readonly int Version__Offset;
		/// <summary>All settings will be wiped and set to default if the serialized version differs from UE_GAMEUSERSETTINGS_VERSION.</summary>
		public uint Version
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+Version__Offset, typeof(uint));}
			
		}
		
		static readonly int AudioQualityLevel__Offset;
		public int AudioQualityLevel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+AudioQualityLevel__Offset, typeof(int));}
			
		}
		
		static readonly int FrameRateLimit__Offset;
		/// <summary>Frame rate cap</summary>
		public float FrameRateLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FrameRateLimit__Offset, typeof(float));}
			
		}
		
		static readonly int DesiredScreenWidth__Offset;
		/// <summary>Desired screen width used to calculate the resolution scale when user changes display mode</summary>
		public int DesiredScreenWidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+DesiredScreenWidth__Offset, typeof(int));}
			
		}
		
		static readonly int bUseDesiredScreenHeight__Offset;
		/// <summary>If true, the desired screen height will be used to scale the render resolution automatically.</summary>
		public bool bUseDesiredScreenHeight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDesiredScreenHeight__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int DesiredScreenHeight__Offset;
		/// <summary>Desired screen height used to calculate the resolution scale when user changes display mode</summary>
		public int DesiredScreenHeight
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+DesiredScreenHeight__Offset, typeof(int));}
			
		}
		
		static readonly int LastRecommendedScreenWidth__Offset;
		/// <summary>Result of the last benchmark; calculated resolution to use.</summary>
		public float LastRecommendedScreenWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastRecommendedScreenWidth__Offset, typeof(float));}
			
		}
		
		static readonly int LastRecommendedScreenHeight__Offset;
		/// <summary>Result of the last benchmark; calculated resolution to use.</summary>
		public float LastRecommendedScreenHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastRecommendedScreenHeight__Offset, typeof(float));}
			
		}
		
		static readonly int LastCPUBenchmarkResult__Offset;
		/// <summary>Result of the last benchmark (CPU); -1 if there has not been a benchmark run</summary>
		public float LastCPUBenchmarkResult
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastCPUBenchmarkResult__Offset, typeof(float));}
			
		}
		
		static readonly int LastGPUBenchmarkResult__Offset;
		/// <summary>Result of the last benchmark (GPU); -1 if there has not been a benchmark run</summary>
		public float LastGPUBenchmarkResult
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastGPUBenchmarkResult__Offset, typeof(float));}
			
		}
		
		static readonly int LastCPUBenchmarkSteps__Offset;
		/// <summary>Result of each individual sub-section of the last CPU benchmark; empty if there has not been a benchmark run</summary>
		public TStructArray<float> LastCPUBenchmarkSteps
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LastCPUBenchmarkSteps__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LastCPUBenchmarkSteps__Offset, false);}
			
		}
		
		static readonly int LastGPUBenchmarkSteps__Offset;
		/// <summary>Result of each individual sub-section of the last GPU benchmark; empty if there has not been a benchmark run</summary>
		public TStructArray<float> LastGPUBenchmarkSteps
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LastGPUBenchmarkSteps__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LastGPUBenchmarkSteps__Offset, false);}
			
		}
		
		static readonly int LastGPUBenchmarkMultiplier__Offset;
		/// <summary>Multiplier used against the last GPU benchmark</summary>
		public float LastGPUBenchmarkMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastGPUBenchmarkMultiplier__Offset, typeof(float));}
			
		}
		
		static readonly int bUseHDRDisplayOutput__Offset;
		/// <summary>HDR</summary>
		public bool bUseHDRDisplayOutput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseHDRDisplayOutput__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int HDRDisplayOutputNits__Offset;
		/// <summary>HDR</summary>
		public int HDRDisplayOutputNits
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+HDRDisplayOutputNits__Offset, typeof(int));}
			
		}
		
		static readonly int OnGameUserSettingsUINeedsUpdate__Offset;
		public FMulticastScriptDelegate OnGameUserSettingsUINeedsUpdate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnGameUserSettingsUINeedsUpdate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnGameUserSettingsUINeedsUpdate__Offset, false);}
			
		}
		
		static UGameUserSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameUserSettings");
			bUseVSync__Offset=GetPropertyOffset(NativeClassPtr,"bUseVSync");
			ResolutionSizeX__Offset=GetPropertyOffset(NativeClassPtr,"ResolutionSizeX");
			ResolutionSizeY__Offset=GetPropertyOffset(NativeClassPtr,"ResolutionSizeY");
			LastUserConfirmedResolutionSizeX__Offset=GetPropertyOffset(NativeClassPtr,"LastUserConfirmedResolutionSizeX");
			LastUserConfirmedResolutionSizeY__Offset=GetPropertyOffset(NativeClassPtr,"LastUserConfirmedResolutionSizeY");
			WindowPosX__Offset=GetPropertyOffset(NativeClassPtr,"WindowPosX");
			WindowPosY__Offset=GetPropertyOffset(NativeClassPtr,"WindowPosY");
			FullscreenMode__Offset=GetPropertyOffset(NativeClassPtr,"FullscreenMode");
			LastConfirmedFullscreenMode__Offset=GetPropertyOffset(NativeClassPtr,"LastConfirmedFullscreenMode");
			PreferredFullscreenMode__Offset=GetPropertyOffset(NativeClassPtr,"PreferredFullscreenMode");
			Version__Offset=GetPropertyOffset(NativeClassPtr,"Version");
			AudioQualityLevel__Offset=GetPropertyOffset(NativeClassPtr,"AudioQualityLevel");
			FrameRateLimit__Offset=GetPropertyOffset(NativeClassPtr,"FrameRateLimit");
			DesiredScreenWidth__Offset=GetPropertyOffset(NativeClassPtr,"DesiredScreenWidth");
			bUseDesiredScreenHeight__Offset=GetPropertyOffset(NativeClassPtr,"bUseDesiredScreenHeight");
			DesiredScreenHeight__Offset=GetPropertyOffset(NativeClassPtr,"DesiredScreenHeight");
			LastRecommendedScreenWidth__Offset=GetPropertyOffset(NativeClassPtr,"LastRecommendedScreenWidth");
			LastRecommendedScreenHeight__Offset=GetPropertyOffset(NativeClassPtr,"LastRecommendedScreenHeight");
			LastCPUBenchmarkResult__Offset=GetPropertyOffset(NativeClassPtr,"LastCPUBenchmarkResult");
			LastGPUBenchmarkResult__Offset=GetPropertyOffset(NativeClassPtr,"LastGPUBenchmarkResult");
			LastCPUBenchmarkSteps__Offset=GetPropertyOffset(NativeClassPtr,"LastCPUBenchmarkSteps");
			LastGPUBenchmarkSteps__Offset=GetPropertyOffset(NativeClassPtr,"LastGPUBenchmarkSteps");
			LastGPUBenchmarkMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"LastGPUBenchmarkMultiplier");
			bUseHDRDisplayOutput__Offset=GetPropertyOffset(NativeClassPtr,"bUseHDRDisplayOutput");
			HDRDisplayOutputNits__Offset=GetPropertyOffset(NativeClassPtr,"HDRDisplayOutputNits");
			OnGameUserSettingsUINeedsUpdate__Offset=GetPropertyOffset(NativeClassPtr,"OnGameUserSettingsUINeedsUpdate");
			
		}
		
	}
	
}
#endif
#endif
