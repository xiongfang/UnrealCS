#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A particle emitter.</summary>
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
		/// <summary>
		/// The skeletal mesh components used with the socket location module.
		/// This is to prevent them from being garbage collected.
		/// </summary>
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
		/// <summary>whether to update the particle system on dedicated servers</summary>
		public bool bUpdateOnDedicatedServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUpdateOnDedicatedServer__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bAllowRecycling__Offset;
		/// <summary>
		/// If true, this Particle System will be available for recycling after it has completed. Auto-destroyed systems cannot be recycled.
		/// Some systems (currently particle trail effects) can recycle components to avoid respawning them to play new effects.
		/// This is only an optimization and does not change particle system behavior, aside from not triggering normal component initialization events more than once.
		/// </summary>
		public bool bAllowRecycling
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowRecycling__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowRecycling__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAutoManageAttachment__Offset;
		/// <summary>
		/// True if we should automatically attach to AutoAttachParent when activated, and detach from our parent when completed.
		/// This overrides any current attachment that may be present at the time of activation (deferring initial attachment until activation, if AutoAttachParent is null).
		/// When enabled, detachment occurs regardless of whether AutoAttachParent is assigned, and the relative transform from the time of activation is restored.
		/// This also disables attachment on dedicated servers, where we don't actually activate even if bAutoActivate is true.
		/// @see AutoAttachParent, AutoAttachSocketName, AutoAttachLocationType
		/// </summary>
		public bool bAutoManageAttachment
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoManageAttachment__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoManageAttachment__Offset, 1,0,16,16);}
			
		}
		
		static readonly int InstanceParameters__Offset;
		/// <summary>
		/// Array holding name instance parameters for this ParticleSystemComponent.
		/// Parameters can be used in Cascade using DistributionFloat/VectorParticleParameters.
		/// </summary>
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
		/// <summary>
		/// Number of seconds of emitter not being rendered that need to pass before it
		/// no longer gets ticked/ becomes inactive.
		/// </summary>
		public float SecondsBeforeInactive
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SecondsBeforeInactive__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SecondsBeforeInactive__Offset, false);}
			
		}
		
		static readonly int MaxTimeBeforeForceUpdateTransform__Offset;
		/// <summary>
		/// Time between forced UpdateTransforms for systems that use dynamically calculated bounds,
		/// Which is effectively how often the bounds are shrunk.
		/// </summary>
		public float MaxTimeBeforeForceUpdateTransform
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxTimeBeforeForceUpdateTransform__Offset, typeof(float));}
			
		}
		
		static readonly int EditorLODLevel__Offset;
		/// <summary>INTERNAL. Used by the editor to set the LODLevel</summary>
		public int EditorLODLevel
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EditorLODLevel__Offset, typeof(int));}
			
		}
		
		static readonly int EditorDetailMode__Offset;
		/// <summary>Used for applying Cascade's detail mode setting to in-level particle systems</summary>
		public int EditorDetailMode
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EditorDetailMode__Offset, typeof(int));}
			
		}
		
		static readonly int bOverrideLODMethod__Offset;
		/// <summary>indicates that the component's LODMethod overrides the Template's</summary>
		public bool bOverrideLODMethod
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideLODMethod__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideLODMethod__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LODMethod__Offset;
		/// <summary>The method of LOD level determination to utilize for this particle system</summary>
		public ParticleSystemLODMethod LODMethod
		{
			get{ CheckIsValid();return (ParticleSystemLODMethod)Marshal.PtrToStructure(_this.Get()+LODMethod__Offset, typeof(ParticleSystemLODMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODMethod__Offset, false);}
			
		}
		
		static readonly int bSkipUpdateDynamicDataDuringTick__Offset;
		/// <summary>
		/// Flag indicating that dynamic updating of render data should NOT occur during Tick.
		/// This is used primarily to allow for warming up and simulated effects to a certain state.
		/// </summary>
		public bool bSkipUpdateDynamicDataDuringTick
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSkipUpdateDynamicDataDuringTick__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int ReplayClips__Offset;
		/// <summary>Array of replay clips for this particle system component.  These are serialized to disk.  You really should never add anything to this in the editor.  It's exposed so that you can delete clips if you need to, but be careful when doing so!</summary>
		public TObjectArray<UParticleSystemReplay>  ReplayClips
		{
					get{ CheckIsValid();return new TObjectArray<UParticleSystemReplay>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ReplayClips__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ReplayClips__Offset, false);}
			
		}
		
		static readonly int CustomTimeDilation__Offset;
		/// <summary>Scales DeltaTime in UParticleSystemComponent::Tick(...)</summary>
		public float CustomTimeDilation
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CustomTimeDilation__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CustomTimeDilation__Offset, false);}
			
		}
		
		static readonly int OnSystemFinished__Offset;
		/// <summary>Called when the particle system is done</summary>
		public FMulticastScriptDelegate OnSystemFinished
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnSystemFinished__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnSystemFinished__Offset, false);}
			
		}
		
		static readonly int AutoAttachSocketName__Offset;
		/// <summary>
		/// Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true.
		/// @see bAutoManageAttachment
		/// </summary>
		public FName AutoAttachSocketName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+AutoAttachSocketName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AutoAttachSocketName__Offset, false);}
			
		}
		
		static readonly int AutoAttachLocationType__Offset;
		/// <summary>
		/// DEPRECATED: Options for how we handle our location when we attach to the AutoAttachParent, if bAutoManageAttachment is true.
		/// @see bAutoManageAttachment, EAttachLocation::Type
		/// </summary>
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
			EditorLODLevel__Offset=GetPropertyOffset(NativeClassPtr,"EditorLODLevel");
			EditorDetailMode__Offset=GetPropertyOffset(NativeClassPtr,"EditorDetailMode");
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
