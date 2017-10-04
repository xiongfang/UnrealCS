using System;
namespace UnrealEngine
{
	public partial class UInputSettings:UObject
	{
		public bool bAltEnterTogglesFullscreen;
		
		public bool bF11TogglesFullscreen;
		
		/// <summary>Allow mouse to be used for touch</summary>
		public bool bUseMouseForTouch;
		
		/// <summary>Mouse smoothing control</summary>
		public bool bEnableMouseSmoothing;
		
		/// <summary>Scale the mouse based on the player camera manager's field of view</summary>
		public bool bEnableFOVScaling;
		
		/// <summary>The scaling value to multiply the field of view by</summary>
		public float FOVScale;
		
		/// <summary>If a key is pressed twice in this amount of time it is considered a "double click"</summary>
		public float DoubleClickTime;
		
		/// <summary>Controls if the viewport will capture the mouse on Launch of the application</summary>
		public bool bCaptureMouseOnLaunch;
		
		/// <summary>The default mouse lock state when the viewport acquires capture</summary>
		public bool bDefaultViewportMouseLock;
		
		/// <summary>Should the touch input interface be shown always, or only when the platform has a touch screen?</summary>
		public bool bAlwaysShowTouchInterface;
		
		/// <summary>Whether or not to show the console on 4 finger tap, on mobile platforms</summary>
		public bool bShowConsoleOnFourFingerTap;
		
		/// <summary>The default on-screen touch input interface for the game (can be null to disable the onscreen interface)</summary>
		public FStringAssetReference DefaultTouchInterface;
		
		/// <summary>The key which opens the console.</summary>
		public FKey ConsoleKey;
		
		
	}
	
}
