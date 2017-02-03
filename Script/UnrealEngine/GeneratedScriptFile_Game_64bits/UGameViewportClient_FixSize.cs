#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UGameViewportClient
	{
		static readonly int ViewportConsole__Offset;
		public UConsole ViewportConsole
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ViewportConsole__Offset); if (v == IntPtr.Zero)return null; UConsole retValue = new UConsole(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DebugProperties__Offset;
		public TStructArray<FDebugDisplayProperty> DebugProperties
		{
			get{ CheckIsValid();return new TStructArray<FDebugDisplayProperty>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DebugProperties__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DebugProperties__Offset, false);}
			
		}
		
		static readonly int World__Offset;
		public UWorld World
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + World__Offset); if (v == IntPtr.Zero)return null; UWorld retValue = new UWorld(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int GameInstance__Offset;
		public UGameInstance GameInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameInstance__Offset); if (v == IntPtr.Zero)return null; UGameInstance retValue = new UGameInstance(); retValue._this = v; return retValue; }
			
		}
		
		static UGameViewportClient()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameViewportClient");
			ViewportConsole__Offset=GetPropertyOffset(NativeClassPtr,"ViewportConsole");
			DebugProperties__Offset=GetPropertyOffset(NativeClassPtr,"DebugProperties");
			World__Offset=GetPropertyOffset(NativeClassPtr,"World");
			GameInstance__Offset=GetPropertyOffset(NativeClassPtr,"GameInstance");
			
		}
		
	}
	
}
#endif
#endif
