#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleRequired
	{
		static readonly int Material__Offset;
		/// <summary>The material to utilize for the emitter at this LOD level.</summary>
		public UMaterialInterface Material
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Material__Offset); if (v == IntPtr.Zero)return null; UMaterialInterface retValue = new UMaterialInterface(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Material__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Material__Offset, value._this.Get()); }
			
		}
		
		static readonly int EmitterOrigin__Offset;
		public FVector EmitterOrigin
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+EmitterOrigin__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterOrigin__Offset, false);}
			
		}
		
		static readonly int EmitterRotation__Offset;
		public FRotator EmitterRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+EmitterRotation__Offset, typeof(FRotator));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterRotation__Offset, false);}
			
		}
		
		static readonly int ScreenAlignment__Offset;
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
		public EParticleScreenAlignment ScreenAlignment
		{
			get{ CheckIsValid();return (EParticleScreenAlignment)Marshal.PtrToStructure(_this.Get()+ScreenAlignment__Offset, typeof(EParticleScreenAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScreenAlignment__Offset, false);}
			
		}
		
		static readonly int MinFacingCameraBlendDistance__Offset;
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_Square</summary>
		public float MinFacingCameraBlendDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinFacingCameraBlendDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinFacingCameraBlendDistance__Offset, false);}
			
		}
		
		static readonly int MaxFacingCameraBlendDistance__Offset;
		/// <summary>The distance at which PSA_FacingCameraDistanceBlend    is fully PSA_FacingCameraPosition</summary>
		public float MaxFacingCameraBlendDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxFacingCameraBlendDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxFacingCameraBlendDistance__Offset, false);}
			
		}
		
		static readonly int bUseLocalSpace__Offset;
		/// <summary>If true, update the emitter in local space</summary>
		public bool bUseLocalSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseLocalSpace__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseLocalSpace__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bKillOnDeactivate__Offset;
		/// <summary>If true, kill the emitter when the particle system is deactivated</summary>
		public bool bKillOnDeactivate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bKillOnDeactivate__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bKillOnDeactivate__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bKillOnCompleted__Offset;
		/// <summary>If true, kill the emitter when it completes</summary>
		public bool bKillOnCompleted
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bKillOnCompleted__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bKillOnCompleted__Offset, 1,0,4,4);}
			
		}
		
		static readonly int SortMode__Offset;
		/// <summary>
		/// The sorting mode to use for this emitter.
		/// PSORTMODE_None                          - No sorting required.
		/// PSORTMODE_ViewProjDepth         - Sort by view projected depth of the particle.
		/// PSORTMODE_DistanceToView        - Sort by distance of particle to view in world space.
		/// PSORTMODE_Age_OldestFirst       - Sort by age, oldest drawn first.
		/// PSORTMODE_Age_NewestFirst       - Sort by age, newest drawn first.
		/// </summary>
		public EParticleSortMode SortMode
		{
			get{ CheckIsValid();return (EParticleSortMode)Marshal.PtrToStructure(_this.Get()+SortMode__Offset, typeof(EParticleSortMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SortMode__Offset, false);}
			
		}
		
		static readonly int bUseLegacyEmitterTime__Offset;
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
		public bool bUseLegacyEmitterTime
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseLegacyEmitterTime__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseLegacyEmitterTime__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bRemoveHMDRoll__Offset;
		/// <summary>If true, removes the HMD view roll (e.g. in VR)</summary>
		public bool bRemoveHMDRoll
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRemoveHMDRoll__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRemoveHMDRoll__Offset, 1,0,2,2);}
			
		}
		
		static readonly int EmitterDuration__Offset;
		/// <summary>How long, in seconds, the emitter will run before looping.</summary>
		public float EmitterDuration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmitterDuration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterDuration__Offset, false);}
			
		}
		
		static readonly int EmitterDurationLow__Offset;
		/// <summary>The low end of the emitter duration if using a range.</summary>
		public float EmitterDurationLow
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmitterDurationLow__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterDurationLow__Offset, false);}
			
		}
		
		static readonly int bEmitterDurationUseRange__Offset;
		/// <summary>
		/// If true, select the emitter duration from the range
		///         [EmitterDurationLow..EmitterDuration]
		/// </summary>
		public bool bEmitterDurationUseRange
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEmitterDurationUseRange__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEmitterDurationUseRange__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDurationRecalcEachLoop__Offset;
		/// <summary>If true, recalculate the emitter duration on each loop.</summary>
		public bool bDurationRecalcEachLoop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDurationRecalcEachLoop__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDurationRecalcEachLoop__Offset, 1,0,2,2);}
			
		}
		
		static readonly int EmitterLoops__Offset;
		/// <summary>
		/// The number of times to loop the emitter.
		///     0 indicates loop continuously
		/// </summary>
		public int EmitterLoops
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EmitterLoops__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterLoops__Offset, false);}
			
		}
		
		static readonly int SpawnRate__Offset;
		/// <summary>The rate at which to spawn particles</summary>
		public FRawDistributionFloat SpawnRate
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+SpawnRate__Offset, typeof(FRawDistributionFloat));}
			
		}
		
		static readonly int ParticleBurstMethod__Offset;
		/// <summary>The method to utilize when burst-emitting particles</summary>
		public EParticleBurstMethod ParticleBurstMethod
		{
			get{ CheckIsValid();return (EParticleBurstMethod)Marshal.PtrToStructure(_this.Get()+ParticleBurstMethod__Offset, typeof(EParticleBurstMethod));}
			
		}
		
		static readonly int BurstList__Offset;
		/// <summary>The array of burst entries.</summary>
		public TStructArray<FParticleBurst> BurstList
		{
			get{ CheckIsValid();return new TStructArray<FParticleBurst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BurstList__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BurstList__Offset, false);}
			
		}
		
		static readonly int EmitterDelay__Offset;
		/// <summary>Indicates the time (in seconds) that this emitter should be delayed in the particle system.</summary>
		public float EmitterDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmitterDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterDelay__Offset, false);}
			
		}
		
		static readonly int EmitterDelayLow__Offset;
		/// <summary>The low end of the emitter delay if using a range.</summary>
		public float EmitterDelayLow
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmitterDelayLow__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterDelayLow__Offset, false);}
			
		}
		
		static readonly int bEmitterDelayUseRange__Offset;
		/// <summary>
		/// If true, select the emitter delay from the range
		///         [EmitterDelayLow..EmitterDelay]
		/// </summary>
		public bool bEmitterDelayUseRange
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEmitterDelayUseRange__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEmitterDelayUseRange__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDelayFirstLoopOnly__Offset;
		/// <summary>If true, the emitter will be delayed only on the first loop.</summary>
		public bool bDelayFirstLoopOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDelayFirstLoopOnly__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDelayFirstLoopOnly__Offset, 1,0,2,2);}
			
		}
		
		static readonly int InterpolationMethod__Offset;
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
		public EParticleSubUVInterpMethod InterpolationMethod
		{
			get{ CheckIsValid();return (EParticleSubUVInterpMethod)Marshal.PtrToStructure(_this.Get()+InterpolationMethod__Offset, typeof(EParticleSubUVInterpMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpolationMethod__Offset, false);}
			
		}
		
		static readonly int SubImages_Horizontal__Offset;
		/// <summary>The number of sub-images horizontally in the texture</summary>
		public int SubImages_Horizontal
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImages_Horizontal__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImages_Horizontal__Offset, false);}
			
		}
		
		static readonly int SubImages_Vertical__Offset;
		/// <summary>The number of sub-images vertically in the texture</summary>
		public int SubImages_Vertical
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImages_Vertical__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImages_Vertical__Offset, false);}
			
		}
		
		static readonly int bScaleUV__Offset;
		/// <summary>Whether to scale the UV or not - ie, the model wasn't setup with sub uvs</summary>
		public bool bScaleUV
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScaleUV__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bScaleUV__Offset, 1,0,1,1);}
			
		}
		
		static readonly int RandomImageTime__Offset;
		/// <summary>
		/// The amount of time (particle-relative, 0.0 to 1.0) to 'lock' on a random sub image
		///     0.0 = change every frame
		/// 1.0 = select a random image at spawn and hold for the life of the particle
		/// </summary>
		public float RandomImageTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RandomImageTime__Offset, typeof(float));}
			
		}
		
		static readonly int RandomImageChanges__Offset;
		/// <summary>The number of times to change a random image over the life of the particle.</summary>
		public int RandomImageChanges
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RandomImageChanges__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RandomImageChanges__Offset, false);}
			
		}
		
		static readonly int bOverrideSystemMacroUV__Offset;
		/// <summary>Override the system MacroUV settings</summary>
		public bool bOverrideSystemMacroUV
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideSystemMacroUV__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideSystemMacroUV__Offset, 1,0,1,1);}
			
		}
		
		static readonly int MacroUVPosition__Offset;
		/// <summary>Local space position that UVs generated with the ParticleMacroUV material node will be centered on.</summary>
		public FVector MacroUVPosition
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+MacroUVPosition__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MacroUVPosition__Offset, false);}
			
		}
		
		static readonly int MacroUVRadius__Offset;
		/// <summary>World space radius that UVs generated with the ParticleMacroUV material node will tile based on.</summary>
		public float MacroUVRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MacroUVRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MacroUVRadius__Offset, false);}
			
		}
		
		static readonly int bUseMaxDrawCount__Offset;
		/// <summary>
		/// If true, use the MaxDrawCount to limit the number of particles rendered.
		/// NOTE: This does not limit the number spawned/updated, only what is drawn.
		/// </summary>
		public bool bUseMaxDrawCount
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseMaxDrawCount__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseMaxDrawCount__Offset, 1,0,1,1);}
			
		}
		
		static readonly int MaxDrawCount__Offset;
		/// <summary>
		/// The maximum number of particles to DRAW for this emitter.
		/// If set to 0, it will use whatever number are present.
		/// </summary>
		public int MaxDrawCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxDrawCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDrawCount__Offset, false);}
			
		}
		
		static readonly int CutoutTexture__Offset;
		/// <summary>Texture to generate bounding geometry from.</summary>
		public UTexture2D CutoutTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CutoutTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CutoutTexture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CutoutTexture__Offset, value._this.Get()); }
			
		}
		
		static readonly int BoundingMode__Offset;
		/// <summary>
		/// More bounding vertices results in reduced overdraw, but adds more triangle overhead.
		/// The eight vertex mode is best used when the SubUV texture has a lot of space to cut out that is not captured by the four vertex version,
		/// and when the particles using the texture will be few and large.
		/// </summary>
		public ESubUVBoundingVertexCount BoundingMode
		{
			get{ CheckIsValid();return (ESubUVBoundingVertexCount)Marshal.PtrToStructure(_this.Get()+BoundingMode__Offset, typeof(ESubUVBoundingVertexCount));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoundingMode__Offset, false);}
			
		}
		
		static readonly int OpacitySourceMode__Offset;
		public EOpacitySourceMode OpacitySourceMode
		{
			get{ CheckIsValid();return (EOpacitySourceMode)Marshal.PtrToStructure(_this.Get()+OpacitySourceMode__Offset, typeof(EOpacitySourceMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OpacitySourceMode__Offset, false);}
			
		}
		
		static readonly int AlphaThreshold__Offset;
		/// <summary>
		/// Alpha channel values larger than the threshold are considered occupied and will be contained in the bounding geometry.
		/// Raising this threshold slightly can reduce overdraw in particles using this animation asset.
		/// </summary>
		public float AlphaThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AlphaThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaThreshold__Offset, false);}
			
		}
		
		static readonly int EmitterNormalsMode__Offset;
		/// <summary>Normal generation mode for this emitter LOD.</summary>
		public EEmitterNormalsMode EmitterNormalsMode
		{
			get{ CheckIsValid();return (EEmitterNormalsMode)Marshal.PtrToStructure(_this.Get()+EmitterNormalsMode__Offset, typeof(EEmitterNormalsMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterNormalsMode__Offset, false);}
			
		}
		
		static readonly int NormalsSphereCenter__Offset;
		/// <summary>
		/// When EmitterNormalsMode is ENM_Spherical, particle normals are created to face away from NormalsSphereCenter.
		/// NormalsSphereCenter is in local space.
		/// </summary>
		public FVector NormalsSphereCenter
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+NormalsSphereCenter__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalsSphereCenter__Offset, false);}
			
		}
		
		static readonly int NormalsCylinderDirection__Offset;
		/// <summary>
		/// When EmitterNormalsMode is ENM_Cylindrical,
		/// particle normals are created to face away from the cylinder going through NormalsSphereCenter in the direction NormalsCylinderDirection.
		/// NormalsCylinderDirection is in local space.
		/// </summary>
		public FVector NormalsCylinderDirection
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+NormalsCylinderDirection__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalsCylinderDirection__Offset, false);}
			
		}
		
		static readonly int bOrbitModuleAffectsVelocityAlignment__Offset;
		/// <summary>Ensures that movement generated from the orbit module is applied to velocity-aligned particles</summary>
		public bool bOrbitModuleAffectsVelocityAlignment
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOrbitModuleAffectsVelocityAlignment__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOrbitModuleAffectsVelocityAlignment__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NamedMaterialOverrides__Offset;
		/// <summary>
		/// Named material overrides for this emitter.
		/// Overrides this emitter's material(s) with those in the correspondingly named slot(s) of the owning system.
		/// </summary>
		public TStructArray<FName> NamedMaterialOverrides
		{
			get{ CheckIsValid();return new TStructArray<FName>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NamedMaterialOverrides__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NamedMaterialOverrides__Offset, false);}
			
		}
		
		static UParticleModuleRequired()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleRequired");
			Material__Offset=GetPropertyOffset(NativeClassPtr,"Material");
			EmitterOrigin__Offset=GetPropertyOffset(NativeClassPtr,"EmitterOrigin");
			EmitterRotation__Offset=GetPropertyOffset(NativeClassPtr,"EmitterRotation");
			ScreenAlignment__Offset=GetPropertyOffset(NativeClassPtr,"ScreenAlignment");
			MinFacingCameraBlendDistance__Offset=GetPropertyOffset(NativeClassPtr,"MinFacingCameraBlendDistance");
			MaxFacingCameraBlendDistance__Offset=GetPropertyOffset(NativeClassPtr,"MaxFacingCameraBlendDistance");
			bUseLocalSpace__Offset=GetPropertyOffset(NativeClassPtr,"bUseLocalSpace");
			bKillOnDeactivate__Offset=GetPropertyOffset(NativeClassPtr,"bKillOnDeactivate");
			bKillOnCompleted__Offset=GetPropertyOffset(NativeClassPtr,"bKillOnCompleted");
			SortMode__Offset=GetPropertyOffset(NativeClassPtr,"SortMode");
			bUseLegacyEmitterTime__Offset=GetPropertyOffset(NativeClassPtr,"bUseLegacyEmitterTime");
			bRemoveHMDRoll__Offset=GetPropertyOffset(NativeClassPtr,"bRemoveHMDRoll");
			EmitterDuration__Offset=GetPropertyOffset(NativeClassPtr,"EmitterDuration");
			EmitterDurationLow__Offset=GetPropertyOffset(NativeClassPtr,"EmitterDurationLow");
			bEmitterDurationUseRange__Offset=GetPropertyOffset(NativeClassPtr,"bEmitterDurationUseRange");
			bDurationRecalcEachLoop__Offset=GetPropertyOffset(NativeClassPtr,"bDurationRecalcEachLoop");
			EmitterLoops__Offset=GetPropertyOffset(NativeClassPtr,"EmitterLoops");
			SpawnRate__Offset=GetPropertyOffset(NativeClassPtr,"SpawnRate");
			ParticleBurstMethod__Offset=GetPropertyOffset(NativeClassPtr,"ParticleBurstMethod");
			BurstList__Offset=GetPropertyOffset(NativeClassPtr,"BurstList");
			EmitterDelay__Offset=GetPropertyOffset(NativeClassPtr,"EmitterDelay");
			EmitterDelayLow__Offset=GetPropertyOffset(NativeClassPtr,"EmitterDelayLow");
			bEmitterDelayUseRange__Offset=GetPropertyOffset(NativeClassPtr,"bEmitterDelayUseRange");
			bDelayFirstLoopOnly__Offset=GetPropertyOffset(NativeClassPtr,"bDelayFirstLoopOnly");
			InterpolationMethod__Offset=GetPropertyOffset(NativeClassPtr,"InterpolationMethod");
			SubImages_Horizontal__Offset=GetPropertyOffset(NativeClassPtr,"SubImages_Horizontal");
			SubImages_Vertical__Offset=GetPropertyOffset(NativeClassPtr,"SubImages_Vertical");
			bScaleUV__Offset=GetPropertyOffset(NativeClassPtr,"bScaleUV");
			RandomImageTime__Offset=GetPropertyOffset(NativeClassPtr,"RandomImageTime");
			RandomImageChanges__Offset=GetPropertyOffset(NativeClassPtr,"RandomImageChanges");
			bOverrideSystemMacroUV__Offset=GetPropertyOffset(NativeClassPtr,"bOverrideSystemMacroUV");
			MacroUVPosition__Offset=GetPropertyOffset(NativeClassPtr,"MacroUVPosition");
			MacroUVRadius__Offset=GetPropertyOffset(NativeClassPtr,"MacroUVRadius");
			bUseMaxDrawCount__Offset=GetPropertyOffset(NativeClassPtr,"bUseMaxDrawCount");
			MaxDrawCount__Offset=GetPropertyOffset(NativeClassPtr,"MaxDrawCount");
			CutoutTexture__Offset=GetPropertyOffset(NativeClassPtr,"CutoutTexture");
			BoundingMode__Offset=GetPropertyOffset(NativeClassPtr,"BoundingMode");
			OpacitySourceMode__Offset=GetPropertyOffset(NativeClassPtr,"OpacitySourceMode");
			AlphaThreshold__Offset=GetPropertyOffset(NativeClassPtr,"AlphaThreshold");
			EmitterNormalsMode__Offset=GetPropertyOffset(NativeClassPtr,"EmitterNormalsMode");
			NormalsSphereCenter__Offset=GetPropertyOffset(NativeClassPtr,"NormalsSphereCenter");
			NormalsCylinderDirection__Offset=GetPropertyOffset(NativeClassPtr,"NormalsCylinderDirection");
			bOrbitModuleAffectsVelocityAlignment__Offset=GetPropertyOffset(NativeClassPtr,"bOrbitModuleAffectsVelocityAlignment");
			NamedMaterialOverrides__Offset=GetPropertyOffset(NativeClassPtr,"NamedMaterialOverrides");
			
		}
		
	}
	
}
#endif
#endif
