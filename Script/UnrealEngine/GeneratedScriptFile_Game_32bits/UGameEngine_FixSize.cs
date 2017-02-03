#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UGameEngine
	{
		static readonly int MaxDeltaTime__Offset;
		public float MaxDeltaTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxDeltaTime__Offset, typeof(float));}
			
		}
		
		static readonly int ServerFlushLogInterval__Offset;
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
