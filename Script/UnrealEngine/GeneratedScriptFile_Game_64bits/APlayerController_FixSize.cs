#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class APlayerController
	{
		static readonly int Player__Offset;
		public UPlayer Player
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Player__Offset); if (v == IntPtr.Zero)return null; UPlayer retValue = new UPlayer(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AcknowledgedPawn__Offset;
		public APawn AcknowledgedPawn
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AcknowledgedPawn__Offset); if (v == IntPtr.Zero)return null; APawn retValue = new APawn(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ControllingDirTrackInst__Offset;
		public UInterpTrackInstDirector ControllingDirTrackInst
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ControllingDirTrackInst__Offset); if (v == IntPtr.Zero)return null; UInterpTrackInstDirector retValue = new UInterpTrackInstDirector(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MyHUD__Offset;
		public AHUD MyHUD
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MyHUD__Offset); if (v == IntPtr.Zero)return null; AHUD retValue = new AHUD(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayerCameraManager__Offset;
		public APlayerCameraManager PlayerCameraManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerCameraManager__Offset); if (v == IntPtr.Zero)return null; APlayerCameraManager retValue = new APlayerCameraManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayerCameraManagerClass__Offset;
		public TSubclassOf<APlayerCameraManager>  PlayerCameraManagerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerCameraManagerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerCameraManagerClass__Offset, value); }
			
		}
		
		static readonly int bAutoManageActiveCameraTarget__Offset;
		public bool bAutoManageActiveCameraTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoManageActiveCameraTarget__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoManageActiveCameraTarget__Offset, 1,0,1,255);}
			
		}
		
		static readonly int TargetViewRotation__Offset;
		public FRotator TargetViewRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+TargetViewRotation__Offset, typeof(FRotator));}
			
		}
		
		static readonly int SmoothTargetViewRotationSpeed__Offset;
		public float SmoothTargetViewRotationSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SmoothTargetViewRotationSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SmoothTargetViewRotationSpeed__Offset, false);}
			
		}
		
		static readonly int HiddenActors__Offset;
		public TObjectArray<AActor>  HiddenActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HiddenActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HiddenActors__Offset, false);}
			
		}
		
		static readonly int LastSpectatorStateSynchTime__Offset;
		public float LastSpectatorStateSynchTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastSpectatorStateSynchTime__Offset, typeof(float));}
			
		}
		
		static readonly int LastSpectatorSyncLocation__Offset;
		public FVector LastSpectatorSyncLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LastSpectatorSyncLocation__Offset, typeof(FVector));}
			
		}
		
		static readonly int LastSpectatorSyncRotation__Offset;
		public FRotator LastSpectatorSyncRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+LastSpectatorSyncRotation__Offset, typeof(FRotator));}
			
		}
		
		static readonly int ClientCap__Offset;
		public int ClientCap
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ClientCap__Offset, typeof(int));}
			
		}
		
		static readonly int CheatManager__Offset;
		public UCheatManager CheatManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CheatManager__Offset); if (v == IntPtr.Zero)return null; UCheatManager retValue = new UCheatManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CheatClass__Offset;
		public TSubclassOf<UCheatManager>  CheatClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CheatClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + CheatClass__Offset, value); }
			
		}
		
		static readonly int PlayerInput__Offset;
		public UPlayerInput PlayerInput
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerInput__Offset); if (v == IntPtr.Zero)return null; UPlayerInput retValue = new UPlayerInput(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ActiveForceFeedbackEffects__Offset;
		public TStructArray<FActiveForceFeedbackEffect> ActiveForceFeedbackEffects
		{
			get{ CheckIsValid();return new TStructArray<FActiveForceFeedbackEffect>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActiveForceFeedbackEffects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActiveForceFeedbackEffects__Offset, false);}
			
		}
		
		static readonly int bPlayerIsWaiting__Offset;
		public bool bPlayerIsWaiting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPlayerIsWaiting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPlayerIsWaiting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int NetPlayerIndex__Offset;
		public byte NetPlayerIndex
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+NetPlayerIndex__Offset, typeof(byte));}
			
		}
		
		static readonly int PendingSwapConnection__Offset;
		public UNetConnection PendingSwapConnection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PendingSwapConnection__Offset); if (v == IntPtr.Zero)return null; UNetConnection retValue = new UNetConnection(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NetConnection__Offset;
		public UNetConnection NetConnection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NetConnection__Offset); if (v == IntPtr.Zero)return null; UNetConnection retValue = new UNetConnection(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InputYawScale__Offset;
		public float InputYawScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InputYawScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputYawScale__Offset, false);}
			
		}
		
		static readonly int InputPitchScale__Offset;
		public float InputPitchScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InputPitchScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputPitchScale__Offset, false);}
			
		}
		
		static readonly int InputRollScale__Offset;
		public float InputRollScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InputRollScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputRollScale__Offset, false);}
			
		}
		
		static readonly int bShowMouseCursor__Offset;
		public bool bShowMouseCursor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowMouseCursor__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowMouseCursor__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableClickEvents__Offset;
		public bool bEnableClickEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableClickEvents__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableClickEvents__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bEnableTouchEvents__Offset;
		public bool bEnableTouchEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableTouchEvents__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableTouchEvents__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bEnableMouseOverEvents__Offset;
		public bool bEnableMouseOverEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableMouseOverEvents__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableMouseOverEvents__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bEnableTouchOverEvents__Offset;
		public bool bEnableTouchOverEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableTouchOverEvents__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableTouchOverEvents__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bForceFeedbackEnabled__Offset;
		public bool bForceFeedbackEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceFeedbackEnabled__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceFeedbackEnabled__Offset, 1,0,32,32);}
			
		}
		
		static readonly int ClickEventKeys__Offset;
		public TStructArray<FKey> ClickEventKeys
		{
			get{ CheckIsValid();return new TStructArray<FKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ClickEventKeys__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ClickEventKeys__Offset, false);}
			
		}
		
		static readonly int DefaultMouseCursor__Offset;
		public EMouseCursor DefaultMouseCursor
		{
			get{ CheckIsValid();return (EMouseCursor)Marshal.PtrToStructure(_this.Get()+DefaultMouseCursor__Offset, typeof(EMouseCursor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultMouseCursor__Offset, false);}
			
		}
		
		static readonly int CurrentMouseCursor__Offset;
		public EMouseCursor CurrentMouseCursor
		{
			get{ CheckIsValid();return (EMouseCursor)Marshal.PtrToStructure(_this.Get()+CurrentMouseCursor__Offset, typeof(EMouseCursor));}
			
		}
		
		static readonly int DefaultClickTraceChannel__Offset;
		public ECollisionChannel DefaultClickTraceChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+DefaultClickTraceChannel__Offset, typeof(ECollisionChannel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultClickTraceChannel__Offset, false);}
			
		}
		
		static readonly int CurrentClickTraceChannel__Offset;
		public ECollisionChannel CurrentClickTraceChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+CurrentClickTraceChannel__Offset, typeof(ECollisionChannel));}
			
		}
		
		static readonly int HitResultTraceDistance__Offset;
		public float HitResultTraceDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+HitResultTraceDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+HitResultTraceDistance__Offset, false);}
			
		}
		
		static readonly int InactiveStateInputComponent__Offset;
		public UInputComponent InactiveStateInputComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InactiveStateInputComponent__Offset); if (v == IntPtr.Zero)return null; UInputComponent retValue = new UInputComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CurrentTouchInterface__Offset;
		public UTouchInterface CurrentTouchInterface
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentTouchInterface__Offset); if (v == IntPtr.Zero)return null; UTouchInterface retValue = new UTouchInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpectatorPawn__Offset;
		public ASpectatorPawn SpectatorPawn
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpectatorPawn__Offset); if (v == IntPtr.Zero)return null; ASpectatorPawn retValue = new ASpectatorPawn(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpawnLocation__Offset;
		public FVector SpawnLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+SpawnLocation__Offset, typeof(FVector));}
			
		}
		
		static readonly int bIsLocalPlayerController__Offset;
		public bool bIsLocalPlayerController
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsLocalPlayerController__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int SeamlessTravelCount__Offset;
		public ushort SeamlessTravelCount
		{
			get{ CheckIsValid();return (ushort)Marshal.PtrToStructure(_this.Get()+SeamlessTravelCount__Offset, typeof(ushort));}
			
		}
		
		static readonly int LastCompletedSeamlessTravelCount__Offset;
		public ushort LastCompletedSeamlessTravelCount
		{
			get{ CheckIsValid();return (ushort)Marshal.PtrToStructure(_this.Get()+LastCompletedSeamlessTravelCount__Offset, typeof(ushort));}
			
		}
		
		static APlayerController()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PlayerController");
			Player__Offset=GetPropertyOffset(NativeClassPtr,"Player");
			AcknowledgedPawn__Offset=GetPropertyOffset(NativeClassPtr,"AcknowledgedPawn");
			ControllingDirTrackInst__Offset=GetPropertyOffset(NativeClassPtr,"ControllingDirTrackInst");
			MyHUD__Offset=GetPropertyOffset(NativeClassPtr,"MyHUD");
			PlayerCameraManager__Offset=GetPropertyOffset(NativeClassPtr,"PlayerCameraManager");
			PlayerCameraManagerClass__Offset=GetPropertyOffset(NativeClassPtr,"PlayerCameraManagerClass");
			bAutoManageActiveCameraTarget__Offset=GetPropertyOffset(NativeClassPtr,"bAutoManageActiveCameraTarget");
			TargetViewRotation__Offset=GetPropertyOffset(NativeClassPtr,"TargetViewRotation");
			SmoothTargetViewRotationSpeed__Offset=GetPropertyOffset(NativeClassPtr,"SmoothTargetViewRotationSpeed");
			HiddenActors__Offset=GetPropertyOffset(NativeClassPtr,"HiddenActors");
			LastSpectatorStateSynchTime__Offset=GetPropertyOffset(NativeClassPtr,"LastSpectatorStateSynchTime");
			LastSpectatorSyncLocation__Offset=GetPropertyOffset(NativeClassPtr,"LastSpectatorSyncLocation");
			LastSpectatorSyncRotation__Offset=GetPropertyOffset(NativeClassPtr,"LastSpectatorSyncRotation");
			ClientCap__Offset=GetPropertyOffset(NativeClassPtr,"ClientCap");
			CheatManager__Offset=GetPropertyOffset(NativeClassPtr,"CheatManager");
			CheatClass__Offset=GetPropertyOffset(NativeClassPtr,"CheatClass");
			PlayerInput__Offset=GetPropertyOffset(NativeClassPtr,"PlayerInput");
			ActiveForceFeedbackEffects__Offset=GetPropertyOffset(NativeClassPtr,"ActiveForceFeedbackEffects");
			bPlayerIsWaiting__Offset=GetPropertyOffset(NativeClassPtr,"bPlayerIsWaiting");
			NetPlayerIndex__Offset=GetPropertyOffset(NativeClassPtr,"NetPlayerIndex");
			PendingSwapConnection__Offset=GetPropertyOffset(NativeClassPtr,"PendingSwapConnection");
			NetConnection__Offset=GetPropertyOffset(NativeClassPtr,"NetConnection");
			InputYawScale__Offset=GetPropertyOffset(NativeClassPtr,"InputYawScale");
			InputPitchScale__Offset=GetPropertyOffset(NativeClassPtr,"InputPitchScale");
			InputRollScale__Offset=GetPropertyOffset(NativeClassPtr,"InputRollScale");
			bShowMouseCursor__Offset=GetPropertyOffset(NativeClassPtr,"bShowMouseCursor");
			bEnableClickEvents__Offset=GetPropertyOffset(NativeClassPtr,"bEnableClickEvents");
			bEnableTouchEvents__Offset=GetPropertyOffset(NativeClassPtr,"bEnableTouchEvents");
			bEnableMouseOverEvents__Offset=GetPropertyOffset(NativeClassPtr,"bEnableMouseOverEvents");
			bEnableTouchOverEvents__Offset=GetPropertyOffset(NativeClassPtr,"bEnableTouchOverEvents");
			bForceFeedbackEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bForceFeedbackEnabled");
			ClickEventKeys__Offset=GetPropertyOffset(NativeClassPtr,"ClickEventKeys");
			DefaultMouseCursor__Offset=GetPropertyOffset(NativeClassPtr,"DefaultMouseCursor");
			CurrentMouseCursor__Offset=GetPropertyOffset(NativeClassPtr,"CurrentMouseCursor");
			DefaultClickTraceChannel__Offset=GetPropertyOffset(NativeClassPtr,"DefaultClickTraceChannel");
			CurrentClickTraceChannel__Offset=GetPropertyOffset(NativeClassPtr,"CurrentClickTraceChannel");
			HitResultTraceDistance__Offset=GetPropertyOffset(NativeClassPtr,"HitResultTraceDistance");
			InactiveStateInputComponent__Offset=GetPropertyOffset(NativeClassPtr,"InactiveStateInputComponent");
			CurrentTouchInterface__Offset=GetPropertyOffset(NativeClassPtr,"CurrentTouchInterface");
			SpectatorPawn__Offset=GetPropertyOffset(NativeClassPtr,"SpectatorPawn");
			SpawnLocation__Offset=GetPropertyOffset(NativeClassPtr,"SpawnLocation");
			bIsLocalPlayerController__Offset=GetPropertyOffset(NativeClassPtr,"bIsLocalPlayerController");
			SeamlessTravelCount__Offset=GetPropertyOffset(NativeClassPtr,"SeamlessTravelCount");
			LastCompletedSeamlessTravelCount__Offset=GetPropertyOffset(NativeClassPtr,"LastCompletedSeamlessTravelCount");
			
		}
		
	}
	
}
#endif
#endif
