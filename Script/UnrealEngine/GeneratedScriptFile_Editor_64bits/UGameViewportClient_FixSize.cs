#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A game viewport (FViewport) is a high-level abstract interface for the
	/// platform specific rendering, audio, and input subsystems.
	/// GameViewportClient is the engine's interface to a game viewport.
	/// Exactly one GameViewportClient is created for each instance of the game.  The
	/// only case (so far) where you might have a single instance of Engine, but
	/// multiple instances of the game (and thus multiple GameViewportClients) is when
	/// you have more than one PIE window running.
	/// Responsibilities:
	/// propagating input events to the global interactions list
	/// @see UGameViewportClient
	/// </summary>
	public partial class UGameViewportClient
	{
		static readonly int ViewportConsole__Offset;
		/// <summary>The viewport's console.   Might be null on consoles</summary>
		public UConsole ViewportConsole
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ViewportConsole__Offset); if (v == IntPtr.Zero)return null; UConsole retValue = new UConsole(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int DebugProperties__Offset;
		/// <summary>@todo document</summary>
		public TStructArray<FDebugDisplayProperty> DebugProperties
		{
			get{ CheckIsValid();return new TStructArray<FDebugDisplayProperty>((FScriptArray)Marshal.PtrToStructure(_this.Get()+DebugProperties__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+DebugProperties__Offset, false);}
			
		}
		
		static readonly int World__Offset;
		/// <summary>The relative world context for this viewport</summary>
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
