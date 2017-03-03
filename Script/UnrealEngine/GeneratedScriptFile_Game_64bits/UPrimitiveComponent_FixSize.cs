#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UPrimitiveComponent
	{
		static readonly int MinDrawDistance__Offset;
		public float MinDrawDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinDrawDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinDrawDistance__Offset, false);}
			
		}
		
		static readonly int LDMaxDrawDistance__Offset;
		public float LDMaxDrawDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LDMaxDrawDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LDMaxDrawDistance__Offset, false);}
			
		}
		
		static readonly int CachedMaxDrawDistance__Offset;
		public float CachedMaxDrawDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+CachedMaxDrawDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CachedMaxDrawDistance__Offset, false);}
			
		}
		
		static readonly int DepthPriorityGroup__Offset;
		public ESceneDepthPriorityGroup DepthPriorityGroup
		{
			get{ CheckIsValid();return (ESceneDepthPriorityGroup)Marshal.PtrToStructure(_this.Get()+DepthPriorityGroup__Offset, typeof(ESceneDepthPriorityGroup));}
			
		}
		
		static readonly int ViewOwnerDepthPriorityGroup__Offset;
		public ESceneDepthPriorityGroup ViewOwnerDepthPriorityGroup
		{
			get{ CheckIsValid();return (ESceneDepthPriorityGroup)Marshal.PtrToStructure(_this.Get()+ViewOwnerDepthPriorityGroup__Offset, typeof(ESceneDepthPriorityGroup));}
			
		}
		
		static readonly int bAlwaysCreatePhysicsState__Offset;
		public bool bAlwaysCreatePhysicsState
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysCreatePhysicsState__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysCreatePhysicsState__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bGenerateOverlapEvents__Offset;
		public bool bGenerateOverlapEvents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bGenerateOverlapEvents__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bGenerateOverlapEvents__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bMultiBodyOverlap__Offset;
		public bool bMultiBodyOverlap
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bMultiBodyOverlap__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bMultiBodyOverlap__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bCheckAsyncSceneOnMove__Offset;
		public bool bCheckAsyncSceneOnMove
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCheckAsyncSceneOnMove__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCheckAsyncSceneOnMove__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bTraceComplexOnMove__Offset;
		public bool bTraceComplexOnMove
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTraceComplexOnMove__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTraceComplexOnMove__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bReturnMaterialOnMove__Offset;
		public bool bReturnMaterialOnMove
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReturnMaterialOnMove__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReturnMaterialOnMove__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bUseViewOwnerDepthPriorityGroup__Offset;
		public bool bUseViewOwnerDepthPriorityGroup
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseViewOwnerDepthPriorityGroup__Offset, 1, 0, 64, 64);}
			
		}
		
		static readonly int bAllowCullDistanceVolume__Offset;
		public bool bAllowCullDistanceVolume
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowCullDistanceVolume__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAllowCullDistanceVolume__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bHasMotionBlurVelocityMeshes__Offset;
		public bool bHasMotionBlurVelocityMeshes
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasMotionBlurVelocityMeshes__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bVisibleInReflectionCaptures__Offset;
		public bool bVisibleInReflectionCaptures
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bVisibleInReflectionCaptures__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bVisibleInReflectionCaptures__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bRenderInMainPass__Offset;
		public bool bRenderInMainPass
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderInMainPass__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderInMainPass__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bRenderInMono__Offset;
		public bool bRenderInMono
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderInMono__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderInMono__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bReceivesDecals__Offset;
		public bool bReceivesDecals
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReceivesDecals__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReceivesDecals__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bOwnerNoSee__Offset;
		public bool bOwnerNoSee
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOwnerNoSee__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOwnerNoSee__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bOnlyOwnerSee__Offset;
		public bool bOnlyOwnerSee
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOnlyOwnerSee__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOnlyOwnerSee__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bTreatAsBackgroundForOcclusion__Offset;
		public bool bTreatAsBackgroundForOcclusion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTreatAsBackgroundForOcclusion__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTreatAsBackgroundForOcclusion__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bUseAsOccluder__Offset;
		public bool bUseAsOccluder
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseAsOccluder__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseAsOccluder__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSelectable__Offset;
		public bool bSelectable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSelectable__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bForceMipStreaming__Offset;
		public bool bForceMipStreaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceMipStreaming__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceMipStreaming__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bHasPerInstanceHitProxies__Offset;
		public bool bHasPerInstanceHitProxies
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasPerInstanceHitProxies__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int CastShadow__Offset;
		public bool CastShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), CastShadow__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), CastShadow__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bAffectDynamicIndirectLighting__Offset;
		public bool bAffectDynamicIndirectLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectDynamicIndirectLighting__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectDynamicIndirectLighting__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bAffectDistanceFieldLighting__Offset;
		public bool bAffectDistanceFieldLighting
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAffectDistanceFieldLighting__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAffectDistanceFieldLighting__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bCastDynamicShadow__Offset;
		public bool bCastDynamicShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastDynamicShadow__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastDynamicShadow__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bCastStaticShadow__Offset;
		public bool bCastStaticShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastStaticShadow__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastStaticShadow__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bCastVolumetricTranslucentShadow__Offset;
		public bool bCastVolumetricTranslucentShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastVolumetricTranslucentShadow__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastVolumetricTranslucentShadow__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bSelfShadowOnly__Offset;
		public bool bSelfShadowOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSelfShadowOnly__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSelfShadowOnly__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bCastFarShadow__Offset;
		public bool bCastFarShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastFarShadow__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastFarShadow__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bCastInsetShadow__Offset;
		public bool bCastInsetShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastInsetShadow__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastInsetShadow__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bCastCinematicShadow__Offset;
		public bool bCastCinematicShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastCinematicShadow__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastCinematicShadow__Offset, 1,0,32,32);}
			
		}
		
		static readonly int bCastHiddenShadow__Offset;
		public bool bCastHiddenShadow
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastHiddenShadow__Offset, 1, 0, 64, 64);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastHiddenShadow__Offset, 1,0,64,64);}
			
		}
		
		static readonly int bCastShadowAsTwoSided__Offset;
		public bool bCastShadowAsTwoSided
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCastShadowAsTwoSided__Offset, 1, 0, 128, 128);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCastShadowAsTwoSided__Offset, 1,0,128,128);}
			
		}
		
		static readonly int bLightAsIfStatic__Offset;
		public bool bLightAsIfStatic
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLightAsIfStatic__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLightAsIfStatic__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bLightAttachmentsAsGroup__Offset;
		public bool bLightAttachmentsAsGroup
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLightAttachmentsAsGroup__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLightAttachmentsAsGroup__Offset, 1,0,2,2);}
			
		}
		
		static readonly int IndirectLightingCacheQuality__Offset;
		public EIndirectLightingCacheQuality IndirectLightingCacheQuality
		{
			get{ CheckIsValid();return (EIndirectLightingCacheQuality)Marshal.PtrToStructure(_this.Get()+IndirectLightingCacheQuality__Offset, typeof(EIndirectLightingCacheQuality));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IndirectLightingCacheQuality__Offset, false);}
			
		}
		
		static readonly int bReceiveCombinedCSMAndStaticShadowsFromStationaryLights__Offset;
		public bool bReceiveCombinedCSMAndStaticShadowsFromStationaryLights
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReceiveCombinedCSMAndStaticShadowsFromStationaryLights__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReceiveCombinedCSMAndStaticShadowsFromStationaryLights__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bSingleSampleShadowFromStationaryLights__Offset;
		public bool bSingleSampleShadowFromStationaryLights
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSingleSampleShadowFromStationaryLights__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSingleSampleShadowFromStationaryLights__Offset, 1,0,2,2);}
			
		}
		
		static readonly int LightingChannels__Offset;
		public FLightingChannels LightingChannels
		{
			get{ CheckIsValid();return (FLightingChannels)Marshal.PtrToStructure(_this.Get()+LightingChannels__Offset, typeof(FLightingChannels));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightingChannels__Offset, false);}
			
		}
		
		static readonly int bIgnoreRadialImpulse__Offset;
		public bool bIgnoreRadialImpulse
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreRadialImpulse__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bIgnoreRadialForce__Offset;
		public bool bIgnoreRadialForce
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreRadialForce__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int AlwaysLoadOnClient__Offset;
		public bool AlwaysLoadOnClient
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AlwaysLoadOnClient__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int AlwaysLoadOnServer__Offset;
		public bool AlwaysLoadOnServer
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), AlwaysLoadOnServer__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int bUseEditorCompositing__Offset;
		public bool bUseEditorCompositing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseEditorCompositing__Offset, 1, 0, 16, 16);}
			
		}
		
		static readonly int bRenderCustomDepth__Offset;
		public bool bRenderCustomDepth
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderCustomDepth__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderCustomDepth__Offset, 1,0,32,32);}
			
		}
		
		static readonly int CustomDepthStencilValue__Offset;
		public int CustomDepthStencilValue
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+CustomDepthStencilValue__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CustomDepthStencilValue__Offset, false);}
			
		}
		
		static readonly int TranslucencySortPriority__Offset;
		public int TranslucencySortPriority
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TranslucencySortPriority__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TranslucencySortPriority__Offset, false);}
			
		}
		
		static readonly int VisibilityId__Offset;
		public int VisibilityId
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+VisibilityId__Offset, typeof(int));}
			
		}
		
		static readonly int LpvBiasMultiplier__Offset;
		public float LpvBiasMultiplier
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LpvBiasMultiplier__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LpvBiasMultiplier__Offset, false);}
			
		}
		
		static readonly int BodyInstance__Offset;
		public FBodyInstance BodyInstance
		{
			get{ CheckIsValid();return (FBodyInstance)Marshal.PtrToStructure(_this.Get()+BodyInstance__Offset, typeof(FBodyInstance));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BodyInstance__Offset, false);}
			
		}
		
		static readonly int bHasCustomNavigableGeometry__Offset;
		public EHasCustomNavigableGeometry bHasCustomNavigableGeometry
		{
			get{ CheckIsValid();return (EHasCustomNavigableGeometry)Marshal.PtrToStructure(_this.Get()+bHasCustomNavigableGeometry__Offset, typeof(EHasCustomNavigableGeometry));}
			
		}
		
		static readonly int BoundsScale__Offset;
		public float BoundsScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+BoundsScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BoundsScale__Offset, false);}
			
		}
		
		static readonly int LastSubmitTime__Offset;
		public float LastSubmitTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LastSubmitTime__Offset, typeof(float));}
			
		}
		
		static readonly int LastRenderTime__Offset;
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
		public ECanBeCharacterBase CanCharacterStepUpOn
		{
			get{ CheckIsValid();return (ECanBeCharacterBase)Marshal.PtrToStructure(_this.Get()+CanCharacterStepUpOn__Offset, typeof(ECanBeCharacterBase));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CanCharacterStepUpOn__Offset, false);}
			
		}
		
		static readonly int MoveIgnoreActors__Offset;
		public TObjectArray<AActor>  MoveIgnoreActors
		{
					get{ CheckIsValid();return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MoveIgnoreActors__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MoveIgnoreActors__Offset, false);}
			
		}
		
		static readonly int MoveIgnoreComponents__Offset;
		public TObjectArray<UPrimitiveComponent>  MoveIgnoreComponents
		{
					get{ CheckIsValid();return new TObjectArray<UPrimitiveComponent>((FScriptArray)Marshal.PtrToStructure(_this.Get()+MoveIgnoreComponents__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+MoveIgnoreComponents__Offset, false);}
			
		}
		
		static readonly int OnComponentHit__Offset;
		public FMulticastScriptDelegate OnComponentHit
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentHit__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentHit__Offset, false);}
			
		}
		
		static readonly int OnComponentBeginOverlap__Offset;
		public FMulticastScriptDelegate OnComponentBeginOverlap
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentBeginOverlap__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentBeginOverlap__Offset, false);}
			
		}
		
		static readonly int OnComponentEndOverlap__Offset;
		public FMulticastScriptDelegate OnComponentEndOverlap
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentEndOverlap__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentEndOverlap__Offset, false);}
			
		}
		
		static readonly int OnComponentWake__Offset;
		public FMulticastScriptDelegate OnComponentWake
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentWake__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentWake__Offset, false);}
			
		}
		
		static readonly int OnComponentSleep__Offset;
		public FMulticastScriptDelegate OnComponentSleep
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnComponentSleep__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnComponentSleep__Offset, false);}
			
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
		
		static readonly int LODParentPrimitive__Offset;
		public UPrimitiveComponent LODParentPrimitive
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + LODParentPrimitive__Offset); if (v == IntPtr.Zero)return null; UPrimitiveComponent retValue = new UPrimitiveComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int PostPhysicsComponentTick__Offset;
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
