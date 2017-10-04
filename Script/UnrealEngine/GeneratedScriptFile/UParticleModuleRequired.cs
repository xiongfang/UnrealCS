using System;
namespace UnrealEngine
{
	public partial class UParticleModuleRequired:UParticleModule
	{
		/// <summary>The material to utilize for the emitter at this LOD level.</summary>
		public UMaterialInterface Material;
		
		public FVector EmitterOrigin;
		
		public FRotator EmitterRotation;
		
		/// <summary>
		/// The screen alignment to utilize for the emitter at this LOD level.
		/// One of the following:
		/// PSA_FacingCameraPosition - Faces the camera position, but is not dependent on the camera rotation.
		///                                                         This method produces more stable particles under camera rotation.
		/// PSA_Square                      - Uniform scale (via SizeX) facing the camera
		/// PSA_Rectangle           - Non-uniform scale (via SizeX and SizeY) facing the camera
		/// PSA_Velocity            - Orient the particle towards both the camera and the direction
		///                                           the particle is moving. Non-uniform scaling is allowed.
		/// PSA_TypeSpecific        - Use the alignment method indicated in the type data module.
		/// PSA_FacingCameraDistanceBlend - Blends between PSA_FacingCameraPosition and PSA_Square over specified distance.
		/// </summary>
		public EParticleScreenAlignment ScreenAlignment;
		
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_Square</summary>
		public float MinFacingCameraBlendDistance;
		
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_FacingCameraPosition</summary>
		public float MaxFacingCameraBlendDistance;
		
		/// <summary>If true, update the emitter in local space</summary>
		public bool bUseLocalSpace;
		
		/// <summary>If true, kill the emitter when the particle system is deactivated</summary>
		public bool bKillOnDeactivate;
		
		/// <summary>If true, kill the emitter when it completes</summary>
		public bool bKillOnCompleted;
		
		/// <summary>
		/// The sorting mode to use for this emitter.
		/// PSORTMODE_None                          - No sorting required.
		/// PSORTMODE_ViewProjDepth         - Sort by view projected depth of the particle.
		/// PSORTMODE_DistanceToView        - Sort by distance of particle to view in world space.
		/// PSORTMODE_Age_OldestFirst       - Sort by age, oldest drawn first.
		/// PSORTMODE_Age_NewestFirst       - Sort by age, newest drawn first.
		/// </summary>
		public EParticleSortMode SortMode;
		
		/// <summary>
		/// If true, the EmitterTime for the emitter will be calculated by
		/// modulating the SecondsSinceCreation by the EmitterDuration. As
		/// this can lead to issues w/ looping and variable duration, a new
		/// approach has been implemented.
		/// If false, this new approach is utilized, and the EmitterTime is
		/// simply incremented by DeltaTime each tick. When the emitter
		/// loops, it adjusts the EmitterTime by the current EmitterDuration
		/// resulting in proper looping/delay behavior.
		/// </summary>
		public bool bUseLegacyEmitterTime;
		
		/// <summary>If true, removes the HMD view roll (e.g. in VR)</summary>
		public bool bRemoveHMDRoll;
		
		/// <summary>How long, in seconds, the emitter will run before looping.</summary>
		public float EmitterDuration;
		
		/// <summary>The low end of the emitter duration if using a range.</summary>
		public float EmitterDurationLow;
		
		/// <summary>
		/// If true, select the emitter duration from the range
		///         [EmitterDurationLow..EmitterDuration]
		/// </summary>
		public bool bEmitterDurationUseRange;
		
		/// <summary>If true, recalculate the emitter duration on each loop.</summary>
		public bool bDurationRecalcEachLoop;
		
		/// <summary>
		/// The number of times to loop the emitter.
		///     0 indicates loop continuously
		/// </summary>
		public int EmitterLoops;
		
		/// <summary>The rate at which to spawn particles</summary>
		public FRawDistributionFloat SpawnRate;
		
		/// <summary>The method to utilize when burst-emitting particles</summary>
		public EParticleBurstMethod ParticleBurstMethod;
		
		/// <summary>Indicates the time (in seconds) that this emitter should be delayed in the particle system.</summary>
		public float EmitterDelay;
		
		/// <summary>The low end of the emitter delay if using a range.</summary>
		public float EmitterDelayLow;
		
