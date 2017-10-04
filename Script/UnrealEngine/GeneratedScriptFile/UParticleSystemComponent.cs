using System;
namespace UnrealEngine
{
	public partial class UParticleSystemComponent:UPrimitiveComponent
	{
		/// <summary>
		/// Record a kismet event.
		/// @param  InEventName                             The name of the event that fired.
		/// @param  InEmitterTime                   The emitter time when the event fired.
		/// @param  InLocation                              The location of the particle when the event fired.
		/// @param  InVelocity                              The velocity of the particle when the event fired.
		/// @param  InNormal                                Normal vector of the collision in coordinate system of the returner. Zero=none.
		/// </summary>
		public extern void GenerateParticleEvent(FName InEventName,float InEmitterTime,FVector InLocation,FVector InDirection,FVector InVelocity);
		/// <summary>Returns a named material. If this named material is not found, returns NULL.</summary>
		public extern virtual UMaterialInterface GetNamedMaterial(FName InName);
		/// <summary>
		/// Creates a Dynamic Material Instance for the specified named material override, optionally from the supplied material.
		/// @param Name - The slot name of the material to replace.  If invalid, the material is unchanged and NULL is returned.
		/// </summary>
		public extern virtual UMaterialInstanceDynamic CreateNamedDynamicMaterialInstance(FName InName,UMaterialInterface SourceMaterial);
		/// <summary>
		/// Sets the defining data for all trails in this component.
		/// @param        InFirstSocketName       The name of the first socket for the trail.
		/// @param        InSecondSocketName      The name of the second socket for the trail.
		/// @param        InWidthMode                     How the width value is applied to the trail.
		/// @param        InWidth                         The width of the trail.
		/// </summary>
		public extern void SetTrailSourceData(FName InFirstSocketName,FName InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth);
		/// <summary>Ends all trail emitters in this component.</summary>
		public extern void EndTrails();
		/// <summary>
		/// Begins all trail emitters in this component.
		/// @param        InFirstSocketName       The name of the first socket for the trail.
		/// @param        InSecondSocketName      The name of the second socket for the trail.
		/// @param        InWidthMode                     How the width value is applied to the trail.
		/// @param        InWidth                         The width of the trail.
		/// </summary>
		public extern void BeginTrails(FName InFirstSocketName,FName InSecondSocketName,ETrailWidthMode InWidthMode,float InWidth);
		/// <summary>Get the current number of active particles in this system</summary>
		public extern int GetNumActiveParticles();
		/// <summary>Change the ParticleSystem used by this ParticleSystemComponent</summary>
		public extern void SetTemplate(UParticleSystem NewTemplate);
		/// <summary>
		/// Set a named material instance parameter on this ParticleSystemComponent.
		/// Updates the parameter if it already exists, or creates a new entry if not.
		/// </summary>
		public extern void SetMaterialParameter(FName ParameterName,UMaterialInterface Param);
		/// <summary>
		/// Set a named actor instance parameter on this ParticleSystemComponent.
		/// Updates the parameter if it already exists, or creates a new entry if not.
		/// </summary>
		public extern void SetActorParameter(FName ParameterName,AActor Param);
		/// <summary>
		/// Set a named color instance parameter on this ParticleSystemComponent.
		/// Updates the parameter if it already exists, or creates a new entry if not.
		/// </summary>
		public extern void SetColorParameter(FName ParameterName,FLinearColor Param);
		/// <summary>
		/// Set a named vector instance parameter on this ParticleSystemComponent.
		/// Updates the parameter if it already exists, or creates a new entry if not.
		/// </summary>
		public extern void SetVectorParameter(FName ParameterName,FVector Param);
		/// <summary>Change a named float parameter</summary>
		public extern void SetFloatParameter(FName ParameterName,float Param);
		/// <summary>
		/// Enables/Disables a sub-emitter
		/// @param  EmitterName                     The name of the sub-emitter to set it on
		/// @param  bNewEnableState         The value to set it to
		/// </summary>
		public extern virtual void SetEmitterEnable(FName EmitterName,bool bNewEnableState);
		/// <summary>
		/// Get the beam target strength
		/// @param  EmitterIndex            The index of the emitter to get
		/// @param  TargetIndex                     Which beam within the emitter to get
		/// @param  OutTargetStrength       Value of target tangent
		/// @return true            EmitterIndex and TargetIndex are valid - OutTargetStrength is valid
		///                 false           EmitterIndex or TargetIndex is invalid - OutTargetStrength is invalid
		/// </summary>
		public extern virtual bool GetBeamTargetStrength(int EmitterIndex,int TargetIndex,out float OutTargetStrength);
		/// <summary>
		/// Get the beam target tangent
		/// @param  EmitterIndex            The index of the emitter to get
		/// @param  TargetIndex                     Which beam within the emitter to get
		/// @param  OutTangentPoint         Value of target tangent
		/// @return true            EmitterIndex and TargetIndex are valid - OutTangentPoint is valid
		///                 false           EmitterIndex or TargetIndex is invalid - OutTangentPoint is invalid
		/// </summary>
		public extern virtual bool GetBeamTargetTangent(int EmitterIndex,int TargetIndex,out FVector OutTangentPoint);
		/// <summary>
		/// Get the beam target point
		/// @param  EmitterIndex            The index of the emitter to get
		/// @param  TargetIndex                     Which beam within the emitter to get
		/// @param  OutTargetPoint          Value of target point
		/// @return true            EmitterIndex and TargetIndex are valid - OutTargetPoint is valid
		///                 false           EmitterIndex or TargetIndex is invalid - OutTargetPoint is invalid
		/// </summary>
		public extern virtual bool GetBeamTargetPoint(int EmitterIndex,int TargetIndex,out FVector OutTargetPoint);
		/// <summary>
		/// Get the beam source strength
		/// @param  EmitterIndex            The index of the emitter to get
		/// @param  SourceIndex                     Which beam within the emitter to get
		/// @param  OutSourceStrength               Value of source tangent
		/// @return true            EmitterIndex and SourceIndex are valid - OutSourceStrength is valid
		///                 false           EmitterIndex or SourceIndex is invalid - OutSourceStrength is invalid
		/// </summary>
		public extern virtual bool GetBeamSourceStrength(int EmitterIndex,int SourceIndex,out float OutSourceStrength);
		/// <summary>
		/// Get the beam source tangent
		/// @param  EmitterIndex            The index of the emitter to get
		/// @param  SourceIndex                     Which beam within the emitter to get
		/// @param  OutTangentPoint         Value of source tangent
		/// @return true            EmitterIndex and SourceIndex are valid - OutTangentPoint is valid
		///                 false           EmitterIndex or SourceIndex is invalid - OutTangentPoint is invalid
		/// </summary>
		public extern virtual bool GetBeamSourceTangent(int EmitterIndex,int SourceIndex,out FVector OutTangentPoint);
		/// <summary>
		/// Get the beam source point
		/// @param  EmitterIndex            The index of the emitter to get
		/// @param  SourceIndex                     Which beam within the emitter to get
		/// @param  OutSourcePoint          Value of source point
		/// @return true            EmitterIndex and SourceIndex are valid - OutSourcePoint is valid
		///                 false           EmitterIndex or SourceIndex is invalid - OutSourcePoint is invalid
		/// </summary>
		public extern virtual bool GetBeamSourcePoint(int EmitterIndex,int SourceIndex,out FVector OutSourcePoint);
		/// <summary>
		/// Get the beam end point
		/// @param  EmitterIndex            The index of the emitter to get the value of
		/// @return true            EmitterIndex is valid and End point is set - OutEndPoint is valid
		///                 false           EmitterIndex invalid or End point is not set - OutEndPoint is invalid
		/// </summary>
		public extern virtual bool GetBeamEndPoint(int EmitterIndex,out FVector OutEndPoint);
		/// <summary>
		/// Set the beam target strength
		/// @param  EmitterIndex            The index of the emitter to set it on
		/// @param  NewTargetStrength       The value to set it to
		/// @param  TargetIndex                     Which beam within the emitter to set it on
		/// </summary>
		public extern virtual void SetBeamTargetStrength(int EmitterIndex,float NewTargetStrength,int TargetIndex);
		/// <summary>
		/// Set the beam target tangent
		/// @param  EmitterIndex            The index of the emitter to set it on
		/// @param  NewTangentPoint         The value to set it to
		/// @param  TargetIndex                     Which beam within the emitter to set it on
		/// </summary>
		public extern virtual void SetBeamTargetTangent(int EmitterIndex,FVector NewTangentPoint,int TargetIndex);
		/// <summary>
		/// Set the beam target point
		/// @param  EmitterIndex            The index of the emitter to set it on
		/// @param  NewTargetPoint          The value to set it to
		/// @param  TargetIndex                     Which beam within the emitter to set it on
		/// </summary>
		public extern virtual void SetBeamTargetPoint(int EmitterIndex,FVector NewTargetPoint,int TargetIndex);
		/// <summary>
		/// Set the beam source strength
		/// @param  EmitterIndex            The index of the emitter to set it on
		/// @param  NewSourceStrength       The value to set it to
		/// @param  SourceIndex                     Which beam within the emitter to set it on
		/// </summary>
		public extern virtual void SetBeamSourceStrength(int EmitterIndex,float NewSourceStrength,int SourceIndex);
		/// <summary>
		/// Set the beam source tangent
		/// @param  EmitterIndex            The index of the emitter to set it on
		/// @param  NewTangentPoint         The value to set it to
		/// @param  SourceIndex                     Which beam within the emitter to set it on
		/// </summary>
		public extern virtual void SetBeamSourceTangent(int EmitterIndex,FVector NewTangentPoint,int SourceIndex);
		/// <summary>
		/// Set the beam source point
		/// @param  EmitterIndex            The index of the emitter to set it on
		/// @param  NewSourcePoint          The value to set it to
		/// @param  SourceIndex                     Which beam within the emitter to set it on
		/// </summary>
		public extern virtual void SetBeamSourcePoint(int EmitterIndex,FVector NewSourcePoint,int SourceIndex);
		/// <summary>
		/// Set the beam end point
		/// @param  EmitterIndex            The index of the emitter to set it on
		/// @param  NewEndPoint                     The value to set it to
		/// </summary>
		public extern virtual void SetBeamEndPoint(int EmitterIndex,FVector NewEndPoint);
		public UParticleSystem Template;
		
