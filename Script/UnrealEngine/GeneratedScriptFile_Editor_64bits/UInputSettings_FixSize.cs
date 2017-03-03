#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Project wide settings for input handling
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html
	/// </summary>
	public partial class UInputSettings
	{
		static readonly int AxisConfig__Offset;
		/// <summary>List of Axis Properties</summary>
		public TStructArray<FInputAxisConfigEntry> AxisConfig
		{
			get{ CheckIsValid();return new TStructArray<FInputAxisConfigEntry>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AxisConfig__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AxisConfig__Offset, false);}
			
		}
		
		static readonly int bAltEnterTogglesFullscreen__Offset;
		public bool bAltEnterTogglesFullscreen
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAltEnterTogglesFullscreen__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAltEnterTogglesFullscreen__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bF11TogglesFullscreen__Offset;
		public bool bF11TogglesFullscreen
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bF11TogglesFullscreen__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bF11TogglesFullscreen__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bUseMouseForTouch__Offset;
		/// <summary>Allow mouse to be used for touch</summary>
		public bool bUseMouseForTouch
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseMouseForTouch__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseMouseForTouch__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bEnableMouseSmoothing__Offset;
		/// <summary>Mouse smoothing control</summary>
		public bool bEnableMouseSmoothing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableMouseSmoothing__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableMouseSmoothing__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bEnableFOVScaling__Offset;
		/// <summary>Scale the mouse based on the player camera manager's field of view</summary>
		public bool bEnableFOVScaling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableFOVScaling__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableFOVScaling__Offset, 1,0,16,16);}
			
		}
		
		static readonly int FOVScale__Offset;
		/// <summary>The scaling value to multiply the field of view by</summary>
		public float FOVScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FOVScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FOVScale__Offset, false);}
			
		}
		
		static readonly int DoubleClickTime__Offset;
		/// <summary>If a key is pressed twice in this amount of time it is considered a "double click"</summary>
		public float DoubleClickTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DoubleClickTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DoubleClickTime__Offset, false);}
			
		}
		
		static readonly int bCaptureMouseOnLaunch__Offset;
		/// <summary>Controls if the viewport will capture the mouse on Launch of the application</summary>
		public bool bCaptureMouseOnLaunch
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCaptureMouseOnLaunch__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCaptureMouseOnLaunch__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bDefaultViewportMouseLock__Offset;
		/// <summary>The default mouse lock state when the viewport acquires capture</summary>
		public bool bDefaultViewportMouseLock
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDefaultViewportMouseLock__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int ActionMappings__Offset;
		/// <summary>List of Action Mappings</summary>
		public TStructArray<FInputActionKeyMapping> ActionMappings
		{
			get{ CheckIsValid();return new TStructArray<FInputActionKeyMapping>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActionMappings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActionMappings__Offset, false);}
			
		}
		
		static readonly int AxisMappings__Offset;
		/// <summary>List of Axis Mappings</summary>
		public TStructArray<FInputAxisKeyMapping> AxisMappings
		{
			get{ CheckIsValid();return new TStructArray<FInputAxisKeyMapping>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AxisMappings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AxisMappings__Offset, false);}
			
		}
		
		static readonly int bAlwaysShowTouchInterface__Offset;
		/// <summary>Should the touch input interface be shown always, or only when the platform has a touch screen?</summary>
		public bool bAlwaysShowTouchInterface
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysShowTouchInterface__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysShowTouchInterface__Offset, 1,0,1,255);}
			
		}
		
		static readonly int bShowConsoleOnFourFingerTap__Offset;
		/// <summary>Whether or not to show the console on 4 finger tap, on mobile platforms</summary>
		public bool bShowConsoleOnFourFingerTap
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowConsoleOnFourFingerTap__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowConsoleOnFourFingerTap__Offset, 1,0,1,255);}
			
		}
		
		static readonly int DefaultTouchInterface__Offset;
		/// <summary>The default on-screen touch input interface for the game (can be null to disable the onscreen interface)</summary>
		public FStringAssetReference DefaultTouchInterface
		{
			get{ CheckIsValid();return (FStringAssetReference)Marshal.PtrToStructure(_this.Get()+DefaultTouchInterface__Offset, typeof(FStringAssetReference));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultTouchInterface__Offset, false);}
			
		}
		
		static readonly int ConsoleKey__Offset;
		/// <summary>The key which opens the console.</summary>
		public FKey ConsoleKey
		{
			get{ CheckIsValid();return (FKey)Marshal.PtrToStructure(_this.Get()+ConsoleKey__Offset, typeof(FKey));}
			
		}
		
		static readonly int ConsoleKeys__Offset;
		/// <summary>The keys which open the console.</summary>
		public TStructArray<FKey> ConsoleKeys
		{
			get{ CheckIsValid();return new TStructArray<FKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ConsoleKeys__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ConsoleKeys__Offset, false);}
			
		}
		
		static UInputSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InputSettings");
			AxisConfig__Offset=GetPropertyOffset(NativeClassPtr,"AxisConfig");
			bAltEnterTogglesFullscreen__Offset=GetPropertyOffset(NativeClassPtr,"bAltEnterTogglesFullscreen");
			bF11TogglesFullscreen__Offset=GetPropertyOffset(NativeClassPtr,"bF11TogglesFullscreen");
			bUseMouseForTouch__Offset=GetPropertyOffset(NativeClassPtr,"bUseMouseForTouch");
			bEnableMouseSmoothing__Offset=GetPropertyOffset(NativeClassPtr,"bEnableMouseSmoothing");
			bEnableFOVScaling__Offset=GetPropertyOffset(NativeClassPtr,"bEnableFOVScaling");
			FOVScale__Offset=GetPropertyOffset(NativeClassPtr,"FOVScale");
			DoubleClickTime__Offset=GetPropertyOffset(NativeClassPtr,"DoubleClickTime");
			bCaptureMouseOnLaunch__Offset=GetPropertyOffset(NativeClassPtr,"bCaptureMouseOnLaunch");
			bDefaultViewportMouseLock__Offset=GetPropertyOffset(NativeClassPtr,"bDefaultViewportMouseLock");
			ActionMappings__Offset=GetPropertyOffset(NativeClassPtr,"ActionMappings");
			AxisMappings__Offset=GetPropertyOffset(NativeClassPtr,"AxisMappings");
			bAlwaysShowTouchInterface__Offset=GetPropertyOffset(NativeClassPtr,"bAlwaysShowTouchInterface");
			bShowConsoleOnFourFingerTap__Offset=GetPropertyOffset(NativeClassPtr,"bShowConsoleOnFourFingerTap");
			DefaultTouchInterface__Offset=GetPropertyOffset(NativeClassPtr,"DefaultTouchInterface");
			ConsoleKey__Offset=GetPropertyOffset(NativeClassPtr,"ConsoleKey");
			ConsoleKeys__Offset=GetPropertyOffset(NativeClassPtr,"ConsoleKeys");
			
		}
		
	}
	
}
#endif
#endif
