#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AGameSession
	{
		static readonly int MaxSpectators__Offset;
		public int MaxSpectators
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSpectators__Offset, typeof(int));}
			
		}
		
		static readonly int MaxPlayers__Offset;
		public int MaxPlayers
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxPlayers__Offset, typeof(int));}
			
		}
		
		static readonly int MaxPartySize__Offset;
		public int MaxPartySize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxPartySize__Offset, typeof(int));}
			
		}
		
		static readonly int MaxSplitscreensPerConnection__Offset;
		public byte MaxSplitscreensPerConnection
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+MaxSplitscreensPerConnection__Offset, typeof(byte));}
			
		}
		
		static readonly int bRequiresPushToTalk__Offset;
		public bool bRequiresPushToTalk
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequiresPushToTalk__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int SessionName__Offset;
		public FName SessionName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SessionName__Offset, typeof(FName));}
			
		}
		
		static AGameSession()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("GameSession");
			MaxSpectators__Offset=GetPropertyOffset(NativeClassPtr,"MaxSpectators");
			MaxPlayers__Offset=GetPropertyOffset(NativeClassPtr,"MaxPlayers");
			MaxPartySize__Offset=GetPropertyOffset(NativeClassPtr,"MaxPartySize");
			MaxSplitscreensPerConnection__Offset=GetPropertyOffset(NativeClassPtr,"MaxSplitscreensPerConnection");
			bRequiresPushToTalk__Offset=GetPropertyOffset(NativeClassPtr,"bRequiresPushToTalk");
			SessionName__Offset=GetPropertyOffset(NativeClassPtr,"SessionName");
			
		}
		
	}
	
}
#endif
#endif
