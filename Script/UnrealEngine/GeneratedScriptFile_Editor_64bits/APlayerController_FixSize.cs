#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// PlayerControllers are used by human players to control Pawns.
	/// ControlRotation (accessed via GetControlRotation()), determines the aiming
	/// orientation of the controlled Pawn.
	/// In networked games, PlayerControllers exist on the server for every player-controlled pawn,
	/// and also on the controlling client's machine. They do NOT exist on a client's
	/// machine for pawns controlled by remote players elsewhere on the network.
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Controller/PlayerController/
	/// </summary>
	public partial class APlayerController
	{
		static readonly int Player__Offset;
		/// <summary>UPlayer associated with this PlayerController.  Could be a local player or a net connection.</summary>
		public UPlayer Player
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Player__Offset); if (v == IntPtr.Zero)return null; UPlayer retValue = new UPlayer(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int AcknowledgedPawn__Offset;
		/// <summary>Used in net games so client can acknowledge it possessed a specific pawn.</summary>
		public APawn AcknowledgedPawn
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AcknowledgedPawn__Offset); if (v == IntPtr.Zero)return null; APawn retValue = new APawn(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ControllingDirTrackInst__Offset;
		/// <summary>Director track that's currently possessing this player controller, or none if not possessed.</summary>
		public UInterpTrackInstDirector ControllingDirTrackInst
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ControllingDirTrackInst__Offset); if (v == IntPtr.Zero)return null; UInterpTrackInstDirector retValue = new UInterpTrackInstDirector(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int MyHUD__Offset;
		/// <summary>Heads up display associated with this PlayerController.</summary>
		public AHUD MyHUD
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + MyHUD__Offset); if (v == IntPtr.Zero)return null; AHUD retValue = new AHUD(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayerCameraManager__Offset;
		/// <summary>Camera manager associated with this Player Controller.</summary>
		public APlayerCameraManager PlayerCameraManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerCameraManager__Offset); if (v == IntPtr.Zero)return null; APlayerCameraManager retValue = new APlayerCameraManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PlayerCameraManagerClass__Offset;
		/// <summary>PlayerCamera class should be set for each game, otherwise Engine.PlayerCameraManager is used</summary>
		public TSubclassOf<APlayerCameraManager>  PlayerCameraManagerClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PlayerCameraManagerClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + PlayerCameraManagerClass__Offset, value); }
			
		}
		
		static readonly int bAutoManageActiveCameraTarget__Offset;
		/// <summary>
		/// True to allow this player controller to manage the camera target for you,
		/// typically by using the possessed pawn as the camera target. Set to false
		/// if you want to manually control the camera target.
		/// </summary>
		public bool bAutoManageActiveCameraTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoManageActiveCameraTarget__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoManageActiveCameraTarget__Offset, 1,0,1,255);}
			
		}
		
		static readonly int TargetViewRotation__Offset;
		/// <summary>Used to replicate the view rotation of targets not owned/possessed by this PlayerController.</summary>
		public FRotator TargetViewRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+TargetViewRotation__Offset, typeof(FRotator));}
			
		}
		
		static readonly int SmoothTargetViewRotationSpeed__Offset;
		/// <summary>Interp speed for blending remote view rotation for smoother client updates</summary>
		public float SmoothTargetViewRotationSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SmoothTargetViewRotationSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SmoothTargetViewRotationSpeed__Offset, false);}
			
		}
		
		static readonly int HiddenActors__Offset;
		/// <summary>The actors which the camera shouldn't see - e.g. used to hide actors which the camera penetrates</summary>
		public TObjectArray<AActor>  HiddenActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+HiddenActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+HiddenActors__Offset, false);}
			
		}
		
		static readonly int LastSpectatorStateSynchTime__Offset;
		/// <summary>Used to make sure the client is kept synchronized when in a spectator state</summary>
		public float LastSpectatorStateSynchTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastSpectatorStateSynchTime__Offset, typeof(float));}
			
		}
		
		static readonly int LastSpectatorSyncLocation__Offset;
		/// <summary>Last location synced on the server for a spectator.</summary>
		public FVector LastSpectatorSyncLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+LastSpectatorSyncLocation__Offset, typeof(FVector));}
			
		}
		
		static readonly int LastSpectatorSyncRotation__Offset;
		/// <summary>Last rotation synced on the server for a spectator.</summary>
		public FRotator LastSpectatorSyncRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+LastSpectatorSyncRotation__Offset, typeof(FRotator));}
			
		}
		
		static readonly int ClientCap__Offset;
		/// <summary>Cap set by server on bandwidth from client to server in bytes/sec (only has impact if >=2600)</summary>
		public int ClientCap
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ClientCap__Offset, typeof(int));}
			
		}
		
		static readonly int CheatManager__Offset;
		/// <summary>Object that manages "cheat" commands.  Not instantiated in shipping builds.</summary>
		public UCheatManager CheatManager
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CheatManager__Offset); if (v == IntPtr.Zero)return null; UCheatManager retValue = new UCheatManager(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CheatClass__Offset;
		/// <summary>Class of my CheatManager.  The Cheat Manager is not created in shipping builds</summary>
		public TSubclassOf<UCheatManager>  CheatClass
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CheatClass__Offset); return v; }
			set{ CheckIsValid(); Marshal.WriteIntPtr(_this.Get() + CheatClass__Offset, value); }
			
		}
		
		static readonly int PlayerInput__Offset;
		/// <summary>Object that manages player input.</summary>
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
		/// <summary>True if PlayerController is currently waiting for the match to start or to respawn. Only valid in Spectating state.</summary>
		public bool bPlayerIsWaiting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPlayerIsWaiting__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPlayerIsWaiting__Offset, 1,0,8,8);}
			
		}
		
		static readonly int NetPlayerIndex__Offset;
		/// <summary>
		/// index identifying players using the same base connection (splitscreen clients)
		/// Used by netcode to match replicated PlayerControllers to the correct splitscreen viewport and child connection
		/// replicated via special internal code, not through normal variable replication
		/// </summary>
		public byte NetPlayerIndex
		{
			get{ CheckIsValid();return (byte)Marshal.PtrToStructure(_this.Get()+NetPlayerIndex__Offset, typeof(byte));}
			
		}
		
		static readonly int PendingSwapConnection__Offset;
		/// <summary>
		/// this is set on the OLD PlayerController when performing a swap over a network connection
		/// so we know what connection we're waiting on acknowledgment from to finish destroying this PC
		/// (or when the connection is closed)
		/// @see GameModeBase::SwapPlayerControllers()
		/// </summary>
		public UNetConnection PendingSwapConnection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PendingSwapConnection__Offset); if (v == IntPtr.Zero)return null; UNetConnection retValue = new UNetConnection(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int NetConnection__Offset;
		/// <summary>The net connection this controller is communicating on, NULL for local players on server</summary>
		public UNetConnection NetConnection
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + NetConnection__Offset); if (v == IntPtr.Zero)return null; UNetConnection retValue = new UNetConnection(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InputYawScale__Offset;
		/// <summary>Yaw input speed scaling</summary>
		public float InputYawScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InputYawScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputYawScale__Offset, false);}
			
		}
		
		static readonly int InputPitchScale__Offset;
		/// <summary>Pitch input speed scaling</summary>
		public float InputPitchScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InputPitchScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputPitchScale__Offset, false);}
			
		}
		
		static readonly int InputRollScale__Offset;
		/// <summary>Roll input speed scaling</summary>
		public float InputRollScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InputRollScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputRollScale__Offset, false);}
			
		}
		
		static readonly int bShowMouseCursor__Offset;
		/// <summary>Whether the mouse cursor should be displayed.</summary>
		public bool bShowMouseCursor
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShowMouseCursor__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bShowMouseCursor__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnableClickEvents__Offset;
		/// <summary>Whether actor/component click events should be generated.</summary>
		public bool bEnableClickEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableClickEvents__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableClickEvents__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bEnableTouchEvents__Offset;
		/// <summary>Whether actor/component touch events should be generated.</summary>
		public bool bEnableTouchEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableTouchEvents__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableTouchEvents__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bEnableMouseOverEvents__Offset;
		/// <summary>Whether actor/component mouse over events should be generated.</summary>
		public bool bEnableMouseOverEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableMouseOverEvents__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableMouseOverEvents__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bEnableTouchOverEvents__Offset;
		/// <summary>Whether actor/component touch over events should be generated.</summary>
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
		/// <summary>Default trace channel used for determining what world object was clicked on.</summary>
		public ECollisionChannel DefaultClickTraceChannel
		{
			get{ CheckIsValid();return (ECollisionChannel)Marshal.PtrToStructure(_this.Get()+DefaultClickTraceChannel__Offset, typeof(ECollisionChannel));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DefaultClickTraceChannel__Offset, false);}
			
		}
		
		static readonly int CurrentClickTraceChannel__Offset;
		/// <summary>Trace channel currently being used for determining what world object was clicked on.</summary>
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
		/// <summary>InputComponent we use when player is in Inactive state.</summary>
		public UInputComponent InactiveStateInputComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InactiveStateInputComponent__Offset); if (v == IntPtr.Zero)return null; UInputComponent retValue = new UInputComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CurrentTouchInterface__Offset;
		/// <summary>The currently set touch interface</summary>
		public UTouchInterface CurrentTouchInterface
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurrentTouchInterface__Offset); if (v == IntPtr.Zero)return null; UTouchInterface retValue = new UTouchInterface(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpectatorPawn__Offset;
		/// <summary>The pawn used when spectating (NULL if not spectating).</summary>
		public ASpectatorPawn SpectatorPawn
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + SpectatorPawn__Offset); if (v == IntPtr.Zero)return null; ASpectatorPawn retValue = new ASpectatorPawn(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpawnLocation__Offset;
		/// <summary>The location used internally when there is no pawn or spectator, to know where to spawn the spectator or focus the camera on death.</summary>
		public FVector SpawnLocation
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+SpawnLocation__Offset, typeof(FVector));}
			
		}
		
		static readonly int bIsLocalPlayerController__Offset;
		/// <summary>Set during SpawnActor once and never again to indicate the intent of this controller instance (SERVER ONLY)</summary>
		public bool bIsLocalPlayerController
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsLocalPlayerController__Offset, 1, 0, 1, 255);}
			
		}
		
		static readonly int SeamlessTravelCount__Offset;
		/// <summary>Counter for this players seamless travels (used along with the below value, to restrict ServerNotifyLoadedWorld)</summary>
		public ushort SeamlessTravelCount
		{
			get{ CheckIsValid();return (ushort)Marshal.PtrToStructure(_this.Get()+SeamlessTravelCount__Offset, typeof(ushort));}
			
		}
		
		static readonly int LastCompletedSeamlessTravelCount__Offset;
		/// <summary>The value of SeamlessTravelCount, upon the last call to GameModeBase::HandleSeamlessTravelPlayer; used to detect seamless travel</summary>
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
