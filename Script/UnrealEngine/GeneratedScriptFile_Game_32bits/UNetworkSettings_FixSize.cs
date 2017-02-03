#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNetworkSettings
	{
		static readonly int bVerifyPeer__Offset;
		public bool bVerifyPeer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVerifyPeer__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVerifyPeer__Offset, 1,0,1,1);}
			
		}
		
		static UNetworkSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NetworkSettings");
			bVerifyPeer__Offset=GetPropertyOffset(NativeClassPtr,"bVerifyPeer");
			
		}
		
	}
	
}
#endif
#endif
