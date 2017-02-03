#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Each player that is active on the current client has a LocalPlayer. It stays active across maps
	/// There may be several spawned in the case of splitscreen/coop.
	/// There may be 0 spawned on servers.
	/// </summary>
	public partial class ULocalPlayer
	{
		static readonly int ViewportClient__Offset;
		/// <summary>The master viewport containing this player's view.</summary>
		public UGameViewportClient ViewportClient
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ViewportClient__Offset); if (v == IntPtr.Zero)return null; UGameViewportClient retValue = new UGameViewportClient(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AspectRatioAxisConstraint__Offset;
		/// <summary>How to constrain perspective viewport FOV</summary>
		public EAspectRatioAxisConstraint AspectRatioAxisConstraint
		{
			get{ CheckIsValid();return (EAspectRatioAxisConstraint)Marshal.PtrToStructure(_this.Get()+AspectRatioAxisConstraint__Offset, typeof(EAspectRatioAxisConstraint));}
			
		}
		
		static readonly int PendingLevelPlayerControllerClass__Offset;
		/// <summary>The class of PlayerController to spawn for players logging in.</summary>
		public TSubclassOf<APlayerController>  PendingLevelPlayerControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PendingLevelPlayerControllerClass__Offset); return v; }
			
		}
		
		static readonly int bSentSplitJoin__Offset;
		/// <summary>set when we've sent a split join request</summary>
		public bool bSentSplitJoin
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSentSplitJoin__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSentSplitJoin__Offset, 1,0,1,1);}
			
		}
		
		static ULocalPlayer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LocalPlayer");
			ViewportClient__Offset=GetPropertyOffset(NativeClassPtr,"ViewportClient");
			AspectRatioAxisConstraint__Offset=GetPropertyOffset(NativeClassPtr,"AspectRatioAxisConstraint");
			PendingLevelPlayerControllerClass__Offset=GetPropertyOffset(NativeClassPtr,"PendingLevelPlayerControllerClass");
			bSentSplitJoin__Offset=GetPropertyOffset(NativeClassPtr,"bSentSplitJoin");
			
		}
		
	}
	
}
#endif
#endif
