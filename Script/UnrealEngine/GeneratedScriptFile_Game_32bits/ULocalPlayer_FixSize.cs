#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULocalPlayer
	{
		static readonly int ViewportClient__Offset;
		public UGameViewportClient ViewportClient
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ViewportClient__Offset); if (v == IntPtr.Zero)return null; UGameViewportClient retValue = new UGameViewportClient(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AspectRatioAxisConstraint__Offset;
		public EAspectRatioAxisConstraint AspectRatioAxisConstraint
		{
			get{ CheckIsValid();return (EAspectRatioAxisConstraint)Marshal.PtrToStructure(_this.Get()+AspectRatioAxisConstraint__Offset, typeof(EAspectRatioAxisConstraint));}
			
		}
		
		static readonly int PendingLevelPlayerControllerClass__Offset;
		public TSubclassOf<APlayerController>  PendingLevelPlayerControllerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PendingLevelPlayerControllerClass__Offset); return v; }
			
		}
		
		static readonly int bSentSplitJoin__Offset;
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
