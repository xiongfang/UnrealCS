#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleSystemComponent
	{
		static readonly int Template__Offset;
		public UParticleSystem Template
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Template__Offset); if (v == IntPtr.Zero)return null; UParticleSystem retValue = new UParticleSystem(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Template__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Template__Offset, value._this.Get()); }
			
		}
		
		static readonly int EmitterMaterials__Offset;
		public TObjectArray<UMaterialInterface>  EmitterMaterials
		{
					get{ CheckIsValid();return new TObjectArray<UMaterialInterface>((FScriptArray)Marshal.PtrToStructure(_this.Get()+EmitterMaterials__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+EmitterMaterials__Offset, false);}
			
		}
		
		static readonly int SkelMeshComponents__Offset;
		public TObjectArray<USkeletalMeshComponent>  SkelMeshComponents
		{
					get{ CheckIsValid();return new TObjectArray<USkeletalMeshComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SkelMeshComponents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SkelMeshComponents__Offset, false);}
			
		}
		
		static readonly int bResetOnDetach__Offset;
		public bool bResetOnDetach
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bResetOnDetach__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bResetOnDetach__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bUpdateOnDedicatedServer__Offset;
		public bool bUpdateOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateOnDedicatedServer__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bAllowRecycling__Offset;
		public bool bAllowRecycling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowRecycling__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowRecycling__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAutoManageAttachment__Offset;
		public bool bAutoManageAttachment
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoManageAttachment__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoManageAttachment__Offset, 1,0,16,16);}
			
		}
		
		static readonly int InstanceParameters__Offset;
		public TStructArray<FParticleSysParam> InstanceParameters
		{
			get{ CheckIsValid();return new TStructArray<FParticleSysParam>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InstanceParameters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InstanceParameters__Offset, false);}
			
		}
		
		static readonly int OnParticleSpawn__Offset;
		public FMulticastScriptDelegate OnParticleSpawn
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnParticleSpawn__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnParticleSpawn__Offset, false);}
			
		}
		
		static readonly int OnParticleBurst__Offset;
		public FMulticastScriptDelegate OnParticleBurst
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnParticleBurst__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnParticleBurst__Offset, false);}
			
		}
		
		static readonly int OnParticleDeath__Offset;
		public FMulticastScriptDelegate OnParticleDeath
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnParticleDeath__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnParticleDeath__Offset, false);}
			
		}
		
		static readonly int OnParticleCollide__Offset;
		public FMulticastScriptDelegate OnParticleCollide
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnParticleCollide__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnParticleCollide__Offset, false);}
			
		}
		
		static readonly int OldPosition__Offset;
		public FVector OldPosition
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+OldPosition__Offset, typeof(FVector));}
			
		}
		
		static readonly int PartSysVelocity__Offset;
		public FVector PartSysVelocity
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+PartSysVelocity__Offset, typeof(FVector));}
			
		}
		
		static readonly int WarmupTime__Offset;
		public float WarmupTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WarmupTime__Offset, typeof(float));}
			
		}
		
		static readonly int WarmupTickRate__Offset;
		public float WarmupTickRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WarmupTickRate__Offset, typeof(float));}
			
		}
		
		static readonly int bWarmingUp__Offset;
		public bool bWarmingUp
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bWarmingUp__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int SecondsBeforeInactive__Offset;
		public float SecondsBeforeInactive
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SecondsBeforeInactive__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SecondsBeforeInactive__Offset, false);}
			
		}
		
		static readonly int MaxTimeBeforeForceUpdateTransform__Offset;
		public float MaxTimeBeforeForceUpdateTransform
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxTimeBeforeForceUpdateTransform__Offset, typeof(float));}
			
		}
		
		static readonly int bOverrideLODMethod__Offset;
		public bool bOverrideLODMethod
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideLODMethod__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideLODMethod__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LODMethod__Offset;
		public ParticleSystemLODMethod LODMethod
		{
			get{ CheckIsValid();return (ParticleSystemLODMethod)Marshal.PtrToStructure(_this.Get()+LODMethod__Offset, typeof(ParticleSystemLODMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODMethod__Offset, false);}
			
		}
		
		static readonly int bSkipUpdateDynamicDataDuringTick__Offset;
		public bool bSkipUpdateDynamicDataDuringTick
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSkipUpdateDynamicDataDuringTick__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int ReplayClips__Offset;
		public TObjectArray<UParticleSystemReplay>  ReplayClips
		{
					get{ CheckIsValid();return new TObjectArray<UParticleSystemReplay>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ReplayClips__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ReplayClips__Offset, false);}
			
		}
		
		static readonly int CustomTimeDilation__Offset;
		public float CustomTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CustomTimeDilation__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CustomTimeDilation__Offset, false);}
			
		}
		
		static readonly int OnSystemFinished__Offset;
		public FMulticastScriptDelegate OnSystemFinished
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnSystemFinished__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnSystemFinished__Offset, false);}
			
		}
		
		static readonly int AutoAttachSocketName__Offset;
		public FName AutoAttachSocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+AutoAttachSocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AutoAttachSocketName__Offset, false);}
			
		}
		
		static readonly int AutoAttachLocationType__Offset;
		public EAttachLocation AutoAttachLocationType
		{
			get{ CheckIsValid();return (EAttachLocation)Marshal.PtrToStructure(_this.Get()+AutoAttachLocationType__Offset, typeof(EAttachLocation));}
			
		}
		
		static UParticleSystemComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleSystemComponent");
			Template__Offset=GetPropertyOffset(NativeClassPtr,"Template");
			EmitterMaterials__Offset=GetPropertyOffset(NativeClassPtr,"EmitterMaterials");
			SkelMeshComponents__Offset=GetPropertyOffset(NativeClassPtr,"SkelMeshComponents");
			bResetOnDetach__Offset=GetPropertyOffset(NativeClassPtr,"bResetOnDetach");
			bUpdateOnDedicatedServer__Offset=GetPropertyOffset(NativeClassPtr,"bUpdateOnDedicatedServer");
			bAllowRecycling__Offset=GetPropertyOffset(NativeClassPtr,"bAllowRecycling");
			bAutoManageAttachment__Offset=GetPropertyOffset(NativeClassPtr,"bAutoManageAttachment");
			InstanceParameters__Offset=GetPropertyOffset(NativeClassPtr,"InstanceParameters");
			OnParticleSpawn__Offset=GetPropertyOffset(NativeClassPtr,"OnParticleSpawn");
			OnParticleBurst__Offset=GetPropertyOffset(NativeClassPtr,"OnParticleBurst");
			OnParticleDeath__Offset=GetPropertyOffset(NativeClassPtr,"OnParticleDeath");
			OnParticleCollide__Offset=GetPropertyOffset(NativeClassPtr,"OnParticleCollide");
			OldPosition__Offset=GetPropertyOffset(NativeClassPtr,"OldPosition");
			PartSysVelocity__Offset=GetPropertyOffset(NativeClassPtr,"PartSysVelocity");
			WarmupTime__Offset=GetPropertyOffset(NativeClassPtr,"WarmupTime");
			WarmupTickRate__Offset=GetPropertyOffset(NativeClassPtr,"WarmupTickRate");
			bWarmingUp__Offset=GetPropertyOffset(NativeClassPtr,"bWarmingUp");
			SecondsBeforeInactive__Offset=GetPropertyOffset(NativeClassPtr,"SecondsBeforeInactive");
			MaxTimeBeforeForceUpdateTransform__Offset=GetPropertyOffset(NativeClassPtr,"MaxTimeBeforeForceUpdateTransform");
			bOverrideLODMethod__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideLODMethod");
			LODMethod__Offset=GetPropertyOffset(NativeClassPtr,"LODMethod");
			bSkipUpdateDynamicDataDuringTick__Offset=GetPropertyOffset(NativeClassPtr,"bSkipUpdateDynamicDataDuringTick");
			ReplayClips__Offset=GetPropertyOffset(NativeClassPtr,"ReplayClips");
			CustomTimeDilation__Offset=GetPropertyOffset(NativeClassPtr,"CustomTimeDilation");
			OnSystemFinished__Offset=GetPropertyOffset(NativeClassPtr,"OnSystemFinished");
			AutoAttachSocketName__Offset=GetPropertyOffset(NativeClassPtr,"AutoAttachSocketName");
			AutoAttachLocationType__Offset=GetPropertyOffset(NativeClassPtr,"AutoAttachLocationType");
			
		}
		
	}
	
}
#endif
#endif
