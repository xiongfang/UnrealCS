#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class AActor
	{
		static readonly int PrimaryActorTick__Offset;
		public FActorTickFunction PrimaryActorTick
		{
			get{ CheckIsValid();return (FActorTickFunction)Marshal.PtrToStructure(_this.Get()+PrimaryActorTick__Offset, typeof(FActorTickFunction));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PrimaryActorTick__Offset, false);}
			
		}
		
		static readonly int CustomTimeDilation__Offset;
		public float CustomTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CustomTimeDilation__Offset, typeof(float));}
			
		}
		
		static readonly int bHidden__Offset;
		public bool bHidden
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHidden__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bHidden__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bNetTemporary__Offset;
		public bool bNetTemporary
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetTemporary__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bNetStartup__Offset;
		public bool bNetStartup
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetStartup__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bOnlyRelevantToOwner__Offset;
		public bool bOnlyRelevantToOwner
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlyRelevantToOwner__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOnlyRelevantToOwner__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAlwaysRelevant__Offset;
		public bool bAlwaysRelevant
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysRelevant__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysRelevant__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bReplicateMovement__Offset;
		public bool bReplicateMovement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicateMovement__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReplicateMovement__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bTearOff__Offset;
		public bool bTearOff
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTearOff__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bExchangedRoles__Offset;
		public bool bExchangedRoles
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bExchangedRoles__Offset, 1, 0, 128, 128);}
			
		}
		
		static readonly int bPendingNetUpdate__Offset;
		public bool bPendingNetUpdate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPendingNetUpdate__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bNetLoadOnClient__Offset;
		public bool bNetLoadOnClient
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetLoadOnClient__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNetLoadOnClient__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bNetUseOwnerRelevancy__Offset;
		public bool bNetUseOwnerRelevancy
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bNetUseOwnerRelevancy__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bNetUseOwnerRelevancy__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bBlockInput__Offset;
		public bool bBlockInput
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bBlockInput__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bBlockInput__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAllowTickBeforeBeginPlay__Offset;
		public bool bAllowTickBeforeBeginPlay
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowTickBeforeBeginPlay__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowTickBeforeBeginPlay__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bActorEnableCollision__Offset;
		public bool bActorEnableCollision
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActorEnableCollision__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bReplicates__Offset;
		public bool bReplicates
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReplicates__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReplicates__Offset, 1,0,8,8);}
			
		}
		
		static readonly int NetDriverName__Offset;
		public FName NetDriverName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+NetDriverName__Offset, typeof(FName));}
			
		}
		
		static readonly int RemoteRole__Offset;
		public ENetRole RemoteRole
		{
			get{ CheckIsValid();return (ENetRole)Marshal.PtrToStructure(_this.Get()+RemoteRole__Offset, typeof(ENetRole));}
			
		}
		
		static readonly int Owner__Offset;
		public AActor Owner
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Owner__Offset); if (v == IntPtr.Zero)return null; AActor retValue = new AActor(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ReplicatedMovement__Offset;
		public FRepMovement ReplicatedMovement
		{
			get{ CheckIsValid();return (FRepMovement)Marshal.PtrToStructure(_this.Get()+ReplicatedMovement__Offset, typeof(FRepMovement));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ReplicatedMovement__Offset, false);}
			
		}
		
		static readonly int AttachmentReplication__Offset;
		public FRepAttachment AttachmentReplication
		{
			get{ CheckIsValid();return (FRepAttachment)Marshal.PtrToStructure(_this.Get()+AttachmentReplication__Offset, typeof(FRepAttachment));}
			
		}
		
		static readonly int Role__Offset;
		public ENetRole Role
		{
			get{ CheckIsValid();return (ENetRole)Marshal.PtrToStructure(_this.Get()+Role__Offset, typeof(ENetRole));}
			
		}
		
		static readonly int AutoReceiveInput__Offset;
		public EAutoReceiveInput AutoReceiveInput
		{
			get{ CheckIsValid();return (EAutoReceiveInput)Marshal.PtrToStructure(_this.Get()+AutoReceiveInput__Offset, typeof(EAutoReceiveInput));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AutoReceiveInput__Offset, false);}
			
		}
		
		static readonly int InputPriority__Offset;
		public int InputPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+InputPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InputPriority__Offset, false);}
			
		}
		
		static readonly int InputComponent__Offset;
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
		public float NetCullDistanceSquared
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetCullDistanceSquared__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetCullDistanceSquared__Offset, false);}
			
		}
		
		static readonly int NetTag__Offset;
		public int NetTag
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+NetTag__Offset, typeof(int));}
			
		}
		
		static readonly int NetUpdateTime__Offset;
		public float NetUpdateTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetUpdateTime__Offset, typeof(float));}
			
		}
		
		static readonly int NetUpdateFrequency__Offset;
		public float NetUpdateFrequency
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetUpdateFrequency__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetUpdateFrequency__Offset, false);}
			
		}
		
		static readonly int MinNetUpdateFrequency__Offset;
		public float MinNetUpdateFrequency
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinNetUpdateFrequency__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinNetUpdateFrequency__Offset, false);}
			
		}
		
		static readonly int NetPriority__Offset;
		public float NetPriority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+NetPriority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NetPriority__Offset, false);}
			
		}
		
		static readonly int LastNetUpdateTime__Offset;
		public float LastNetUpdateTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastNetUpdateTime__Offset, typeof(float));}
			
		}
		
		static readonly int bAutoDestroyWhenFinished__Offset;
		public bool bAutoDestroyWhenFinished
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoDestroyWhenFinished__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bCanBeDamaged__Offset;
		public bool bCanBeDamaged
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCanBeDamaged__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCanBeDamaged__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bActorIsBeingDestroyed__Offset;
		public bool bActorIsBeingDestroyed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActorIsBeingDestroyed__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bCollideWhenPlacing__Offset;
		public bool bCollideWhenPlacing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollideWhenPlacing__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bFindCameraComponentWhenViewTarget__Offset;
		public bool bFindCameraComponentWhenViewTarget
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bFindCameraComponentWhenViewTarget__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bFindCameraComponentWhenViewTarget__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bRelevantForNetworkReplays__Offset;
		public bool bRelevantForNetworkReplays
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRelevantForNetworkReplays__Offset, 1, 0, 32, 32);}
			
		}
		
		static readonly int bGenerateOverlapEventsDuringLevelStreaming__Offset;
		public bool bGenerateOverlapEventsDuringLevelStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateOverlapEventsDuringLevelStreaming__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateOverlapEventsDuringLevelStreaming__Offset, 1,0,64,64);}
			
		}
		
		static readonly int Instigator__Offset;
		public APawn Instigator
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Instigator__Offset); if (v == IntPtr.Zero)return null; APawn retValue = new APawn(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Children__Offset;
		public TObjectArray<AActor>  Children
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Children__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Children__Offset, false);}
			
		}
		
		static readonly int RootComponent__Offset;
		public USceneComponent RootComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RootComponent__Offset); if (v == IntPtr.Zero)return null; USceneComponent retValue = new USceneComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ControllingMatineeActors__Offset;
		public TObjectArray<AMatineeActor>  ControllingMatineeActors
		{
					get{ CheckIsValid();return new TObjectArray<AMatineeActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ControllingMatineeActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ControllingMatineeActors__Offset, false);}
			
		}
		
		static readonly int InitialLifeSpan__Offset;
		public float InitialLifeSpan
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialLifeSpan__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialLifeSpan__Offset, false);}
			
		}
		
		static readonly int Layers__Offset;
		public TStructArray<FName> Layers
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Layers__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Layers__Offset, false);}
			
		}
		
		static readonly int bAllowReceiveTickEventOnDedicatedServer__Offset;
		public bool bAllowReceiveTickEventOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowReceiveTickEventOnDedicatedServer__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bActorSeamlessTraveled__Offset;
		public bool bActorSeamlessTraveled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bActorSeamlessTraveled__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bIgnoresOriginShifting__Offset;
		public bool bIgnoresOriginShifting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoresOriginShifting__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoresOriginShifting__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bEnableAutoLODGeneration__Offset;
		public bool bEnableAutoLODGeneration
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableAutoLODGeneration__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableAutoLODGeneration__Offset, 1,0,64,64);}
			
		}
		
		static readonly int Tags__Offset;
		public TStructArray<FName> Tags
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Tags__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Tags__Offset, false);}
			
		}
		
		static readonly int HiddenEditorViews__Offset;
		public ulong HiddenEditorViews
		{
			get{ CheckIsValid();return (ulong)Marshal.PtrToStructure(_this.Get()+HiddenEditorViews__Offset, typeof(ulong));}
			
		}
		
		static readonly int OnTakeAnyDamage__Offset;
		public FMulticastScriptDelegate OnTakeAnyDamage
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTakeAnyDamage__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTakeAnyDamage__Offset, false);}
			
		}
		
		static readonly int OnTakePointDamage__Offset;
		public FMulticastScriptDelegate OnTakePointDamage
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnTakePointDamage__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnTakePointDamage__Offset, false);}
			
		}
		
		static readonly int OnActorBeginOverlap__Offset;
		public FMulticastScriptDelegate OnActorBeginOverlap
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnActorBeginOverlap__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnActorBeginOverlap__Offset, false);}
			
		}
		
		static readonly int OnActorEndOverlap__Offset;
		public FMulticastScriptDelegate OnActorEndOverlap
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnActorEndOverlap__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnActorEndOverlap__Offset, false);}
			
		}
		
		static readonly int OnBeginCursorOver__Offset;
		public FMulticastScriptDelegate OnBeginCursorOver
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnBeginCursorOver__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnBeginCursorOver__Offset, false);}
			
		}
		
		static readonly int OnEndCursorOver__Offset;
		public FMulticastScriptDelegate OnEndCursorOver
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnEndCursorOver__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnEndCursorOver__Offset, false);}
			
		}
		
		static readonly int OnClicked__Offset;
		public FMulticastScriptDelegate OnClicked
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnClicked__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnClicked__Offset, false);}
			
		}
		
		static readonly int OnReleased__Offset;
		public FMulticastScriptDelegate OnReleased
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnReleased__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnReleased__Offset, false);}
			
		}
		
		static readonly int OnInputTouchBegin__Offset;
		public FMulticastScriptDelegate OnInputTouchBegin
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchBegin__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchBegin__Offset, false);}
			
		}
		
		static readonly int OnInputTouchEnd__Offset;
		public FMulticastScriptDelegate OnInputTouchEnd
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchEnd__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchEnd__Offset, false);}
			
		}
		
		static readonly int OnInputTouchEnter__Offset;
		public FMulticastScriptDelegate OnInputTouchEnter
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchEnter__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchEnter__Offset, false);}
			
		}
		
		static readonly int OnInputTouchLeave__Offset;
		public FMulticastScriptDelegate OnInputTouchLeave
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchLeave__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchLeave__Offset, false);}
			
		}
		
		static readonly int OnActorHit__Offset;
		public FMulticastScriptDelegate OnActorHit
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnActorHit__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnActorHit__Offset, false);}
			
		}
		
		static readonly int OnDestroyed__Offset;
		public FMulticastScriptDelegate OnDestroyed
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnDestroyed__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnDestroyed__Offset, false);}
			
		}
		
		static readonly int OnEndPlay__Offset;
		public FMulticastScriptDelegate OnEndPlay
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnEndPlay__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnEndPlay__Offset, false);}
			
		}
		
		static readonly int BlueprintCreatedComponents__Offset;
		public TObjectArray<UActorComponent>  BlueprintCreatedComponents
		{
					get{ CheckIsValid();return new TObjectArray<UActorComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BlueprintCreatedComponents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BlueprintCreatedComponents__Offset, false);}
			
		}
		
		static readonly int InstanceComponents__Offset;
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
			ControllingMatineeActors__Offset=GetPropertyOffset(NativeClassPtr,"ControllingMatineeActors");
			InitialLifeSpan__Offset=GetPropertyOffset(NativeClassPtr,"InitialLifeSpan");
			Layers__Offset=GetPropertyOffset(NativeClassPtr,"Layers");
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
