#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Cheat Manager is a central blueprint to implement test and debug code and actions that are not to ship with the game.
	/// As the Cheat Manager is not instanced in shipping builds, it is for debugging purposes only
	/// </summary>
	public partial class UCheatManager
	{
		static readonly int DebugCameraControllerRef__Offset;
		/// <summary>Debug camera - used to have independent camera without stopping gameplay</summary>
		public ADebugCameraController DebugCameraControllerRef
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DebugCameraControllerRef__Offset); if (v == IntPtr.Zero)return null; ADebugCameraController retValue = new ADebugCameraController(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DebugCameraControllerClass__Offset;
		/// <summary>Debug camera - used to have independent camera without stopping gameplay</summary>
		public TSubclassOf<ADebugCameraController>  DebugCameraControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DebugCameraControllerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + DebugCameraControllerClass__Offset, value); }
			
		}
		
		static UCheatManager()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("CheatManager");
			DebugCameraControllerRef__Offset=GetPropertyOffset(NativeClassPtr,"DebugCameraControllerRef");
			DebugCameraControllerClass__Offset=GetPropertyOffset(NativeClassPtr,"DebugCameraControllerClass");
			
		}
		
	}
	
}
#endif
#endif
