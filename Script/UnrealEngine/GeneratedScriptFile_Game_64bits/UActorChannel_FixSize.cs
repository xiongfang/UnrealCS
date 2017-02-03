#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UActorChannel
	{
		static readonly int Actor__Offset;
		public AActor Actor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Actor__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static UActorChannel()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ActorChannel");
			Actor__Offset=GetPropertyOffset(NativeClassPtr,"Actor");
			
		}
		
	}
	
}
#endif
#endif
