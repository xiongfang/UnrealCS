#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// PrimitiveComponents are SceneComponents that contain or generate some sort of geometry, generally to be rendered or used as collision data.
	/// There are several subclasses for the various types of geometry, but the most common by far are the ShapeComponents (Capsule, Sphere, Box), StaticMeshComponent, and SkeletalMeshComponent.
	/// ShapeComponents generate geometry that is used for collision detection but are not rendered, while StaticMeshComponents and SkeletalMeshComponents contain pre-built geometry that is rendered, but can also be used for collision detection.
	/// </summary>
	public partial class UPrimitiveComponent
	{
		static readonly int MinDrawDistance__Offset;
		/// <summary>
		/// The minimum distance at which the primitive should be rendered,
		/// measured in world space units from the center of the primitive's bounding sphere to the camera position.
		/// </summary>
		public float MinDrawDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDrawDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDrawDistance__Offset, false);}
			
		}
		
		static readonly int LDMaxDrawDistance__Offset;
		/// <summary>Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object.</summary>
		public float LDMaxDrawDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LDMaxDrawDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LDMaxDrawDistance__Offset, false);}
			
		}
		
		static readonly int CachedMaxDrawDistance__Offset;
		/// <summary>
		/// The distance to cull this primitive at.
		/// A CachedMaxDrawDistance of 0 indicates that the primitive should not be culled by distance.
		/// </summary>
		public float CachedMaxDrawDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CachedMaxDrawDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CachedMaxDrawDistance__Offset, false);}
			
		}
		
		static readonly int DepthPriorityGroup__Offset;
		/// <summary>The scene depth priority group to draw the primitive in.</summary>
		public ESceneDepthPriorityGroup DepthPriorityGroup
		{
			get{ CheckIsValid();return (ESceneDepthPriorityGroup)Marshal.PtrToStructure(_this.Get()+DepthPriorityGroup__Offset, typeof(ESceneDepthPriorityGroup));}
			
		}
		
		static readonly int ViewOwnerDepthPriorityGroup__Offset;
		/// <summary>The scene depth priority group to draw the primitive in, if it's being viewed by its owner.</summary>
		public ESceneDepthPriorityGroup ViewOwnerDepthPriorityGroup
		{
			get{ CheckIsValid();return (ESceneDepthPriorityGroup)Marshal.PtrToStructure(_this.Get()+ViewOwnerDepthPriorityGroup__Offset, typeof(ESceneDepthPriorityGroup));}
			
		}
		
		static readonly int bAlwaysCreatePhysicsState__Offset;
		/// <summary>
		/// Indicates if we'd like to create physics state all the time (for collision and simulation).
		/// If you set this to false, it still will create physics state if collision or simulation activated.
		/// This can help performance if you'd like to avoid overhead of creating physics state when triggers
		/// </summary>
		public bool bAlwaysCreatePhysicsState
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysCreatePhysicsState__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysCreatePhysicsState__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bGenerateOverlapEvents__Offset;
		/// <summary>
		/// If true, this component will generate overlap events when it is overlapping other components (eg Begin Overlap).
		/// Both components (this and the other) must have this enabled for overlap events to occur.
		/// @see [Overlap Events](https://docs.unrealengine.com/latest/INT/Engine/Physics/Collision/index.html#overlapandgenerateoverlapevents)
		/// @see UpdateOverlaps(), BeginComponentOverlap(), EndComponentOverlap()
		/// </summary>
		public bool bGenerateOverlapEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateOverlapEvents__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateOverlapEvents__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bMultiBodyOverlap__Offset;
		/// <summary>
		/// If true, this component will generate individual overlaps for each overlapping physics body if it is a multi-body component. When false, this component will
		/// generate only one overlap, regardless of how many physics bodies it has and how many of them are overlapping another component/body. This flag has no
		/// influence on single body components.
		/// </summary>
		public bool bMultiBodyOverlap
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMultiBodyOverlap__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMultiBodyOverlap__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bCheckAsyncSceneOnMove__Offset;
		/// <summary>
		/// If true, this component will look for collisions on both physic scenes during movement.
		/// Only required if the asynchronous physics scene is enabled and has geometry in it, and you wish to test for collisions with objects in that scene.
		/// @see MoveComponent()
		/// </summary>
		public bool bCheckAsyncSceneOnMove
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCheckAsyncSceneOnMove__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCheckAsyncSceneOnMove__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bTraceComplexOnMove__Offset;
		/// <summary>
		/// If true, component sweeps with this component should trace against complex collision during movement (for example, each triangle of a mesh).
		/// If false, collision will be resolved against simple collision bounds instead.
		/// @see MoveComponent()
		/// </summary>
		public bool bTraceComplexOnMove
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTraceComplexOnMove__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTraceComplexOnMove__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bReturnMaterialOnMove__Offset;
		/// <summary>
		/// If true, component sweeps will return the material in their hit result.
		/// @see MoveComponent(), FHitResult
		/// </summary>
		public bool bReturnMaterialOnMove
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReturnMaterialOnMove__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReturnMaterialOnMove__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bUseViewOwnerDepthPriorityGroup__Offset;
		/// <summary>True if the primitive should be rendered using ViewOwnerDepthPriorityGroup if viewed by its owner.</summary>
		public bool bUseViewOwnerDepthPriorityGroup
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseViewOwnerDepthPriorityGroup__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bAllowCullDistanceVolume__Offset;
		/// <summary>Whether to accept cull distance volumes to modify cached cull distance.</summary>
		public bool bAllowCullDistanceVolume
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowCullDistanceVolume__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowCullDistanceVolume__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bHasMotionBlurVelocityMeshes__Offset;
		/// <summary>true if the primitive has motion blur velocity meshes</summary>
		public bool bHasMotionBlurVelocityMeshes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasMotionBlurVelocityMeshes__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bVisibleInReflectionCaptures__Offset;
		/// <summary>If true, this component will be visible in reflection captures.</summary>
		public bool bVisibleInReflectionCaptures
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVisibleInReflectionCaptures__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVisibleInReflectionCaptures__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bRenderInMainPass__Offset;
		/// <summary>If true, this component will be rendered in the main pass (z prepass, basepass, transparency)</summary>
		public bool bRenderInMainPass
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderInMainPass__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderInMainPass__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bRenderInMono__Offset;
		/// <summary>If true, this component will be rendered in mono only if an HMD is connected and monoscopic far field rendering is activated.</summary>
		public bool bRenderInMono
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderInMono__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderInMono__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bReceivesDecals__Offset;
		/// <summary>Whether the primitive receives decals.</summary>
		public bool bReceivesDecals
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReceivesDecals__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReceivesDecals__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bOwnerNoSee__Offset;
		/// <summary>If this is True, this component won't be visible when the view actor is the component's owner, directly or indirectly.</summary>
		public bool bOwnerNoSee
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOwnerNoSee__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOwnerNoSee__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bOnlyOwnerSee__Offset;
		/// <summary>If this is True, this component will only be visible when the view actor is the component's owner, directly or indirectly.</summary>
		public bool bOnlyOwnerSee
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlyOwnerSee__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOnlyOwnerSee__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bTreatAsBackgroundForOcclusion__Offset;
		/// <summary>Treat this primitive as part of the background for occlusion purposes. This can be used as an optimization to reduce the cost of rendering skyboxes, large ground planes that are part of the vista, etc.</summary>
		public bool bTreatAsBackgroundForOcclusion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTreatAsBackgroundForOcclusion__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTreatAsBackgroundForOcclusion__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bUseAsOccluder__Offset;
		/// <summary>
		/// Whether to render the primitive in the depth only pass.
		/// This should generally be true for all objects, and let the renderer make decisions about whether to render objects in the depth only pass.
		/// @todo - if any rendering features rely on a complete depth only pass, this variable needs to go away.
		/// </summary>
		public bool bUseAsOccluder
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseAsOccluder__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseAsOccluder__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSelectable__Offset;
		/// <summary>If this is True, this component can be selected in the editor.</summary>
		public bool bSelectable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSelectable__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bForceMipStreaming__Offset;
		/// <summary>If true, forces mips for textures used by this component to be resident when this component's level is loaded.</summary>
		public bool bForceMipStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceMipStreaming__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceMipStreaming__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bHasPerInstanceHitProxies__Offset;
		/// <summary>If true a hit-proxy will be generated for each instance of instanced static meshes</summary>
		public bool bHasPerInstanceHitProxies
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasPerInstanceHitProxies__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int CastShadow__Offset;
		/// <summary>
		/// Controls whether the primitive component should cast a shadow or not.
		/// This flag is ignored (no shadows will be generated) if all materials on this component have an Unlit shading model.
		/// </summary>
		public bool CastShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastShadow__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastShadow__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bAffectDynamicIndirectLighting__Offset;
		/// <summary>Controls whether the primitive should inject light into the Light Propagation Volume.  This flag is only used if CastShadow is true. *</summary>
		public bool bAffectDynamicIndirectLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectDynamicIndirectLighting__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectDynamicIndirectLighting__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bAffectDistanceFieldLighting__Offset;
		/// <summary>Controls whether the primitive should affect dynamic distance field lighting methods.  This flag is only used if CastShadow is true. *</summary>
		public bool bAffectDistanceFieldLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectDistanceFieldLighting__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectDistanceFieldLighting__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bCastDynamicShadow__Offset;
		/// <summary>Controls whether the primitive should cast shadows in the case of non precomputed shadowing.  This flag is only used if CastShadow is true. *</summary>
		public bool bCastDynamicShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastDynamicShadow__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastDynamicShadow__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bCastStaticShadow__Offset;
		/// <summary>Whether the object should cast a static shadow from shadow casting lights.  This flag is only used if CastShadow is true.</summary>
		public bool bCastStaticShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastStaticShadow__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastStaticShadow__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bCastVolumetricTranslucentShadow__Offset;
		/// <summary>
		/// Whether the object should cast a volumetric translucent shadow.
		/// Volumetric translucent shadows are useful for primitives with smoothly changing opacity like particles representing a volume,
		/// But have artifacts when used on highly opaque surfaces.
		/// </summary>
		public bool bCastVolumetricTranslucentShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastVolumetricTranslucentShadow__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastVolumetricTranslucentShadow__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bSelfShadowOnly__Offset;
		/// <summary>
		/// When enabled, the component will only cast a shadow on itself and not other components in the world.
		/// This is especially useful for first person weapons, and forces bCastInsetShadow to be enabled.
		/// </summary>
		public bool bSelfShadowOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSelfShadowOnly__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSelfShadowOnly__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bCastFarShadow__Offset;
		/// <summary>When enabled, the component will be rendering into the far shadow cascades (only for directional lights).</summary>
		public bool bCastFarShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastFarShadow__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastFarShadow__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bCastInsetShadow__Offset;
		/// <summary>
		/// Whether this component should create a per-object shadow that gives higher effective shadow resolution.
		/// Useful for cinematic character shadowing. Assumed to be enabled if bSelfShadowOnly is enabled.
		/// </summary>
		public bool bCastInsetShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastInsetShadow__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastInsetShadow__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bCastCinematicShadow__Offset;
		/// <summary>
		/// Whether this component should cast shadows from lights that have bCastShadowsFromCinematicObjectsOnly enabled.
		/// This is useful for characters in a cinematic with special cinematic lights, where the cost of shadowmap rendering of the environment is undesired.
		/// </summary>
		public bool bCastCinematicShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastCinematicShadow__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastCinematicShadow__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bCastHiddenShadow__Offset;
		/// <summary>
		/// If true, the primitive will cast shadows even if bHidden is true.
		/// Controls whether the primitive should cast shadows when hidden.
		/// This flag is only used if CastShadow is true.
		/// </summary>
		public bool bCastHiddenShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastHiddenShadow__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastHiddenShadow__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bCastShadowAsTwoSided__Offset;
		/// <summary>Whether this primitive should cast dynamic shadows as if it were a two sided material.</summary>
		public bool bCastShadowAsTwoSided
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastShadowAsTwoSided__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastShadowAsTwoSided__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bLightAsIfStatic__Offset;
		/// <summary>
		/// Whether to light this primitive as if it were static, including generating lightmaps.
		/// This only has an effect for component types that can bake lighting, like static mesh components.
		/// This is useful for moving meshes that don't change significantly.
		/// </summary>
		public bool bLightAsIfStatic
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLightAsIfStatic__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLightAsIfStatic__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bLightAttachmentsAsGroup__Offset;
		/// <summary>
		/// Whether to light this component and any attachments as a group.  This only has effect on the root component of an attachment tree.
		/// When enabled, attached component shadowing settings like bCastInsetShadow, bCastVolumetricTranslucentShadow, etc, will be ignored.
		/// This is useful for improving performance when multiple movable components are attached together.
		/// </summary>
		public bool bLightAttachmentsAsGroup
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLightAttachmentsAsGroup__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLightAttachmentsAsGroup__Offset, 1,0,2,2);}
			
		}
		
		static readonly int IndirectLightingCacheQuality__Offset;
		/// <summary>Quality of indirect lighting for Movable primitives.  This has a large effect on Indirect Lighting Cache update time.</summary>
		public EIndirectLightingCacheQuality IndirectLightingCacheQuality
		{
			get{ CheckIsValid();return (EIndirectLightingCacheQuality)Marshal.PtrToStructure(_this.Get()+IndirectLightingCacheQuality__Offset, typeof(EIndirectLightingCacheQuality));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IndirectLightingCacheQuality__Offset, false);}
			
		}
		
		static readonly int bReceiveCombinedCSMAndStaticShadowsFromStationaryLights__Offset;
		/// <summary>
		/// Mobile only:
		/// If enabled this component can receive combined static and CSM shadows from a stationary light. (Enabling will increase shading cost.)
		/// If disabled this component will only receive static shadows from stationary lights.
		/// </summary>
		public bool bReceiveCombinedCSMAndStaticShadowsFromStationaryLights
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReceiveCombinedCSMAndStaticShadowsFromStationaryLights__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReceiveCombinedCSMAndStaticShadowsFromStationaryLights__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSingleSampleShadowFromStationaryLights__Offset;
		/// <summary>
		/// Whether the whole component should be shadowed as one from stationary lights, which makes shadow receiving much cheaper.
		/// When enabled shadowing data comes from the volume lighting samples precomputed by Lightmass, which are very sparse.
		/// This is currently only used on stationary directional lights.
		/// </summary>
		public bool bSingleSampleShadowFromStationaryLights
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSingleSampleShadowFromStationaryLights__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSingleSampleShadowFromStationaryLights__Offset, 1,0,2,2);}
			
		}
		
		static readonly int LightingChannels__Offset;
		/// <summary>
		/// Channels that this component should be in.  Lights with matching channels will affect the component.
		/// These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing.
		/// </summary>
		public FLightingChannels LightingChannels
		{
			get{ CheckIsValid();return (FLightingChannels)Marshal.PtrToStructure(_this.Get()+LightingChannels__Offset, typeof(FLightingChannels));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightingChannels__Offset, false);}
			
		}
		
		static readonly int bIgnoreRadialImpulse__Offset;
		/// <summary>Will ignore radial impulses applied to this component.</summary>
		public bool bIgnoreRadialImpulse
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreRadialImpulse__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIgnoreRadialForce__Offset;
		/// <summary>Will ignore radial forces applied to this component.</summary>
		public bool bIgnoreRadialForce
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreRadialForce__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int AlwaysLoadOnClient__Offset;
		/// <summary>If this is True, this component must always be loaded on clients, even if Hidden and CollisionEnabled is NoCollision.</summary>
		public bool AlwaysLoadOnClient
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AlwaysLoadOnClient__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int AlwaysLoadOnServer__Offset;
		/// <summary>If this is True, this component must always be loaded on servers, even if Hidden and CollisionEnabled is NoCollision</summary>
		public bool AlwaysLoadOnServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AlwaysLoadOnServer__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bUseEditorCompositing__Offset;
		/// <summary>Composite the drawing of this component onto the scene after post processing (only applies to editor drawing)</summary>
		public bool bUseEditorCompositing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseEditorCompositing__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bRenderCustomDepth__Offset;
		/// <summary>If true, this component will be rendered in the CustomDepth pass (usually used for outlines)</summary>
		public bool bRenderCustomDepth
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderCustomDepth__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderCustomDepth__Offset, 1,0,32,32);}
			
		}
		
		static readonly int CustomDepthStencilValue__Offset;
		/// <summary>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)</summary>
		public int CustomDepthStencilValue
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CustomDepthStencilValue__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CustomDepthStencilValue__Offset, false);}
			
		}
		
		static readonly int TranslucencySortPriority__Offset;
		/// <summary>
		/// Translucent objects with a lower sort priority draw behind objects with a higher priority.
		/// Translucent objects with the same priority are rendered from back-to-front based on their bounds origin.
		/// Ignored if the object is not translucent.  The default priority is zero.
		/// Warning: This should never be set to a non-default value unless you know what you are doing, as it will prevent the renderer from sorting correctly.
		/// It is especially problematic on dynamic gameplay effects.
		/// </summary>
		public int TranslucencySortPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TranslucencySortPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucencySortPriority__Offset, false);}
			
		}
		
		static readonly int VisibilityId__Offset;
		/// <summary>Used for precomputed visibility</summary>
		public int VisibilityId
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VisibilityId__Offset, typeof(int));}
			
		}
		
		static readonly int LpvBiasMultiplier__Offset;
		/// <summary>
		/// Multiplier used to scale the Light Propagation Volume light injection bias, to reduce light bleeding.
		/// Set to 0 for no bias, 1 for default or higher for increased biasing (e.g. for
		/// thin geometry such as walls)
		/// </summary>
		public float LpvBiasMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LpvBiasMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LpvBiasMultiplier__Offset, false);}
			
		}
		
		static readonly int BodyInstance__Offset;
		/// <summary>Physics scene information for this component, holds a single rigid body with multiple shapes.</summary>
		public FBodyInstance BodyInstance
		{
			get{ CheckIsValid();return (FBodyInstance)Marshal.PtrToStructure(_this.Get()+BodyInstance__Offset, typeof(FBodyInstance));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BodyInstance__Offset, false);}
			
		}
		
		static readonly int bHasCustomNavigableGeometry__Offset;
		/// <summary>If true then DoCustomNavigableGeometryExport will be called to collect navigable geometry of this component.</summary>
		public EHasCustomNavigableGeometry bHasCustomNavigableGeometry
		{
			get{ CheckIsValid();return (EHasCustomNavigableGeometry)Marshal.PtrToStructure(_this.Get()+bHasCustomNavigableGeometry__Offset, typeof(EHasCustomNavigableGeometry));}
			
		}
		
		static readonly int BoundsScale__Offset;
		/// <summary>
		/// Scales the bounds of the object.
		/// This is useful when using World Position Offset to animate the vertices of the object outside of its bounds.
		/// Warning: Increasing the bounds of an object will reduce performance and shadow quality!
		/// Currently only used by StaticMeshComponent and SkeletalMeshComponent.
		/// </summary>
		public float BoundsScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BoundsScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoundsScale__Offset, false);}
			
		}
		
		static readonly int LastSubmitTime__Offset;
		/// <summary>Last time the component was submitted for rendering (called FScene::AddPrimitive).</summary>
		public float LastSubmitTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastSubmitTime__Offset, typeof(float));}
			
		}
		
		static readonly int LastRenderTime__Offset;
		/// <summary>
		/// The value of WorldSettings->TimeSeconds for the frame when this component was last rendered.  This is written
		/// from the render thread, which is up to a frame behind the game thread, so you should allow this time to
		/// be at least a frame behind the game thread's world time before you consider the actor non-visible.
		/// </summary>
		public float LastRenderTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastRenderTime__Offset, typeof(float));}
			
		}
		
		static readonly int LastRenderTimeOnScreen__Offset;
		public float LastRenderTimeOnScreen
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastRenderTimeOnScreen__Offset, typeof(float));}
			
		}
		
		static readonly int CanBeCharacterBase__Offset;
		public ECanBeCharacterBase CanBeCharacterBase
		{
			get{ CheckIsValid();return (ECanBeCharacterBase)Marshal.PtrToStructure(_this.Get()+CanBeCharacterBase__Offset, typeof(ECanBeCharacterBase));}
			
		}
		
		static readonly int CanCharacterStepUpOn__Offset;
		/// <summary>
		/// Determine whether a Character can step up onto this component.
		/// This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it.
		/// @see FWalkableSlopeOverride
		/// </summary>
		public ECanBeCharacterBase CanCharacterStepUpOn
		{
			get{ CheckIsValid();return (ECanBeCharacterBase)Marshal.PtrToStructure(_this.Get()+CanCharacterStepUpOn__Offset, typeof(ECanBeCharacterBase));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CanCharacterStepUpOn__Offset, false);}
			
		}
		
		static readonly int MoveIgnoreActors__Offset;
		/// <summary>
		/// Set of actors to ignore during component sweeps in MoveComponent().
		/// All components owned by these actors will be ignored when this component moves or updates overlaps.
		/// Components on the other Actor may also need to be told to do the same when they move.
		/// Does not affect movement of this component when simulating physics.
		/// @see IgnoreActorWhenMoving()
		/// </summary>
		public TObjectArray<AActor>  MoveIgnoreActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MoveIgnoreActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MoveIgnoreActors__Offset, false);}
			
		}
		
		static readonly int MoveIgnoreComponents__Offset;
		/// <summary>
		/// Set of components to ignore during component sweeps in MoveComponent().
		/// These components will be ignored when this component moves or updates overlaps.
		/// The other components may also need to be told to do the same when they move.
		/// Does not affect movement of this component when simulating physics.
		/// @see IgnoreComponentWhenMoving()
		/// </summary>
		public TObjectArray<UPrimitiveComponent>  MoveIgnoreComponents
		{
					get{ CheckIsValid();return new TObjectArray<UPrimitiveComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MoveIgnoreComponents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MoveIgnoreComponents__Offset, false);}
			
		}
		
		static readonly int OnComponentHit__Offset;
		/// <summary>
		/// Event called when a component hits (or is hit by) something solid. This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation.
		/// For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event.
		/// @note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled for this component.
		/// @note When receiving a hit from another object's movement, the directions of 'Hit.Normal' and 'Hit.ImpactNormal'
		/// will be adjusted to indicate force from the other object against this object.
		/// @note NormalImpulse will be filled in for physics-simulating bodies, but will be zero for swept-component blocking collisions.
		/// </summary>
		public FMulticastScriptDelegate OnComponentHit
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentHit__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentHit__Offset, false);}
			
		}
		
		static readonly int OnComponentBeginOverlap__Offset;
		/// <summary>
		/// Event called when something starts to overlaps this component, for example a player walking into a trigger.
		/// For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events.
		/// @note Both this component and the other one must have bGenerateOverlapEvents set to true to generate overlap events.
		/// @note When receiving an overlap from another object's movement, the directions of 'Hit.Normal' and 'Hit.ImpactNormal'
		/// will be adjusted to indicate force from the other object against this object.
		/// </summary>
		public FMulticastScriptDelegate OnComponentBeginOverlap
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentBeginOverlap__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentBeginOverlap__Offset, false);}
			
		}
		
		static readonly int OnComponentEndOverlap__Offset;
		/// <summary>
		/// Event called when something stops overlapping this component
		/// @note Both this component and the other one must have bGenerateOverlapEvents set to true to generate overlap events.
		/// </summary>
		public FMulticastScriptDelegate OnComponentEndOverlap
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentEndOverlap__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentEndOverlap__Offset, false);}
			
		}
		
		static readonly int OnComponentWake__Offset;
		/// <summary>Event called when the underlying physics objects is woken up</summary>
		public FMulticastScriptDelegate OnComponentWake
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentWake__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentWake__Offset, false);}
			
		}
		
		static readonly int OnComponentSleep__Offset;
		/// <summary>Event called when the underlying physics objects is put to sleep</summary>
		public FMulticastScriptDelegate OnComponentSleep
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentSleep__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentSleep__Offset, false);}
			
		}
		
		static readonly int OnBeginCursorOver__Offset;
		/// <summary>Event called when the mouse cursor is moved over this component and mouse over events are enabled in the player controller</summary>
		public FMulticastScriptDelegate OnBeginCursorOver
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnBeginCursorOver__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnBeginCursorOver__Offset, false);}
			
		}
		
		static readonly int OnEndCursorOver__Offset;
		/// <summary>Event called when the mouse cursor is moved off this component and mouse over events are enabled in the player controller</summary>
		public FMulticastScriptDelegate OnEndCursorOver
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnEndCursorOver__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnEndCursorOver__Offset, false);}
			
		}
		
		static readonly int OnClicked__Offset;
		/// <summary>Event called when the left mouse button is clicked while the mouse is over this component and click events are enabled in the player controller</summary>
		public FMulticastScriptDelegate OnClicked
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnClicked__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnClicked__Offset, false);}
			
		}
		
		static readonly int OnReleased__Offset;
		/// <summary>Event called when the left mouse button is released while the mouse is over this component click events are enabled in the player controller</summary>
		public FMulticastScriptDelegate OnReleased
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnReleased__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnReleased__Offset, false);}
			
		}
		
		static readonly int OnInputTouchBegin__Offset;
		/// <summary>Event called when a touch input is received over this component when touch events are enabled in the player controller</summary>
		public FMulticastScriptDelegate OnInputTouchBegin
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchBegin__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchBegin__Offset, false);}
			
		}
		
		static readonly int OnInputTouchEnd__Offset;
		/// <summary>Event called when a touch input is released over this component when touch events are enabled in the player controller</summary>
		public FMulticastScriptDelegate OnInputTouchEnd
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchEnd__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchEnd__Offset, false);}
			
		}
		
		static readonly int OnInputTouchEnter__Offset;
		/// <summary>Event called when a finger is moved over this component when touch over events are enabled in the player controller</summary>
		public FMulticastScriptDelegate OnInputTouchEnter
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchEnter__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchEnter__Offset, false);}
			
		}
		
		static readonly int OnInputTouchLeave__Offset;
		/// <summary>Event called when a finger is moved off this component when touch over events are enabled in the player controller</summary>
		public FMulticastScriptDelegate OnInputTouchLeave
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInputTouchLeave__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInputTouchLeave__Offset, false);}
			
		}
		
		static readonly int LODParentPrimitive__Offset;
		/// <summary>LOD parent primitive to draw instead of this one (multiple UPrim's will point to the same LODParent )</summary>
		public UPrimitiveComponent LODParentPrimitive
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LODParentPrimitive__Offset); if (v == IntPtr.Zero)return null; UPrimitiveComponent retValue = new UPrimitiveComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PostPhysicsComponentTick__Offset;
		/// <summary>Tick function for physics ticking *</summary>
		public FPrimitiveComponentPostPhysicsTickFunction PostPhysicsComponentTick
		{
			get{ CheckIsValid();return (FPrimitiveComponentPostPhysicsTickFunction)Marshal.PtrToStructure(_this.Get()+PostPhysicsComponentTick__Offset, typeof(FPrimitiveComponentPostPhysicsTickFunction));}
			
		}
		
		static UPrimitiveComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("PrimitiveComponent");
			MinDrawDistance__Offset=GetPropertyOffset(NativeClassPtr,"MinDrawDistance");
			LDMaxDrawDistance__Offset=GetPropertyOffset(NativeClassPtr,"LDMaxDrawDistance");
			CachedMaxDrawDistance__Offset=GetPropertyOffset(NativeClassPtr,"CachedMaxDrawDistance");
			DepthPriorityGroup__Offset=GetPropertyOffset(NativeClassPtr,"DepthPriorityGroup");
			ViewOwnerDepthPriorityGroup__Offset=GetPropertyOffset(NativeClassPtr,"ViewOwnerDepthPriorityGroup");
			bAlwaysCreatePhysicsState__Offset=GetPropertyOffset(NativeClassPtr,"bAlwaysCreatePhysicsState");
			bGenerateOverlapEvents__Offset=GetPropertyOffset(NativeClassPtr,"bGenerateOverlapEvents");
			bMultiBodyOverlap__Offset=GetPropertyOffset(NativeClassPtr,"bMultiBodyOverlap");
			bCheckAsyncSceneOnMove__Offset=GetPropertyOffset(NativeClassPtr,"bCheckAsyncSceneOnMove");
			bTraceComplexOnMove__Offset=GetPropertyOffset(NativeClassPtr,"bTraceComplexOnMove");
			bReturnMaterialOnMove__Offset=GetPropertyOffset(NativeClassPtr,"bReturnMaterialOnMove");
			bUseViewOwnerDepthPriorityGroup__Offset=GetPropertyOffset(NativeClassPtr,"bUseViewOwnerDepthPriorityGroup");
			bAllowCullDistanceVolume__Offset=GetPropertyOffset(NativeClassPtr,"bAllowCullDistanceVolume");
			bHasMotionBlurVelocityMeshes__Offset=GetPropertyOffset(NativeClassPtr,"bHasMotionBlurVelocityMeshes");
			bVisibleInReflectionCaptures__Offset=GetPropertyOffset(NativeClassPtr,"bVisibleInReflectionCaptures");
			bRenderInMainPass__Offset=GetPropertyOffset(NativeClassPtr,"bRenderInMainPass");
			bRenderInMono__Offset=GetPropertyOffset(NativeClassPtr,"bRenderInMono");
			bReceivesDecals__Offset=GetPropertyOffset(NativeClassPtr,"bReceivesDecals");
			bOwnerNoSee__Offset=GetPropertyOffset(NativeClassPtr,"bOwnerNoSee");
			bOnlyOwnerSee__Offset=GetPropertyOffset(NativeClassPtr,"bOnlyOwnerSee");
			bTreatAsBackgroundForOcclusion__Offset=GetPropertyOffset(NativeClassPtr,"bTreatAsBackgroundForOcclusion");
			bUseAsOccluder__Offset=GetPropertyOffset(NativeClassPtr,"bUseAsOccluder");
			bSelectable__Offset=GetPropertyOffset(NativeClassPtr,"bSelectable");
			bForceMipStreaming__Offset=GetPropertyOffset(NativeClassPtr,"bForceMipStreaming");
			bHasPerInstanceHitProxies__Offset=GetPropertyOffset(NativeClassPtr,"bHasPerInstanceHitProxies");
			CastShadow__Offset=GetPropertyOffset(NativeClassPtr,"CastShadow");
			bAffectDynamicIndirectLighting__Offset=GetPropertyOffset(NativeClassPtr,"bAffectDynamicIndirectLighting");
			bAffectDistanceFieldLighting__Offset=GetPropertyOffset(NativeClassPtr,"bAffectDistanceFieldLighting");
			bCastDynamicShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastDynamicShadow");
			bCastStaticShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastStaticShadow");
			bCastVolumetricTranslucentShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastVolumetricTranslucentShadow");
			bSelfShadowOnly__Offset=GetPropertyOffset(NativeClassPtr,"bSelfShadowOnly");
			bCastFarShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastFarShadow");
			bCastInsetShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastInsetShadow");
			bCastCinematicShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastCinematicShadow");
			bCastHiddenShadow__Offset=GetPropertyOffset(NativeClassPtr,"bCastHiddenShadow");
			bCastShadowAsTwoSided__Offset=GetPropertyOffset(NativeClassPtr,"bCastShadowAsTwoSided");
			bLightAsIfStatic__Offset=GetPropertyOffset(NativeClassPtr,"bLightAsIfStatic");
			bLightAttachmentsAsGroup__Offset=GetPropertyOffset(NativeClassPtr,"bLightAttachmentsAsGroup");
			IndirectLightingCacheQuality__Offset=GetPropertyOffset(NativeClassPtr,"IndirectLightingCacheQuality");
			bReceiveCombinedCSMAndStaticShadowsFromStationaryLights__Offset=GetPropertyOffset(NativeClassPtr,"bReceiveCombinedCSMAndStaticShadowsFromStationaryLights");
			bSingleSampleShadowFromStationaryLights__Offset=GetPropertyOffset(NativeClassPtr,"bSingleSampleShadowFromStationaryLights");
			LightingChannels__Offset=GetPropertyOffset(NativeClassPtr,"LightingChannels");
			bIgnoreRadialImpulse__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreRadialImpulse");
			bIgnoreRadialForce__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreRadialForce");
			AlwaysLoadOnClient__Offset=GetPropertyOffset(NativeClassPtr,"AlwaysLoadOnClient");
			AlwaysLoadOnServer__Offset=GetPropertyOffset(NativeClassPtr,"AlwaysLoadOnServer");
			bUseEditorCompositing__Offset=GetPropertyOffset(NativeClassPtr,"bUseEditorCompositing");
			bRenderCustomDepth__Offset=GetPropertyOffset(NativeClassPtr,"bRenderCustomDepth");
			CustomDepthStencilValue__Offset=GetPropertyOffset(NativeClassPtr,"CustomDepthStencilValue");
			TranslucencySortPriority__Offset=GetPropertyOffset(NativeClassPtr,"TranslucencySortPriority");
			VisibilityId__Offset=GetPropertyOffset(NativeClassPtr,"VisibilityId");
			LpvBiasMultiplier__Offset=GetPropertyOffset(NativeClassPtr,"LpvBiasMultiplier");
			BodyInstance__Offset=GetPropertyOffset(NativeClassPtr,"BodyInstance");
			bHasCustomNavigableGeometry__Offset=GetPropertyOffset(NativeClassPtr,"bHasCustomNavigableGeometry");
			BoundsScale__Offset=GetPropertyOffset(NativeClassPtr,"BoundsScale");
			LastSubmitTime__Offset=GetPropertyOffset(NativeClassPtr,"LastSubmitTime");
			LastRenderTime__Offset=GetPropertyOffset(NativeClassPtr,"LastRenderTime");
			LastRenderTimeOnScreen__Offset=GetPropertyOffset(NativeClassPtr,"LastRenderTimeOnScreen");
			CanBeCharacterBase__Offset=GetPropertyOffset(NativeClassPtr,"CanBeCharacterBase");
			CanCharacterStepUpOn__Offset=GetPropertyOffset(NativeClassPtr,"CanCharacterStepUpOn");
			MoveIgnoreActors__Offset=GetPropertyOffset(NativeClassPtr,"MoveIgnoreActors");
			MoveIgnoreComponents__Offset=GetPropertyOffset(NativeClassPtr,"MoveIgnoreComponents");
			OnComponentHit__Offset=GetPropertyOffset(NativeClassPtr,"OnComponentHit");
			OnComponentBeginOverlap__Offset=GetPropertyOffset(NativeClassPtr,"OnComponentBeginOverlap");
			OnComponentEndOverlap__Offset=GetPropertyOffset(NativeClassPtr,"OnComponentEndOverlap");
			OnComponentWake__Offset=GetPropertyOffset(NativeClassPtr,"OnComponentWake");
			OnComponentSleep__Offset=GetPropertyOffset(NativeClassPtr,"OnComponentSleep");
			OnBeginCursorOver__Offset=GetPropertyOffset(NativeClassPtr,"OnBeginCursorOver");
			OnEndCursorOver__Offset=GetPropertyOffset(NativeClassPtr,"OnEndCursorOver");
			OnClicked__Offset=GetPropertyOffset(NativeClassPtr,"OnClicked");
			OnReleased__Offset=GetPropertyOffset(NativeClassPtr,"OnReleased");
			OnInputTouchBegin__Offset=GetPropertyOffset(NativeClassPtr,"OnInputTouchBegin");
			OnInputTouchEnd__Offset=GetPropertyOffset(NativeClassPtr,"OnInputTouchEnd");
			OnInputTouchEnter__Offset=GetPropertyOffset(NativeClassPtr,"OnInputTouchEnter");
			OnInputTouchLeave__Offset=GetPropertyOffset(NativeClassPtr,"OnInputTouchLeave");
			LODParentPrimitive__Offset=GetPropertyOffset(NativeClassPtr,"LODParentPrimitive");
			PostPhysicsComponentTick__Offset=GetPropertyOffset(NativeClassPtr,"PostPhysicsComponentTick");
			
		}
		
	}
	
}
#endif
#endif
