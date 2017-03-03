#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Network settings.</summary>
	public partial class UNetworkSettings
	{
		static readonly int bVerifyPeer__Offset;
		/// <summary>If true, libcurl authenticates the peer's certificate. Disable to allow self-signed certificates.</summary>
		public bool bVerifyPeer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVerifyPeer__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVerifyPeer__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableMultiplayerWorldOriginRebasing__Offset;
		/// <summary>If true, origin rebasing is enabled in multiplayer games, meaning that servers and clients can have different local world origins.</summary>
		public bool bEnableMultiplayerWorldOriginRebasing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableMultiplayerWorldOriginRebasing__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableMultiplayerWorldOriginRebasing__Offset, 1,0,2,2);}
			
		}
		
		static readonly int MaxRepArraySize__Offset;
		/// <summary>Maximum allowable size for replicated dynamic arrays (in number of elements). Must be between 1 and 65535.</summary>
		public int MaxRepArraySize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxRepArraySize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxRepArraySize__Offset, false);}
			
		}
		
		static readonly int MaxRepArrayMemory__Offset;
		/// <summary>Maximum allowable size for replicated dynamic arrays (in bytes).  Must be between 1 and 65535.</summary>
		public int MaxRepArrayMemory
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxRepArrayMemory__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxRepArrayMemory__Offset, false);}
			
		}
		
		static UNetworkSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NetworkSettings");
			bVerifyPeer__Offset=GetPropertyOffset(NativeClassPtr,"bVerifyPeer");
			bEnableMultiplayerWorldOriginRebasing__Offset=GetPropertyOffset(NativeClassPtr,"bEnableMultiplayerWorldOriginRebasing");
			MaxRepArraySize__Offset=GetPropertyOffset(NativeClassPtr,"MaxRepArraySize");
			MaxRepArrayMemory__Offset=GetPropertyOffset(NativeClassPtr,"MaxRepArrayMemory");
			
		}
		
	}
	
}
#endif
#endif