		public bool bResetOnDetach;
		
		/// <summary>whether to update the particle system on dedicated servers</summary>
		public bool bUpdateOnDedicatedServer;
		
		/// <summary>
		/// If true, this Particle System will be available for recycling after it has completed. Auto-destroyed systems cannot be recycled.
		/// Some systems (currently particle trail effects) can recycle components to avoid respawning them to play new effects.
		/// This is only an optimization and does not change particle system behavior, aside from not triggering normal component initialization events more than once.
		/// </summary>
		public bool bAllowRecycling;
		
		/// <summary>
		/// True if we should automatically attach to AutoAttachParent when activated, and detach from our parent when completed.
		/// This overrides any current attachment that may be present at the time of activation (deferring initial attachment until activation, if AutoAttachParent is null).
		/// When enabled, detachment occurs regardless of whether AutoAttachParent is assigned, and the relative transform from the time of activation is restored.
		/// This also disables attachment on dedicated servers, where we don't actually activate even if bAutoActivate is true.
		/// @see AutoAttachParent, AutoAttachSocketName, AutoAttachLocationType
		/// </summary>
		public bool bAutoManageAttachment;
		
		public FVector OldPosition;
		
		public FVector PartSysVelocity;
		
		public float WarmupTime;
		
		public float WarmupTickRate;
		
