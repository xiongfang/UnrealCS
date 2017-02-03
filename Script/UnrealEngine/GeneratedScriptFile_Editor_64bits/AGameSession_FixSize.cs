#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Acts as a game-specific wrapper around the session interface. The game code makes calls to this when it needs to interact with the session interface.
	/// A game session exists only the server, while running an online game.
	/// </summary>
	public partial class AGameSession
	{
		static readonly int MaxSpectators__Offset;
		/// <summary>Maximum number of spectators allowed by this server.</summary>
		public int MaxSpectators
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSpectators__Offset, typeof(int));}
			
		}
		
		static readonly int MaxPlayers__Offset;
		/// <summary>Maximum number of players allowed by this server.</summary>
		public int MaxPlayers
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxPlayers__Offset, typeof(int));}
			
		}
		
		static readonly int MaxPartySize__Offset;
		/// <summary>Restrictions on the largest party that can join together</summary>
		public int MaxPartySize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxPartySize__Offset, typeof(int));}
			
		}
		
		static readonly int MaxSplitscreensPerConnection__Offset;
		/// <summary>Maximum number of splitscreen players to allow from one connection</summary>
		public byte MaxSplitscreensPerConnection
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+MaxSplitscreensPerConnection__Offset, typeof(byte));}
			
		}
		
		static readonly int bRequiresPushToTalk__Offset;
		/// <summary>Is voice enabled always or via a push to talk keybinding</summary>
		public bool bRequiresPushToTalk
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRequiresPushToTalk__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int SessionName__Offset;
		/// <summary>SessionName local copy from PlayerState class.  should really be define in this class, but need to address replication issues</summary>
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
