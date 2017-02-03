#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UGameInstance
	{
		static readonly int LocalPlayers__Offset;
		public TObjectArray<ULocalPlayer>  LocalPlayers
		{
					get{ CheckIsValid();return new TObjectArray<ULocalPlayer>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LocalPlayers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LocalPlayers__Offset, false);}
			
		}
		
		static readonly int OnlineSession__Offset;
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