		/// <summary>
		/// If true, select the emitter delay from the range
		///         [EmitterDelayLow..EmitterDelay]
		/// </summary>
		public bool bEmitterDelayUseRange;
		
		/// <summary>If true, the emitter will be delayed only on the first loop.</summary>
		public bool bDelayFirstLoopOnly;
		
		/// <summary>
		/// The interpolation method to used for the SubUV image selection.
		/// One of the following:
		/// PSUVIM_None                     - Do not apply SubUV modules to this emitter.
		/// PSUVIM_Linear           - Smoothly transition between sub-images in the given order,
		///                                           with no blending between the current and the next
		/// PSUVIM_Linear_Blend     - Smoothly transition between sub-images in the given order,
		///                                           blending between the current and the next
		/// PSUVIM_Random           - Pick the next image at random, with no blending between
		///                                           the current and the next
		/// PSUVIM_Random_Blend     - Pick the next image at random, blending between the current
		///                                           and the next
		/// </summary>
		public EParticleSubUVInterpMethod InterpolationMethod;
		
		/// <summary>The number of sub-images horizontally in the texture</summary>
		public int SubImages_Horizontal;
		
		/// <summary>The number of sub-images vertically in the texture</summary>
		public int SubImages_Vertical;
		
		/// <summary>Whether to scale the UV or not - ie, the model wasn't setup with sub uvs</summary>
		public bool bScaleUV;
		
		/// <summary>
		/// The amount of time (particle-relative, 0.0 to 1.0) to 'lock' on a random sub image
		///     0.0 = change every frame
		/// 1.0 = select a random image at spawn and hold for the life of the particle
		/// </summary>
		public float RandomImageTime;
		
		/// <summary>The number of times to change a random image over the life of the particle.</summary>
		public int RandomImageChanges;
		
		/// <summary>Override the system MacroUV settings</summary>
		public bool bOverrideSystemMacroUV;
		
		/// <summary>Local space position that UVs generated with the ParticleMacroUV material node will be centered on.</summary>
		public FVector MacroUVPosition;
		
		/// <summary>World space radius that UVs generated with the ParticleMacroUV material node will tile based on.</summary>
		public float MacroUVRadius;
		
		/// <summary>
		/// If true, use the MaxDrawCount to limit the number of particles rendered.
		/// NOTE: This does not limit the number spawned/updated, only what is drawn.
		/// </summary>
		public bool bUseMaxDrawCount;
		
		/// <summary>
		/// The maximum number of particles to DRAW for this emitter.
		/// If set to 0, it will use whatever number are present.
		/// </summary>
		public int MaxDrawCount;
		
		/// <summary>Texture to generate bounding geometry from.</summary>
		public UTexture2D CutoutTexture;
		
		/// <summary>
		/// More bounding vertices results in reduced overdraw, but adds more triangle overhead.
		/// The eight vertex mode is best used when the SubUV texture has a lot of space to cut out that is not captured by the four vertex version,
		/// and when the particles using the texture will be few and large.
		/// </summary>
		public ESubUVBoundingVertexCount BoundingMode;
		
		public EOpacitySourceMode OpacitySourceMode;
		
		/// <summary>
		/// Alpha channel values larger than the threshold are considered occupied and will be contained in the bounding geometry.
		/// Raising this threshold slightly can reduce overdraw in particles using this animation asset.
		/// </summary>
		public float AlphaThreshold;
		
		/// <summary>Normal generation mode for this emitter LOD.</summary>
		public EEmitterNormalsMode EmitterNormalsMode;
		
		/// <summary>
		/// When EmitterNormalsMode is ENM_Spherical, particle normals are created to face away from NormalsSphereCenter.
		/// NormalsSphereCenter is in local space.
		/// </summary>
		public FVector NormalsSphereCenter;
		
		/// <summary>
		/// When EmitterNormalsMode is ENM_Cylindrical,
		/// particle normals are created to face away from the cylinder going through NormalsSphereCenter in the direction NormalsCylinderDirection.
		/// NormalsCylinderDirection is in local space.
		/// </summary>
		public FVector NormalsCylinderDirection;
		
		/// <summary>Ensures that movement generated from the orbit module is applied to velocity-aligned particles</summary>
		public bool bOrbitModuleAffectsVelocityAlignment;
		
		
	}
	
}
