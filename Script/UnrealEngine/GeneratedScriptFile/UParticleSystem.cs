using System;
namespace UnrealEngine
{
	public partial class UParticleSystem:UObject
	{
		public EParticleSystemUpdateMode SystemUpdateMode;
		
		/// <summary>UpdateTime_FPS - the frame per second to update at in FixedTime mode</summary>
		public float UpdateTime_FPS;
		
		/// <summary>UpdateTime_Delta       - internal</summary>
		public float UpdateTime_Delta;
		
		/// <summary>WarmupTime     - the time to warm-up the particle system when first rendered</summary>
		public float WarmupTime;
		
		/// <summary>
		/// WarmupTickRate - the time step for each tick during warm up.
		///        Increasing this improves performance. Decreasing, improves accuracy.
		///        Set to 0 to use the default tick time.
		/// </summary>
		public float WarmupTickRate;
		
		/// <summary>The component used to preview the particle system in Cascade</summary>
		public UParticleSystemComponent PreviewComponent;
		
		/// <summary>The angle to use when rendering the thumbnail image</summary>
		public FRotator ThumbnailAngle;
		
		/// <summary>The distance to place the system when rendering the thumbnail image</summary>
		public float ThumbnailDistance;
		
		/// <summary>The time to warm-up the system for the thumbnail image</summary>
		public float ThumbnailWarmup;
		
		/// <summary>Used for curve editor to remember curve-editing setup.</summary>
		public UInterpCurveEdSetup CurveEdSetup;
		
		/// <summary>If true, the system's Z axis will be oriented toward the camera</summary>
		public bool bOrientZAxisTowardCamera;
		
		/// <summary>How often (in seconds) the system should perform the LOD distance check.</summary>
		public float LODDistanceCheckTime;
		
		/// <summary>
		/// The method of LOD level determination to utilize for this particle system
		///   PARTICLESYSTEMLODMETHOD_Automatic - Automatically set the LOD level, checking every LODDistanceCheckTime seconds.
		/// PARTICLESYSTEMLODMETHOD_DirectSet - LOD level is directly set by the game code.
		/// PARTICLESYSTEMLODMETHOD_ActivateAutomatic - LOD level is determined at Activation time, then left alone unless directly set by game code.
		/// </summary>
		public ParticleSystemLODMethod LODMethod;
		
		/// <summary>LOD setting for intepolation (set by Cascade) Range [0..100]</summary>
		public int EditorLODSetting;
		
		/// <summary>
		/// Internal value that tracks the regenerate LOD levels preference.
		/// If true, when autoregenerating LOD levels in code, the low level will
		/// be a duplicate of the high.
		/// </summary>
		public bool bRegenerateLODDuplicate;
		
		/// <summary>Whether to use the fixed relative bounding box or calculate it every frame.</summary>
		public bool bUseFixedRelativeBoundingBox;
		
		/// <summary>Fixed relative bounding box for particle system.</summary>
		public FBox FixedRelativeBoundingBox;
		
		/// <summary>
		/// Number of seconds of emitter not being rendered that need to pass before it
		/// no longer gets ticked/ becomes inactive.
		/// </summary>
		public float SecondsBeforeInactive;
		
		/// <summary>Cascade 'floor' mesh information.</summary>
		public FString FloorMesh;
		
		public FVector FloorPosition;
		
		public FRotator FloorRotation;
		
		public float FloorScale;
		
		public FVector FloorScale3D;
		
		/// <summary>The background color to display in Cascade</summary>
		public FColor BackgroundColor;
		
		/// <summary>EDITOR ONLY: Indicates that Cascade would like to have the PeakActiveParticles count reset</summary>
		public bool bShouldResetPeakCounts;
		
		/// <summary>Set during load time to indicate that physics is used...</summary>
		public bool bHasPhysics;
		
		/// <summary>Inidicates the old 'real-time' thumbnail rendering should be used</summary>
		public bool bUseRealtimeThumbnail;
		
		/// <summary>Internal: Indicates the PSys thumbnail image is out of date</summary>
		public bool ThumbnailImageOutOfDate;
		
		/// <summary>Internal: The PSys thumbnail image</summary>
		public UTexture2D ThumbnailImage;
		
		/// <summary>How long this Particle system should delay when ActivateSystem is called on it.</summary>
		public float Delay;
		
		/// <summary>The low end of the emitter delay if using a range.</summary>
		public float DelayLow;
		
		/// <summary>
		/// If true, select the emitter delay from the range
		///         [DelayLow..Delay]
		/// </summary>
		public bool bUseDelayRange;
		
		/// <summary>Auto-deactivate system if all emitters are determined to not spawn particles again, regardless of lifetime.</summary>
		public bool bAutoDeactivate;
		
		/// <summary>Minimum duration between ticks; 33=tick at max. 30FPS, 16=60FPS, 8=120FPS</summary>
		public uint MinTimeBetweenTicks;
		
		/// <summary>Time delay between all emitters becoming insignificant and the systems insignificant reaction.</summary>
		public float InsignificanceDelay;
		
		/// <summary>Local space position that UVs generated with the ParticleMacroUV material node will be centered on.</summary>
		public FVector MacroUVPosition;
		
		/// <summary>World space radius that UVs generated with the ParticleMacroUV material node will tile based on.</summary>
		public float MacroUVRadius;
		
		/// <summary>
		/// Which occlusion bounds method to use for this particle system.
		/// EPSOBM_None - Don't determine occlusion for this system.
		/// EPSOBM_ParticleBounds - Use the bounds of the component when determining occlusion.
		/// </summary>
		public EParticleSystemOcclusionBoundsMethod OcclusionBoundsMethod;
		
		/// <summary>The occlusion bounds to use if OcclusionBoundsMethod is set to EPSOBM_CustomBounds</summary>
		public FBox CustomOcclusionBounds;
		
		
	}
	
}