		public bool bWarmingUp;
		
		/// <summary>
		/// Number of seconds of emitter not being rendered that need to pass before it
		/// no longer gets ticked/ becomes inactive.
		/// </summary>
		public float SecondsBeforeInactive;
		
		/// <summary>
		/// Time between forced UpdateTransforms for systems that use dynamically calculated bounds,
		/// Which is effectively how often the bounds are shrunk.
		/// </summary>
		public float MaxTimeBeforeForceUpdateTransform;
		
		/// <summary>INTERNAL. Used by the editor to set the LODLevel</summary>
		public int EditorLODLevel;
		
		/// <summary>Used for applying Cascade's detail mode setting to in-level particle systems</summary>
		public int EditorDetailMode;
		
		/// <summary>indicates that the component's LODMethod overrides the Template's</summary>
		public bool bOverrideLODMethod;
		
		/// <summary>The method of LOD level determination to utilize for this particle system</summary>
		public ParticleSystemLODMethod LODMethod;
		
		/// <summary>
		/// Flag indicating that dynamic updating of render data should NOT occur during Tick.
		/// This is used primarily to allow for warming up and simulated effects to a certain state.
		/// </summary>
		public bool bSkipUpdateDynamicDataDuringTick;
		
		/// <summary>Scales DeltaTime in UParticleSystemComponent::Tick(...)</summary>
		public float CustomTimeDilation;
		
		/// <summary>
		/// Socket we automatically attach to on the AutoAttachParent, if bAutoManageAttachment is true.
		/// @see bAutoManageAttachment
		/// </summary>
		public FName AutoAttachSocketName;
		
		/// <summary>
		/// DEPRECATED: Options for how we handle our location when we attach to the AutoAttachParent, if bAutoManageAttachment is true.
		/// @see bAutoManageAttachment, EAttachLocation::Type
		/// </summary>
		public EAttachLocation AutoAttachLocationType;
		
		
	}
	
}
