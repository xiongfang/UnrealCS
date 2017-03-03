#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Actor is the base class for an Object that can be placed or spawned in a level.
	/// Actors may contain a collection of ActorComponents, which can be used to control how actors move, how they are rendered, etc.
	/// The other main function of an Actor is the replication of properties and function calls across the network during play.
	/// @see https://docs.unrealengine.com/latest/INT/Programming/UnrealArchitecture/Actors/
	/// @see UActorComponent
	/// </summary>
	public partial class AActor
	{
		static readonly int PrimaryActorTick__Offset;
		/// <summary>
		/// Primary Actor tick function, which calls TickActor().
		/// Tick functions can be configured to control whether ticking is enabled, at what time during a frame the update occurs, and to set up tick dependencies.
		/// @see https://docs.unrealengine.com/latest/INT/API/Runtime/Engine/Engine/FTickFunction/
		/// @see AddTickPrerequisiteActor(), AddTickPrerequisiteComponent()
		/// </summary>
		public FActorTickFunction PrimaryActorTick
		{
			get{ CheckIsValid();return (FActorTickFunction)Marshal.PtrToStructure(_this.Get()+PrimaryActorTick__Offset, typeof(FActorTickFunction));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrimaryActorTick__Offset, false);}
			
		}
		
		static readonly int CustomTimeDilation__Offset;
		/// <summary>Allow each actor to run at a different time speed. The DeltaTime for a frame is multiplied by the global TimeDilation (in WorldSettings) and this CustomTimeDilation for this actor's tick.</summary>
		public float CustomTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CustomTimeDilation__Offset, typeof(float));}
			
		}
		
		static readonly int bHidden__Offset;
		/// <summary>
		/// Allows us to only see this Actor in the Editor, and not in the actual game.
		/// @see SetActorHiddenInGame()
		/// </summary>
		public bool bHidden
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHidden__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHidden__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bNetTemporary__Offset;
		/// <summary>If true, when the actor is spawned it will be sent to the client but receive no further replication updates from the server afterwards.</summary>
		public bool bNetTemporary
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetTemporary__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bNetStartup__Offset;
		/// <summary>If true, this actor was loaded directly from the map, and for networking purposes can be addressed by its full path name</summary>
		public bool bNetStartup
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetStartup__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bOnlyRelevantToOwner__Offset;
		/// <summary>If true, this actor is only relevant to its owner. If this flag is changed during play, all non-owner channels would need to be explicitly closed.</summary>
		public bool bOnlyRelevantToOwner
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlyRelevantToOwner__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOnlyRelevantToOwner__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAlwaysRelevant__Offset;
		/// <summary>Always relevant for network (overrides bOnlyRelevantToOwner).</summary>
		public bool bAlwaysRelevant
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysRelevant__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysRelevant__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bReplicateMovement__Offset;
		/// <summary>
		/// If true, replicate movement/location related properties.
		/// Actor must also be set to replicate.
		/// @see SetReplicates()
		/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Networking/Replication/
		/// </summary>
		public bool bReplicateMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicateMovement__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReplicateMovement__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bTearOff__Offset;
		/// <summary>
		/// If true, this actor is no longer replicated to new clients, and is "torn off" (becomes a ROLE_Authority) on clients to which it was being replicated.
		/// @see TornOff()
		/// </summary>
		public bool bTearOff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTearOff__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bExchangedRoles__Offset;
		/// <summary>
		/// Whether we have already exchanged Role/RemoteRole on the client, as when removing then re-adding a streaming level.
		/// Causes all initialization to be performed again even though the actor may not have actually been reloaded.
		/// </summary>
		public bool bExchangedRoles
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bExchangedRoles__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bPendingNetUpdate__Offset;
		/// <summary>Is this actor still pending a full net update due to clients that weren't able to replicate the actor at the time of LastNetUpdateTime</summary>
		public bool bPendingNetUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPendingNetUpdate__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bNetLoadOnClient__Offset;
		/// <summary>This actor will be loaded on network clients during map load</summary>
		public bool bNetLoadOnClient
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetLoadOnClient__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNetLoadOnClient__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bNetUseOwnerRelevancy__Offset;
		/// <summary>If actor has valid Owner, call Owner's IsNetRelevantFor and GetNetPriority</summary>
		public bool bNetUseOwnerRelevancy
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetUseOwnerRelevancy__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNetUseOwnerRelevancy__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bBlockInput__Offset;
		/// <summary>If true, all input on the stack below this actor will not be considered</summary>
		public bool bBlockInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBlockInput__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBlockInput__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAllowTickBeforeBeginPlay__Offset;
		/// <summary>
		/// Whether we allow this Actor to tick before it receives the BeginPlay event.
		/// Normally we don't tick actors until after BeginPlay; this setting allows this behavior to be overridden.
		/// This Actor must be able to tick for this setting to be relevant.
		/// </summary>
		public bool bAllowTickBeforeBeginPlay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowTickBeforeBeginPlay__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowTickBeforeBeginPlay__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bActorEnableCollision__Offset;
		/// <summary>
		/// Enables any collision on this actor.
		/// @see SetActorEnableCollision(), GetActorEnableCollision()
		/// </summary>
		public bool bActorEnableCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActorEnableCollision__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bReplicates__Offset;
		/// <summary>
		/// If true, this actor will replicate to remote machines
		/// @see SetReplicates()
		/// </summary>
		public bool bReplicates
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicates__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReplicates__Offset, 1,0,8,8);}
			
		}
		
		static readonly int NetDriverName__Offset;
		/// <summary>Used to specify the net driver to replicate on (NAME_None || NAME_GameNetDriver is the default net driver)</summary>
		public FName NetDriverName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+NetDriverName__Offset, typeof(FName));}
			
		}
		
		static readonly int RemoteRole__Offset;
		/// <summary>Describes how much control the remote machine has over the actor.</summary>
		public ENetRole RemoteRole
		{
			get{ CheckIsValid();return (ENetRole)Marshal.PtrToStructure(_this.Get()+RemoteRole__Offset, typeof(ENetRole));}
			
		}
		
		static readonly int Owner__Offset;
		/// <summary>
		/// Owner of this Actor, used primarily for replication (bNetUseOwnerRelevancy & bOnlyRelevantToOwner) and visibility (PrimitiveComponent bOwnerNoSee and bOnlyOwnerSee)
		/// @see SetOwner(), GetOwner()
		/// </summary>
		public AActor Owner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Owner__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ReplicatedMovement__Offset;
		/// <summary>Used for replication of our RootComponent's position and velocity</summary>
		public FRepMovement ReplicatedMovement
		{
			get{ CheckIsValid();return (FRepMovement)Marshal.PtrToStructure(_this.Get()+ReplicatedMovement__Offset, typeof(FRepMovement));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReplicatedMovement__Offset, false);}
			
		}
		
		static readonly int AttachmentReplication__Offset;
		/// <summary>
		/// Used for replicating attachment of this actor's RootComponent to another actor.
		/// This is filled in via GatherCurrentMovement() when the RootComponent has an AttachParent.
		/// </summary>
		public FRepAttachment AttachmentReplication
		{
			get{ CheckIsValid();return (FRepAttachment)Marshal.PtrToStructure(_this.Get()+AttachmentReplication__Offset, typeof(FRepAttachment));}
			
		}
		
		static readonly int Role__Offset;
		/// <summary>Describes how much control the local machine has over the actor.</summary>
		public ENetRole Role
		{
			get{ CheckIsValid();return (ENetRole)Marshal.PtrToStructure(_this.Get()+Role__Offset, typeof(ENetRole));}
			
		}
		
		static readonly int AutoReceiveInput__Offset;
		/// <summary>Automatically registers this actor to receive input from a player.</summary>
		public EAutoReceiveInput AutoReceiveInput
		{
			get{ CheckIsValid();return (EAutoReceiveInput)Marshal.PtrToStructure(_this.Get()+AutoReceiveInput__Offset, typeof(EAutoReceiveInput));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AutoReceiveInput__Offset, false);}
			
		}
		
		static readonly int InputPriority__Offset;
		/// <summary>The priority of this input component when pushed in to the stack.</summary>
		public int InputPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+InputPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputPriority__Offset, false);}
			
		}
		
		static readonly int InputComponent__Offset;
		/// <summary>Component that handles input for this actor, if input is enabled.</summary>
		public UInputComponent InputComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + InputComponent__Offset); if (v == IntPtr.Zero)return null; UInputComponent retValue = new UInputComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int InputConsumeOption__Offset;
		public EInputConsumeOptions InputConsumeOption
		{
			get{ CheckIsValid();return (EInputConsumeOptions)Marshal.PtrToStructure(_this.Get()+InputConsumeOption__Offset, typeof(EInputConsumeOptions));}
			
		}
		
		static readonly int NetCullDistanceSquared__Offset;
		/// <summary>Square of the max distance from the client's viewpoint that this actor is relevant and will be replicated.</summary>
		public float NetCullDistanceSquared
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetCullDistanceSquared__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetCullDistanceSquared__Offset, false);}
			
		}
		
		static readonly int NetTag__Offset;
		/// <summary>Internal - used by UWorld::ServerTickClients()</summary>
		public int NetTag
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NetTag__Offset, typeof(int));}
			
		}
		
		static readonly int NetUpdateTime__Offset;
		/// <summary>Next time this actor will be considered for replication, set by SetNetUpdateTime()</summary>
		public float NetUpdateTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetUpdateTime__Offset, typeof(float));}
			
		}
		
		static readonly int NetUpdateFrequency__Offset;
		/// <summary>How often (per second) this actor will be considered for replication, used to determine NetUpdateTime</summary>
		public float NetUpdateFrequency
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetUpdateFrequency__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetUpdateFrequency__Offset, false);}
			
		}
		
		static readonly int MinNetUpdateFrequency__Offset;
		/// <summary>Used to determine what rate to throttle down to when replicated properties are changing infrequently</summary>
		public float MinNetUpdateFrequency
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinNetUpdateFrequency__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinNetUpdateFrequency__Offset, false);}
			
		}
		
		static readonly int NetPriority__Offset;
		/// <summary>Priority for this actor when checking for replication in a low bandwidth or saturated situation, higher priority means it is more likely to replicate</summary>
		public float NetPriority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetPriority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetPriority__Offset, false);}
			
		}
		
		static readonly int LastNetUpdateTime__Offset;
		/// <summary>
		/// Last time this actor was updated for replication via NetUpdateTime
		/// @warning: internal net driver time, not related to WorldSettings.TimeSeconds
		/// </summary>
		public float LastNetUpdateTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastNetUpdateTime__Offset, typeof(float));}
			
		}
		
		static readonly int bAutoDestroyWhenFinished__Offset;
		/// <summary>If true then destroy self when "finished", meaning all relevant components report that they are done and no timelines or timers are in flight.</summary>
		public bool bAutoDestroyWhenFinished
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoDestroyWhenFinished__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bCanBeDamaged__Offset;
		/// <summary>
		/// Whether this actor can take damage. Must be true for damage events (e.g. ReceiveDamage()) to be called.
		/// @see https://www.unrealengine.com/blog/damage-in-ue4
		/// @see TakeDamage(), ReceiveDamage()
		/// </summary>
		public bool bCanBeDamaged
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanBeDamaged__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanBeDamaged__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bActorIsBeingDestroyed__Offset;
		/// <summary>Set when actor is about to be deleted.</summary>
		public bool bActorIsBeingDestroyed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActorIsBeingDestroyed__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bCollideWhenPlacing__Offset;
		/// <summary>This actor collides with the world when placing in the editor, even if RootComponent collision is disabled. Does not affect spawning, @see SpawnCollisionHandlingMethod</summary>
		public bool bCollideWhenPlacing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollideWhenPlacing__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bFindCameraComponentWhenViewTarget__Offset;
		/// <summary>If true, this actor should search for an owned camera component to view through when used as a view target.</summary>
		public bool bFindCameraComponentWhenViewTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFindCameraComponentWhenViewTarget__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFindCameraComponentWhenViewTarget__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bRelevantForNetworkReplays__Offset;
		/// <summary>If true, this actor will be replicated to network replays (default is true)</summary>
		public bool bRelevantForNetworkReplays
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRelevantForNetworkReplays__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bGenerateOverlapEventsDuringLevelStreaming__Offset;
		/// <summary>If true, this actor will generate overlap events when spawned as part of level streaming. You might enable this is in the case where a streaming level loads around an actor and you want overlaps to trigger.</summary>
		public bool bGenerateOverlapEventsDuringLevelStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateOverlapEventsDuringLevelStreaming__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateOverlapEventsDuringLevelStreaming__Offset, 1,0,64,64);}
			
		}
		
		static readonly int Instigator__Offset;
		/// <summary>Pawn responsible for damage caused by this actor.</summary>
		public APawn Instigator
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Instigator__Offset); if (v == IntPtr.Zero)return null; APawn retValue = new APawn(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Children__Offset;
		/// <summary>Array of Actors whose Owner is this actor</summary>
		public TObjectArray<AActor>  Children
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Children__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Children__Offset, false);}
			
		}
		
		static readonly int RootComponent__Offset;
		/// <summary>Collision primitive that defines the transform (location, rotation, scale) of this Actor.</summary>
		public USceneComponent RootComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RootComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PivotOffset__Offset;
		/// <summary>Local space pivot offset for the actor</summary>
		public FVector PivotOffset
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PivotOffset__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PivotOffset__Offset, false);}
			
		}
		
		static readonly int ControllingMatineeActors__Offset;
		/// <summary>The matinee actors that control this actor.</summary>
		public TObjectArray<AMatineeActor>  ControllingMatineeActors
		{
					get{ CheckIsValid();return new TObjectArray<AMatineeActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ControllingMatineeActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ControllingMatineeActors__Offset, false);}
			
		}
		
		static readonly int InitialLifeSpan__Offset;
		/// <summary>How long this Actor lives before dying, 0=forever. Note this is the INITIAL value and should not be modified once play has begun.</summary>
		public float InitialLifeSpan
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialLifeSpan__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialLifeSpan__Offset, false);}
			
		}
		
		static readonly int Layers__Offset;
		/// <summary>Layer's the actor belongs to.  This is outside of the editoronly data to allow hiding of LD-specified layers at runtime for profiling.</summary>
		public TStructArray<FName> Layers
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Layers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Layers__Offset, false);}
			
		}
		
		static readonly int GroupActor__Offset;
		/// <summary>The group this actor is a part of.</summary>
		public AActor GroupActor
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GroupActor__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int SpriteScale__Offset;
		/// <summary>The scale to apply to any billboard components in editor builds (happens in any WITH_EDITOR build, including non-cooked games).</summary>
		public float SpriteScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SpriteScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpriteScale__Offset, false);}
			
		}
		
		static readonly int ActorLabel__Offset;
		/// <summary>
		/// The friendly name for this actor, displayed in the editor.  You should always use AActor::GetActorLabel() to access the actual label to display,
		/// and call AActor::SetActorLabel() or FActorLabelUtilities::SetActorLabelUnique() to change the label.  Never set the label directly.
		/// </summary>
		public FString ActorLabel
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+ActorLabel__Offset, typeof(FString));}
			
		}
		
		static readonly int FolderPath__Offset;
		/// <summary>The folder path of this actor in the world (empty=root, / separated)</summary>
		public FName FolderPath
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+FolderPath__Offset, typeof(FName));}
			
		}
		
		static readonly int bActorLabelEditable__Offset;
		public bool bActorLabelEditable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActorLabelEditable__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHiddenEd__Offset;
		/// <summary>Whether this actor is hidden within the editor viewport.</summary>
		public bool bHiddenEd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHiddenEd__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bEditable__Offset;
		/// <summary>Whether the actor can be manipulated by editor operations.</summary>
		public bool bEditable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEditable__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bListedInSceneOutliner__Offset;
		/// <summary>Whether this actor should be listed in the scene outliner.</summary>
		public bool bListedInSceneOutliner
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bListedInSceneOutliner__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bHiddenEdLayer__Offset;
		/// <summary>Whether this actor is hidden by the layer browser.</summary>
		public bool bHiddenEdLayer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHiddenEdLayer__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bHiddenEdTemporary__Offset;
		/// <summary>Whether this actor is temporarily hidden within the editor; used for show/hide/etc functionality w/o dirtying the actor.</summary>
		public bool bHiddenEdTemporary
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHiddenEdTemporary__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bHiddenEdLevel__Offset;
		/// <summary>Whether this actor is hidden by the level browser.</summary>
		public bool bHiddenEdLevel
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHiddenEdLevel__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bLockLocation__Offset;
		/// <summary>If true, prevents the actor from being moved in the editor viewport.</summary>
		public bool bLockLocation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLockLocation__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bAllowReceiveTickEventOnDedicatedServer__Offset;
		/// <summary>
		/// If false, the Blueprint ReceiveTick() event will be disabled on dedicated servers.
		/// @see AllowReceiveTickEventOnDedicatedServer()
		/// </summary>
		public bool bAllowReceiveTickEventOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowReceiveTickEventOnDedicatedServer__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bActorSeamlessTraveled__Offset;
		/// <summary>Indicates the actor was pulled through a seamless travel.</summary>
		public bool bActorSeamlessTraveled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActorSeamlessTraveled__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bIgnoresOriginShifting__Offset;
		/// <summary>Whether this actor should not be affected by world origin shifting.</summary>
		public bool bIgnoresOriginShifting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoresOriginShifting__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoresOriginShifting__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bEnableAutoLODGeneration__Offset;
		/// <summary>If true, and if World setting has bEnableHierarchicalLOD equal to true, then it will generate LODActor from groups of clustered Actor</summary>
		public bool bEnableAutoLODGeneration
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableAutoLODGeneration__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableAutoLODGeneration__Offset, 1,0,128,128);}
			
		}
		
		static readonly int Tags__Offset;
		/// <summary>Array of tags that can be used for grouping and categorizing.</summary>
		public TStructArray<FName> Tags
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Tags__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Tags__Offset, false);}
			
		}
		
		static readonly int HiddenEditorViews__Offset;
		/// <summary>Bitflag to represent which views this actor is hidden in, via per-view layer visibility.</summary>
		public ulong HiddenEditorViews
		{
			get{ CheckIsValid();return (ulong)Marshal.PtrToStructure(_this.Get()+HiddenEditorViews__Offset, typeof(ulong));}
			
		}
		
		static readonly int OnTakeAnyDamage__Offset;
		/// <summary>Called when the actor is damaged in any way.</summary>
		public FMulticastScriptDelegate OnTakeAnyDamage
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTakeAnyDamage__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTakeAnyDamage__Offset, false);}
			
		}
		
		static readonly int OnTakePointDamage__Offset;
		/// <summary>Called when the actor is damaged by point damage.</summary>
		public FMulticastScriptDelegate OnTakePointDamage
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTakePointDamage__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTakePointDamage__Offset, false);}
			
		}
		
		static readonly int OnActorBeginOverlap__Offset;
		/// <summary>
		/// Called when another actor begins to overlap this actor, for example a player walking into a trigger.
		/// For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events.
		/// @note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events.
		/// </summary>
		public FMulticastScriptDelegate OnActorBeginOverlap
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnActorBeginOverlap__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnActorBeginOverlap__Offset, false);}
			
		}
		
		static readonly int OnActorEndOverlap__Offset;
		/// <summary>
		/// Called when another actor stops overlapping this actor.
		/// @note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events.
		/// </summary>
		public FMulticastScriptDelegate OnActorEndOverlap
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnActorEndOverlap__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnActorEndOverlap__Offset, false);}
			
		}
		
		static readonly int OnBeginCursorOver__Offset;
		/// <summary>Called when the mouse cursor is moved over this actor if mouse over events are enabled in the player controller.</summary>
		public FMulticastScriptDelegate OnBeginCursorOver
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnBeginCursorOver__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnBeginCursorOver__Offset, false);}
			
		}
		
		static readonly int OnEndCursorOver__Offset;
		/// <summary>Called when the mouse cursor is moved off this actor if mouse over events are enabled in the player controller.</summary>
		public FMulticastScriptDelegate OnEndCursorOver
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnEndCursorOver__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnEndCursorOver__Offset, false);}
			
		}
		
		static readonly int OnClicked__Offset;
		/// <summary>Called when the left mouse button is clicked while the mouse is over this actor and click events are enabled in the player controller.</summary>
		public FMulticastScriptDelegate OnClicked
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnClicked__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnClicked__Offset, false);}
			
		}
		
		static readonly int OnReleased__Offset;
		/// <summary>Called when the left mouse button is released while the mouse is over this actor and click events are enabled in the player controller.</summary>
		public FMulticastScriptDelegate OnReleased
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnReleased__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnReleased__Offset, false);}
			
		}
		
		static readonly int OnInputTouchBegin__Offset;
		/// <summary>Called when a touch input is received over this actor when touch events are enabled in the player controller.</summary>
		public FMulticastScriptDelegate OnInputTouchBegin
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchBegin__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchBegin__Offset, false);}
			
		}
		
		static readonly int OnInputTouchEnd__Offset;
		/// <summary>Called when a touch input is received over this component when touch events are enabled in the player controller.</summary>
		public FMulticastScriptDelegate OnInputTouchEnd
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchEnd__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchEnd__Offset, false);}
			
		}
		
		static readonly int OnInputTouchEnter__Offset;
		/// <summary>Called when a finger is moved over this actor when touch over events are enabled in the player controller.</summary>
		public FMulticastScriptDelegate OnInputTouchEnter
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchEnter__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchEnter__Offset, false);}
			
		}
		
		static readonly int OnInputTouchLeave__Offset;
		/// <summary>Called when a finger is moved off this actor when touch over events are enabled in the player controller.</summary>
		public FMulticastScriptDelegate OnInputTouchLeave
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchLeave__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchLeave__Offset, false);}
			
		}
		
		static readonly int OnActorHit__Offset;
		/// <summary>
		/// Called when this Actor hits (or is hit by) something solid. This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation.
		/// For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event.
		/// @note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled.
		/// </summary>
		public FMulticastScriptDelegate OnActorHit
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnActorHit__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnActorHit__Offset, false);}
			
		}
		
		static readonly int OnDestroyed__Offset;
		/// <summary>Event triggered when the actor is destroyed.</summary>
		public FMulticastScriptDelegate OnDestroyed
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnDestroyed__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnDestroyed__Offset, false);}
			
		}
		
		static readonly int OnEndPlay__Offset;
		/// <summary>Event triggered when the actor is being removed from a level.</summary>
		public FMulticastScriptDelegate OnEndPlay
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnEndPlay__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnEndPlay__Offset, false);}
			
		}
		
		static readonly int BlueprintCreatedComponents__Offset;
		/// <summary>Array of ActorComponents that are created by blueprints and serialized per-instance.</summary>
		public TObjectArray<UActorComponent>  BlueprintCreatedComponents
		{
					get{ CheckIsValid();return new TObjectArray<UActorComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BlueprintCreatedComponents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BlueprintCreatedComponents__Offset, false);}
			
		}
		
		static readonly int InstanceComponents__Offset;
		/// <summary>Array of ActorComponents that have been added by the user on a per-instance basis.</summary>
		public TObjectArray<UActorComponent>  InstanceComponents
		{
					get{ CheckIsValid();return new TObjectArray<UActorComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InstanceComponents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InstanceComponents__Offset, false);}
			
		}
		
		static AActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Actor");
			PrimaryActorTick__Offset=GetPropertyOffset(NativeClassPtr,"PrimaryActorTick");
			CustomTimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"CustomTimeDilation");
			bHidden__Offset=GetPropertyOffset(NativeClassPtr,"bHidden");
			bNetTemporary__Offset=GetPropertyOffset(NativeClassPtr,"bNetTemporary");
			bNetStartup__Offset=GetPropertyOffset(NativeClassPtr,"bNetStartup");
			bOnlyRelevantToOwner__Offset=GetPropertyOffset(NativeClassPtr,"bOnlyRelevantToOwner");
			bAlwaysRelevant__Offset=GetPropertyOffset(NativeClassPtr,"bAlwaysRelevant");
			bReplicateMovement__Offset=GetPropertyOffset(NativeClassPtr,"bReplicateMovement");
			bTearOff__Offset=GetPropertyOffset(NativeClassPtr,"bTearOff");
			bExchangedRoles__Offset=GetPropertyOffset(NativeClassPtr,"bExchangedRoles");
			bPendingNetUpdate__Offset=GetPropertyOffset(NativeClassPtr,"bPendingNetUpdate");
			bNetLoadOnClient__Offset=GetPropertyOffset(NativeClassPtr,"bNetLoadOnClient");
			bNetUseOwnerRelevancy__Offset=GetPropertyOffset(NativeClassPtr,"bNetUseOwnerRelevancy");
			bBlockInput__Offset=GetPropertyOffset(NativeClassPtr,"bBlockInput");
			bAllowTickBeforeBeginPlay__Offset=GetPropertyOffset(NativeClassPtr,"bAllowTickBeforeBeginPlay");
			bActorEnableCollision__Offset=GetPropertyOffset(NativeClassPtr,"bActorEnableCollision");
			bReplicates__Offset=GetPropertyOffset(NativeClassPtr,"bReplicates");
			NetDriverName__Offset=GetPropertyOffset(NativeClassPtr,"NetDriverName");
			RemoteRole__Offset=GetPropertyOffset(NativeClassPtr,"RemoteRole");
			Owner__Offset=GetPropertyOffset(NativeClassPtr,"Owner");
			ReplicatedMovement__Offset=GetPropertyOffset(NativeClassPtr,"ReplicatedMovement");
			AttachmentReplication__Offset=GetPropertyOffset(NativeClassPtr,"AttachmentReplication");
			Role__Offset=GetPropertyOffset(NativeClassPtr,"Role");
			AutoReceiveInput__Offset=GetPropertyOffset(NativeClassPtr,"AutoReceiveInput");
			InputPriority__Offset=GetPropertyOffset(NativeClassPtr,"InputPriority");
			InputComponent__Offset=GetPropertyOffset(NativeClassPtr,"InputComponent");
			InputConsumeOption__Offset=GetPropertyOffset(NativeClassPtr,"InputConsumeOption");
			NetCullDistanceSquared__Offset=GetPropertyOffset(NativeClassPtr,"NetCullDistanceSquared");
			NetTag__Offset=GetPropertyOffset(NativeClassPtr,"NetTag");
			NetUpdateTime__Offset=GetPropertyOffset(NativeClassPtr,"NetUpdateTime");
			NetUpdateFrequency__Offset=GetPropertyOffset(NativeClassPtr,"NetUpdateFrequency");
			MinNetUpdateFrequency__Offset=GetPropertyOffset(NativeClassPtr,"MinNetUpdateFrequency");
			NetPriority__Offset=GetPropertyOffset(NativeClassPtr,"NetPriority");
			LastNetUpdateTime__Offset=GetPropertyOffset(NativeClassPtr,"LastNetUpdateTime");
			bAutoDestroyWhenFinished__Offset=GetPropertyOffset(NativeClassPtr,"bAutoDestroyWhenFinished");
			bCanBeDamaged__Offset=GetPropertyOffset(NativeClassPtr,"bCanBeDamaged");
			bActorIsBeingDestroyed__Offset=GetPropertyOffset(NativeClassPtr,"bActorIsBeingDestroyed");
			bCollideWhenPlacing__Offset=GetPropertyOffset(NativeClassPtr,"bCollideWhenPlacing");
			bFindCameraComponentWhenViewTarget__Offset=GetPropertyOffset(NativeClassPtr,"bFindCameraComponentWhenViewTarget");
			bRelevantForNetworkReplays__Offset=GetPropertyOffset(NativeClassPtr,"bRelevantForNetworkReplays");
			bGenerateOverlapEventsDuringLevelStreaming__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateOverlapEventsDuringLevelStreaming");
			Instigator__Offset=GetPropertyOffset(NativeClassPtr,"Instigator");
			Children__Offset=GetPropertyOffset(NativeClassPtr,"Children");
			RootComponent__Offset=GetPropertyOffset(NativeClassPtr,"RootComponent");
			PivotOffset__Offset=GetPropertyOffset(NativeClassPtr,"PivotOffset");
			ControllingMatineeActors__Offset=GetPropertyOffset(NativeClassPtr,"ControllingMatineeActors");
			InitialLifeSpan__Offset=GetPropertyOffset(NativeClassPtr,"InitialLifeSpan");
			Layers__Offset=GetPropertyOffset(NativeClassPtr,"Layers");
			GroupActor__Offset=GetPropertyOffset(NativeClassPtr,"GroupActor");
			SpriteScale__Offset=GetPropertyOffset(NativeClassPtr,"SpriteScale");
			ActorLabel__Offset=GetPropertyOffset(NativeClassPtr,"ActorLabel");
			FolderPath__Offset=GetPropertyOffset(NativeClassPtr,"FolderPath");
			bActorLabelEditable__Offset=GetPropertyOffset(NativeClassPtr,"bActorLabelEditable");
			bHiddenEd__Offset=GetPropertyOffset(NativeClassPtr,"bHiddenEd");
			bEditable__Offset=GetPropertyOffset(NativeClassPtr,"bEditable");
			bListedInSceneOutliner__Offset=GetPropertyOffset(NativeClassPtr,"bListedInSceneOutliner");
			bHiddenEdLayer__Offset=GetPropertyOffset(NativeClassPtr,"bHiddenEdLayer");
			bHiddenEdTemporary__Offset=GetPropertyOffset(NativeClassPtr,"bHiddenEdTemporary");
			bHiddenEdLevel__Offset=GetPropertyOffset(NativeClassPtr,"bHiddenEdLevel");
			bLockLocation__Offset=GetPropertyOffset(NativeClassPtr,"bLockLocation");
			bAllowReceiveTickEventOnDedicatedServer__Offset=GetPropertyOffset(NativeClassPtr,"bAllowReceiveTickEventOnDedicatedServer");
			bActorSeamlessTraveled__Offset=GetPropertyOffset(NativeClassPtr,"bActorSeamlessTraveled");
			bIgnoresOriginShifting__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoresOriginShifting");
			bEnableAutoLODGeneration__Offset=GetPropertyOffset(NativeClassPtr,"bEnableAutoLODGeneration");
			Tags__Offset=GetPropertyOffset(NativeClassPtr,"Tags");
			HiddenEditorViews__Offset=GetPropertyOffset(NativeClassPtr,"HiddenEditorViews");
			OnTakeAnyDamage__Offset=GetPropertyOffset(NativeClassPtr,"OnTakeAnyDamage");
			OnTakePointDamage__Offset=GetPropertyOffset(NativeClassPtr,"OnTakePointDamage");
			OnActorBeginOverlap__Offset=GetPropertyOffset(NativeClassPtr,"OnActorBeginOverlap");
			OnActorEndOverlap__Offset=GetPropertyOffset(NativeClassPtr,"OnActorEndOverlap");
			OnBeginCursorOver__Offset=GetPropertyOffset(NativeClassPtr,"OnBeginCursorOver");
			OnEndCursorOver__Offset=GetPropertyOffset(NativeClassPtr,"OnEndCursorOver");
			OnClicked__Offset=GetPropertyOffset(NativeClassPtr,"OnClicked");
			OnReleased__Offset=GetPropertyOffset(NativeClassPtr,"OnReleased");
			OnInputTouchBegin__Offset=GetPropertyOffset(NativeClassPtr,"OnInputTouchBegin");
			OnInputTouchEnd__Offset=GetPropertyOffset(NativeClassPtr,"OnInputTouchEnd");
			OnInputTouchEnter__Offset=GetPropertyOffset(NativeClassPtr,"OnInputTouchEnter");
			OnInputTouchLeave__Offset=GetPropertyOffset(NativeClassPtr,"OnInputTouchLeave");
			OnActorHit__Offset=GetPropertyOffset(NativeClassPtr,"OnActorHit");
			OnDestroyed__Offset=GetPropertyOffset(NativeClassPtr,"OnDestroyed");
			OnEndPlay__Offset=GetPropertyOffset(NativeClassPtr,"OnEndPlay");
			BlueprintCreatedComponents__Offset=GetPropertyOffset(NativeClassPtr,"BlueprintCreatedComponents");
			InstanceComponents__Offset=GetPropertyOffset(NativeClassPtr,"InstanceComponents");
			
		}
		
	}
	
}
#endif
#endif
