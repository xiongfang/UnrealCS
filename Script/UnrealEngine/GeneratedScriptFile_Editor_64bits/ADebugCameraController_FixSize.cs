#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Camera controller that allows you to fly around a level mostly unrestricted by normal movement rules.
	/// To turn it on, please press Alt+C or both (left and right) analogs on XBox pad,
	/// or use the "ToggleDebugCamera" console command. Check the debug camera bindings
	/// in DefaultPawn.cpp for the camera controls.
	/// </summary>
	public partial class ADebugCameraController
	{
		static readonly int bShowSelectedInfo__Offset;
		/// <summary>Whether to show information about the selected actor on the debug camera HUD.</summary>
		public bool bShowSelectedInfo
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowSelectedInfo__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIsFrozenRendering__Offset;
		/// <summary>@todo document</summary>
		public bool bIsFrozenRendering
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsFrozenRendering__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int DrawFrustum__Offset;
		/// <summary>@todo document</summary>
		public UDrawFrustumComponent DrawFrustum
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DrawFrustum__Offset); if (v == IntPtr.Zero)return null; UDrawFrustumComponent retValue = new UDrawFrustumComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpeedScale__Offset;
		/// <summary>Allows control over the speed of the spectator pawn. This scales the speed based on the InitialMaxSpeed. Use Set Pawn Movement Speed Scale during runtime</summary>
		public float SpeedScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpeedScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpeedScale__Offset, false);}
			
		}
		
		static readonly int InitialMaxSpeed__Offset;
		/// <summary>Initial max speed of the spectator pawn when we start possession.</summary>
		public float InitialMaxSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialMaxSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialMaxSpeed__Offset, false);}
			
		}
		
		static readonly int InitialAccel__Offset;
		/// <summary>Initial acceleration of the spectator pawn when we start possession.</summary>
		public float InitialAccel
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialAccel__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialAccel__Offset, false);}
			
		}
		
		static readonly int InitialDecel__Offset;
		/// <summary>Initial deceleration of the spectator pawn when we start possession.</summary>
		public float InitialDecel
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialDecel__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialDecel__Offset, false);}
			
		}
		
		static ADebugCameraController()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DebugCameraController");
			bShowSelectedInfo__Offset=GetPropertyOffset(NativeClassPtr,"bShowSelectedInfo");
			bIsFrozenRendering__Offset=GetPropertyOffset(NativeClassPtr,"bIsFrozenRendering");
			DrawFrustum__Offset=GetPropertyOffset(NativeClassPtr,"DrawFrustum");
			SpeedScale__Offset=GetPropertyOffset(NativeClassPtr,"SpeedScale");
			InitialMaxSpeed__Offset=GetPropertyOffset(NativeClassPtr,"InitialMaxSpeed");
			InitialAccel__Offset=GetPropertyOffset(NativeClassPtr,"InitialAccel");
			InitialDecel__Offset=GetPropertyOffset(NativeClassPtr,"InitialDecel");
			
		}
		
	}
	
}
#endif
#endif
