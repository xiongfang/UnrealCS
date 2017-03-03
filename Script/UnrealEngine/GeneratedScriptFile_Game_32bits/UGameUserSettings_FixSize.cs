#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UGameUserSettings
	{
		static readonly int bUseVSync__Offset;
		public bool bUseVSync
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseVSync__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ResolutionSizeX__Offset;
		public uint ResolutionSizeX
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+ResolutionSizeX__Offset, typeof(uint));}
			
		}
		
		static readonly int ResolutionSizeY__Offset;
		public uint ResolutionSizeY
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+ResolutionSizeY__Offset, typeof(uint));}
			
		}
		
		static readonly int LastUserConfirmedResolutionSizeX__Offset;
		public uint LastUserConfirmedResolutionSizeX
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+LastUserConfirmedResolutionSizeX__Offset, typeof(uint));}
			
		}
		
		static readonly int LastUserConfirmedResolutionSizeY__Offset;
		public uint LastUserConfirmedResolutionSizeY
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+LastUserConfirmedResolutionSizeY__Offset, typeof(uint));}
			
		}
		
		static readonly int WindowPosX__Offset;
		public int WindowPosX
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+WindowPosX__Offset, typeof(int));}
			
		}
		
		static readonly int WindowPosY__Offset;
		public int WindowPosY
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+WindowPosY__Offset, typeof(int));}
			
		}
		
		static readonly int FullscreenMode__Offset;
		public int FullscreenMode
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+FullscreenMode__Offset, typeof(int));}
			
		}
		
		static readonly int LastConfirmedFullscreenMode__Offset;
		public int LastConfirmedFullscreenMode
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LastConfirmedFullscreenMode__Offset, typeof(int));}
			
		}
		
		static readonly int PreferredFullscreenMode__Offset;
		public int PreferredFullscreenMode
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PreferredFullscreenMode__Offset, typeof(int));}
			
		}
		
		static readonly int Version__Offset;
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
		public float FrameRateLimit
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FrameRateLimit__Offset, typeof(float));}
			
		}
		
		static readonly int DesiredScreenWidth__Offset;
		public int DesiredScreenWidth
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+DesiredScreenWidth__Offset, typeof(int));}
			
		}
		
		static readonly int bUseDesiredScreenHeight__Offset;
		public bool bUseDesiredScreenHeight
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDesiredScreenHeight__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int DesiredScreenHeight__Offset;
		public int DesiredScreenHeight
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+DesiredScreenHeight__Offset, typeof(int));}
			
		}
		
		static readonly int LastRecommendedScreenWidth__Offset;
		public float LastRecommendedScreenWidth
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastRecommendedScreenWidth__Offset, typeof(float));}
			
		}
		
		static readonly int LastRecommendedScreenHeight__Offset;
		public float LastRecommendedScreenHeight
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastRecommendedScreenHeight__Offset, typeof(float));}
			
		}
		
		static readonly int LastCPUBenchmarkResult__Offset;
		public float LastCPUBenchmarkResult
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastCPUBenchmarkResult__Offset, typeof(float));}
			
		}
		
		static readonly int LastGPUBenchmarkResult__Offset;
		public float LastGPUBenchmarkResult
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastGPUBenchmarkResult__Offset, typeof(float));}
			
		}
		
		static readonly int LastCPUBenchmarkSteps__Offset;
		public TStructArray<float> LastCPUBenchmarkSteps
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LastCPUBenchmarkSteps__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LastCPUBenchmarkSteps__Offset, false);}
			
		}
		
		static readonly int LastGPUBenchmarkSteps__Offset;
		public TStructArray<float> LastGPUBenchmarkSteps
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LastGPUBenchmarkSteps__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LastGPUBenchmarkSteps__Offset, false);}
			
		}
		
		static readonly int LastGPUBenchmarkMultiplier__Offset;
		public float LastGPUBenchmarkMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastGPUBenchmarkMultiplier__Offset, typeof(float));}
			
		}
		
		static readonly int bUseHDRDisplayOutput__Offset;
		public bool bUseHDRDisplayOutput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseHDRDisplayOutput__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int HDRDisplayOutputNits__Offset;
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
