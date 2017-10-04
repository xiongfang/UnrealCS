using System;
namespace UnrealEngine
{
	public partial class UCameraModifier:UObject
	{
		/// <summary>Enables this modifier.</summary>
		public extern virtual void EnableModifier();
		/// <summary>
		/// Disables this modifier.
		/// @param  bImmediate  - true to disable with no blend out, false (default) to allow blend out
		/// </summary>
		public extern virtual void DisableModifier(bool bImmediate=false);
		/// <summary>@return Returns the actor the camera is currently viewing.</summary>
		public extern virtual AActor GetViewTarget();
		/// <summary>@return Returns true if modifier is disabled, false otherwise.</summary>
		public extern virtual bool IsDisabled();
		/// <summary>If true, enables certain debug visualization features.</summary>
		public bool bDebug;
		
		/// <summary>If true, no other modifiers of same priority allowed.</summary>
		public bool bExclusive;
		
		/// <summary>Priority value that determines the order in which modifiers are applied. 0 = highest priority, 255 = lowest.</summary>
		public byte Priority;
		
		/// <summary>Camera this object is associated with.</summary>
		public APlayerCameraManager CameraOwner;
		
		/// <summary>When blending in, alpha proceeds from 0 to 1 over this time</summary>
		public float AlphaInTime;
		
		/// <summary>When blending out, alpha proceeds from 1 to 0 over this time</summary>
		public float AlphaOutTime;
		
		/// <summary>Current blend alpha.</summary>
		public float Alpha;
		
		
	}
	
}
