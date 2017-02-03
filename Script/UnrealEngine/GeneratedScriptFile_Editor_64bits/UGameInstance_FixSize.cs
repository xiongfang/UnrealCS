#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// GameInstance: high-level manager object for an instance of the running game.
	/// Spawned at game creation and not destroyed until game instance is shut down.
	/// Running as a standalone game, there will be one of these.
	/// Running in PIE (play-in-editor) will generate one of these per PIE instance.
	/// </summary>
	public partial class UGameInstance
	{
		static readonly int LocalPlayers__Offset;
		public TObjectArray<ULocalPlayer>  LocalPlayers
		{
					get{ CheckIsValid();return new TObjectArray<ULocalPlayer>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LocalPlayers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LocalPlayers__Offset, false);}
			
		}
		
		static readonly int OnlineSession__Offset;
		/// <summary>Class to manage online services</summary>
		public UOnlineSession OnlineSession
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + OnlineSession__Offset); if (v == IntPtr.Zero)return null; UOnlineSession retValue = new UOnlineSession(); retValue._this = v; return retValue; }
			
		}
		
		static UGameInstance()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameInstance");
			LocalPlayers__Offset=GetPropertyOffset(NativeClassPtr,"LocalPlayers");
			OnlineSession__Offset=GetPropertyOffset(NativeClassPtr,"OnlineSession");
			
		}
		
	}
	
}
#endif
#endif
