#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Engine that manages core systems that enable a game.</summary>
	public partial class UGameEngine
	{
		static readonly int MaxDeltaTime__Offset;
		/// <summary>Maximium delta time the engine uses to populate FApp::DeltaTime. If 0, unbound.</summary>
		public float MaxDeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDeltaTime__Offset, typeof(float));}
			
		}
		
		static readonly int ServerFlushLogInterval__Offset;
		/// <summary>Maximium time (in seconds) between the flushes of the logs on the server (best effort). If 0, this will happen every tick.</summary>
		public float ServerFlushLogInterval
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ServerFlushLogInterval__Offset, typeof(float));}
			
		}
		
		static readonly int GameInstance__Offset;
		public UGameInstance GameInstance
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GameInstance__Offset); if (v == IntPtr.Zero)return null; UGameInstance retValue = new UGameInstance(); retValue._this = v; return retValue; }
			
		}
		
		static UGameEngine()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameEngine");
			MaxDeltaTime__Offset=GetPropertyOffset(NativeClassPtr,"MaxDeltaTime");
			ServerFlushLogInterval__Offset=GetPropertyOffset(NativeClassPtr,"ServerFlushLogInterval");
			GameInstance__Offset=GetPropertyOffset(NativeClassPtr,"GameInstance");
			
		}
		
	}
	
}
#endif
#endif
