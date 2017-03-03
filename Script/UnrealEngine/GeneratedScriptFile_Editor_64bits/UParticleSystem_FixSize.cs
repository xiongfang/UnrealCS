#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// A ParticleSystem is a complete particle effect that contains any number of ParticleEmitters. By allowing multiple emitters
	/// in a system, the designer can create elaborate particle effects that are held in a single system. Once created using
	/// Cascade, a ParticleSystem can then be inserted into a level or created in script.
	/// </summary>
	public partial class UParticleSystem
	{
		static readonly int SystemUpdateMode__Offset;
		public EParticleSystemUpdateMode SystemUpdateMode
		{
			get{ CheckIsValid();return (EParticleSystemUpdateMode)Marshal.PtrToStructure(_this.Get()+SystemUpdateMode__Offset, typeof(EParticleSystemUpdateMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SystemUpdateMode__Offset, false);}
			
		}
		
		static readonly int UpdateTime_FPS__Offset;
		/// <summary>UpdateTime_FPS - the frame per second to update at in FixedTime mode</summary>
		public float UpdateTime_FPS
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UpdateTime_FPS__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UpdateTime_FPS__Offset, false);}
			
		}
		
		static readonly int UpdateTime_Delta__Offset;
		/// <summary>UpdateTime_Delta       - internal</summary>
		public float UpdateTime_Delta
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UpdateTime_Delta__Offset, typeof(float));}
			
		}
		
		static readonly int WarmupTime__Offset;
		/// <summary>WarmupTime     - the time to warm-up the particle system when first rendered</summary>
		public float WarmupTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WarmupTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WarmupTime__Offset, false);}
			
		}
		
		static readonly int WarmupTickRate__Offset;
		/// <summary>
		/// WarmupTickRate - the time step for each tick during warm up.
		///        Increasing this improves performance. Decreasing, improves accuracy.
		///        Set to 0 to use the default tick time.
		/// </summary>
		public float WarmupTickRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WarmupTickRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WarmupTickRate__Offset, false);}
			
		}
		
		static readonly int Emitters__Offset;
		/// <summary>Emitters       - internal - the array of emitters in the system</summary>
		public TObjectArray<UParticleEmitter>  Emitters
		{
					get{ CheckIsValid();return new TObjectArray<UParticleEmitter>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Emitters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Emitters__Offset, false);}
			
		}
		
		static readonly int PreviewComponent__Offset;
		/// <summary>The component used to preview the particle system in Cascade</summary>
		public UParticleSystemComponent PreviewComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewComponent__Offset); if (v == IntPtr.Zero)return null; UParticleSystemComponent retValue = new UParticleSystemComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ThumbnailAngle__Offset;
		/// <summary>The angle to use when rendering the thumbnail image</summary>
		public FRotator ThumbnailAngle
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+ThumbnailAngle__Offset, typeof(FRotator));}
			
		}
		
		static readonly int ThumbnailDistance__Offset;
		/// <summary>The distance to place the system when rendering the thumbnail image</summary>
		public float ThumbnailDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ThumbnailDistance__Offset, typeof(float));}
			
		}
		
		static readonly int ThumbnailWarmup__Offset;
		/// <summary>The time to warm-up the system for the thumbnail image</summary>
		public float ThumbnailWarmup
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+ThumbnailWarmup__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ThumbnailWarmup__Offset, false);}
			
		}
		
		static readonly int CurveEdSetup__Offset;
		/// <summary>Used for curve editor to remember curve-editing setup.</summary>
		public UInterpCurveEdSetup CurveEdSetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurveEdSetup__Offset); if (v == IntPtr.Zero)return null; UInterpCurveEdSetup retValue = new UInterpCurveEdSetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bOrientZAxisTowardCamera__Offset;
		/// <summary>If true, the system's Z axis will be oriented toward the camera</summary>
		public bool bOrientZAxisTowardCamera
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOrientZAxisTowardCamera__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOrientZAxisTowardCamera__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LODDistanceCheckTime__Offset;
		/// <summary>How often (in seconds) the system should perform the LOD distance check.</summary>
		public float LODDistanceCheckTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LODDistanceCheckTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODDistanceCheckTime__Offset, false);}
			
		}
		
		static readonly int LODMethod__Offset;
		/// <summary>
		/// The method of LOD level determination to utilize for this particle system
		///   PARTICLESYSTEMLODMETHOD_Automatic - Automatically set the LOD level, checking every LODDistanceCheckTime seconds.
		/// PARTICLESYSTEMLODMETHOD_DirectSet - LOD level is directly set by the game code.
		/// PARTICLESYSTEMLODMETHOD_ActivateAutomatic - LOD level is determined at Activation time, then left alone unless directly set by game code.
		/// </summary>
		public ParticleSystemLODMethod LODMethod
		{
			get{ CheckIsValid();return (ParticleSystemLODMethod)Marshal.PtrToStructure(_this.Get()+LODMethod__Offset, typeof(ParticleSystemLODMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODMethod__Offset, false);}
			
		}
		
		static readonly int LODDistances__Offset;
		/// <summary>
		/// The array of distances for each LOD level in the system.
		/// Used when LODMethod is set to PARTICLESYSTEMLODMETHOD_Automatic.
		/// Example: System with 3 LOD levels
		///         LODDistances(0) = 0.0
		///         LODDistances(1) = 2500.0
		///         LODDistances(2) = 5000.0
		///         In this case, when the system is [   0.0 ..   2499.9] from the camera, LOD level 0 will be used.
		///                                                                          [2500.0 ..   4999.9] from the camera, LOD level 1 will be used.
		///                                                                          [5000.0 .. INFINITY] from the camera, LOD level 2 will be used.
		/// </summary>
		public TStructArray<float> LODDistances
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODDistances__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODDistances__Offset, false);}
			
		}
		
		static readonly int EditorLODSetting__Offset;
		/// <summary>LOD setting for intepolation (set by Cascade) Range [0..100]</summary>
		public int EditorLODSetting
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EditorLODSetting__Offset, typeof(int));}
			
		}
		
		static readonly int bRegenerateLODDuplicate__Offset;
		/// <summary>
		/// Internal value that tracks the regenerate LOD levels preference.
		/// If true, when autoregenerating LOD levels in code, the low level will
		/// be a duplicate of the high.
		/// </summary>
		public bool bRegenerateLODDuplicate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRegenerateLODDuplicate__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int LODSettings__Offset;
		public TStructArray<FParticleSystemLOD> LODSettings
		{
			get{ CheckIsValid();return new TStructArray<FParticleSystemLOD>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODSettings__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODSettings__Offset, false);}
			
		}
		
		static readonly int bUseFixedRelativeBoundingBox__Offset;
		/// <summary>Whether to use the fixed relative bounding box or calculate it every frame.</summary>
		public bool bUseFixedRelativeBoundingBox
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFixedRelativeBoundingBox__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFixedRelativeBoundingBox__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FixedRelativeBoundingBox__Offset;
		/// <summary>Fixed relative bounding box for particle system.</summary>
		public FBox FixedRelativeBoundingBox
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+FixedRelativeBoundingBox__Offset, typeof(FBox));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FixedRelativeBoundingBox__Offset, false);}
			
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
		
		static readonly int FloorMesh__Offset;
		/// <summary>Cascade 'floor' mesh information.</summary>
		public FString FloorMesh
		{
			get{ CheckIsValid();return (FString)Marshal.PtrToStructure(_this.Get()+FloorMesh__Offset, typeof(FString));}
			
		}
		
		static readonly int FloorPosition__Offset;
		public FVector FloorPosition
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+FloorPosition__Offset, typeof(FVector));}
			
		}
		
		static readonly int FloorRotation__Offset;
		public FRotator FloorRotation
		{
			get{ CheckIsValid();return (FRotator)Marshal.PtrToStructure(_this.Get()+FloorRotation__Offset, typeof(FRotator));}
			
		}
		
		static readonly int FloorScale__Offset;
		public float FloorScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FloorScale__Offset, typeof(float));}
			
		}
		
		static readonly int FloorScale3D__Offset;
		public FVector FloorScale3D
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+FloorScale3D__Offset, typeof(FVector));}
			
		}
		
		static readonly int BackgroundColor__Offset;
		/// <summary>The background color to display in Cascade</summary>
		public FColor BackgroundColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+BackgroundColor__Offset, typeof(FColor));}
			
		}
		
		static readonly int bShouldResetPeakCounts__Offset;
		/// <summary>EDITOR ONLY: Indicates that Cascade would like to have the PeakActiveParticles count reset</summary>
		public bool bShouldResetPeakCounts
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldResetPeakCounts__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHasPhysics__Offset;
		/// <summary>Set during load time to indicate that physics is used...</summary>
		public bool bHasPhysics
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasPhysics__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bUseRealtimeThumbnail__Offset;
		/// <summary>Inidicates the old 'real-time' thumbnail rendering should be used</summary>
		public bool bUseRealtimeThumbnail
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRealtimeThumbnail__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRealtimeThumbnail__Offset, 1,0,4,4);}
			
		}
		
		static readonly int ThumbnailImageOutOfDate__Offset;
		/// <summary>Internal: Indicates the PSys thumbnail image is out of date</summary>
		public bool ThumbnailImageOutOfDate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ThumbnailImageOutOfDate__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int ThumbnailImage__Offset;
		/// <summary>Internal: The PSys thumbnail image</summary>
		public UTexture2D ThumbnailImage
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + ThumbnailImage__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Delay__Offset;
		/// <summary>How long this Particle system should delay when ActivateSystem is called on it.</summary>
		public float Delay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Delay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Delay__Offset, false);}
			
		}
		
		static readonly int DelayLow__Offset;
		/// <summary>The low end of the emitter delay if using a range.</summary>
		public float DelayLow
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DelayLow__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DelayLow__Offset, false);}
			
		}
		
		static readonly int bUseDelayRange__Offset;
		/// <summary>
		/// If true, select the emitter delay from the range
		///         [DelayLow..Delay]
		/// </summary>
		public bool bUseDelayRange
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDelayRange__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseDelayRange__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bAutoDeactivate__Offset;
		/// <summary>Auto-deactivate system if all emitters are determined to not spawn particles again, regardless of lifetime.</summary>
		public bool bAutoDeactivate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoDeactivate__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoDeactivate__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MinTimeBetweenTicks__Offset;
		/// <summary>Minimum duration between ticks; 33=tick at max. 30FPS, 16=60FPS, 8=120FPS</summary>
		public uint MinTimeBetweenTicks
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+MinTimeBetweenTicks__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinTimeBetweenTicks__Offset, false);}
			
		}
		
		static readonly int InsignificanceDelay__Offset;
		/// <summary>Time delay between all emitters becoming insignificant and the systems insignificant reaction.</summary>
		public float InsignificanceDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InsignificanceDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InsignificanceDelay__Offset, false);}
			
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
		
		static readonly int OcclusionBoundsMethod__Offset;
		/// <summary>
		/// Which occlusion bounds method to use for this particle system.
		/// EPSOBM_None - Don't determine occlusion for this system.
		/// EPSOBM_ParticleBounds - Use the bounds of the component when determining occlusion.
		/// </summary>
		public EParticleSystemOcclusionBoundsMethod OcclusionBoundsMethod
		{
			get{ CheckIsValid();return (EParticleSystemOcclusionBoundsMethod)Marshal.PtrToStructure(_this.Get()+OcclusionBoundsMethod__Offset, typeof(EParticleSystemOcclusionBoundsMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OcclusionBoundsMethod__Offset, false);}
			
		}
		
		static readonly int CustomOcclusionBounds__Offset;
		/// <summary>The occlusion bounds to use if OcclusionBoundsMethod is set to EPSOBM_CustomBounds</summary>
		public FBox CustomOcclusionBounds
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+CustomOcclusionBounds__Offset, typeof(FBox));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+CustomOcclusionBounds__Offset, false);}
			
		}
		
		static readonly int SoloTracking__Offset;
		public TStructArray<FLODSoloTrack> SoloTracking
		{
			get{ CheckIsValid();return new TStructArray<FLODSoloTrack>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SoloTracking__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SoloTracking__Offset, false);}
			
		}
		
		static readonly int NamedMaterialSlots__Offset;
		/// <summary>
		/// Array of named material slots for use by emitters of this system.
		/// Emitters can use these instead of their own materials by providing the name to the NamedMaterialOverrides property of their required module.
		/// These materials can be overridden using CreateNamedDynamicMaterialInstance() on a ParticleSystemComponent.
		/// </summary>
		public TStructArray<FNamedEmitterMaterial> NamedMaterialSlots
		{
			get{ CheckIsValid();return new TStructArray<FNamedEmitterMaterial>((FScriptArray)Marshal.PtrToStructure(_this.Get()+NamedMaterialSlots__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+NamedMaterialSlots__Offset, false);}
			
		}
		
		static UParticleSystem()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleSystem");
			SystemUpdateMode__Offset=GetPropertyOffset(NativeClassPtr,"SystemUpdateMode");
			UpdateTime_FPS__Offset=GetPropertyOffset(NativeClassPtr,"UpdateTime_FPS");
			UpdateTime_Delta__Offset=GetPropertyOffset(NativeClassPtr,"UpdateTime_Delta");
			WarmupTime__Offset=GetPropertyOffset(NativeClassPtr,"WarmupTime");
			WarmupTickRate__Offset=GetPropertyOffset(NativeClassPtr,"WarmupTickRate");
			Emitters__Offset=GetPropertyOffset(NativeClassPtr,"Emitters");
			PreviewComponent__Offset=GetPropertyOffset(NativeClassPtr,"PreviewComponent");
			ThumbnailAngle__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailAngle");
			ThumbnailDistance__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailDistance");
			ThumbnailWarmup__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailWarmup");
			CurveEdSetup__Offset=GetPropertyOffset(NativeClassPtr,"CurveEdSetup");
			bOrientZAxisTowardCamera__Offset=GetPropertyOffset(NativeClassPtr,"bOrientZAxisTowardCamera");
			LODDistanceCheckTime__Offset=GetPropertyOffset(NativeClassPtr,"LODDistanceCheckTime");
			LODMethod__Offset=GetPropertyOffset(NativeClassPtr,"LODMethod");
			LODDistances__Offset=GetPropertyOffset(NativeClassPtr,"LODDistances");
			EditorLODSetting__Offset=GetPropertyOffset(NativeClassPtr,"EditorLODSetting");
			bRegenerateLODDuplicate__Offset=GetPropertyOffset(NativeClassPtr,"bRegenerateLODDuplicate");
			LODSettings__Offset=GetPropertyOffset(NativeClassPtr,"LODSettings");
			bUseFixedRelativeBoundingBox__Offset=GetPropertyOffset(NativeClassPtr,"bUseFixedRelativeBoundingBox");
			FixedRelativeBoundingBox__Offset=GetPropertyOffset(NativeClassPtr,"FixedRelativeBoundingBox");
			SecondsBeforeInactive__Offset=GetPropertyOffset(NativeClassPtr,"SecondsBeforeInactive");
			FloorMesh__Offset=GetPropertyOffset(NativeClassPtr,"FloorMesh");
			FloorPosition__Offset=GetPropertyOffset(NativeClassPtr,"FloorPosition");
			FloorRotation__Offset=GetPropertyOffset(NativeClassPtr,"FloorRotation");
			FloorScale__Offset=GetPropertyOffset(NativeClassPtr,"FloorScale");
			FloorScale3D__Offset=GetPropertyOffset(NativeClassPtr,"FloorScale3D");
			BackgroundColor__Offset=GetPropertyOffset(NativeClassPtr,"BackgroundColor");
			bShouldResetPeakCounts__Offset=GetPropertyOffset(NativeClassPtr,"bShouldResetPeakCounts");
			bHasPhysics__Offset=GetPropertyOffset(NativeClassPtr,"bHasPhysics");
			bUseRealtimeThumbnail__Offset=GetPropertyOffset(NativeClassPtr,"bUseRealtimeThumbnail");
			ThumbnailImageOutOfDate__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailImageOutOfDate");
			ThumbnailImage__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailImage");
			Delay__Offset=GetPropertyOffset(NativeClassPtr,"Delay");
			DelayLow__Offset=GetPropertyOffset(NativeClassPtr,"DelayLow");
			bUseDelayRange__Offset=GetPropertyOffset(NativeClassPtr,"bUseDelayRange");
			bAutoDeactivate__Offset=GetPropertyOffset(NativeClassPtr,"bAutoDeactivate");
			MinTimeBetweenTicks__Offset=GetPropertyOffset(NativeClassPtr,"MinTimeBetweenTicks");
			InsignificanceDelay__Offset=GetPropertyOffset(NativeClassPtr,"InsignificanceDelay");
			MacroUVPosition__Offset=GetPropertyOffset(NativeClassPtr,"MacroUVPosition");
			MacroUVRadius__Offset=GetPropertyOffset(NativeClassPtr,"MacroUVRadius");
			OcclusionBoundsMethod__Offset=GetPropertyOffset(NativeClassPtr,"OcclusionBoundsMethod");
			CustomOcclusionBounds__Offset=GetPropertyOffset(NativeClassPtr,"CustomOcclusionBounds");
			SoloTracking__Offset=GetPropertyOffset(NativeClassPtr,"SoloTracking");
			NamedMaterialSlots__Offset=GetPropertyOffset(NativeClassPtr,"NamedMaterialSlots");
			
		}
		
	}
	
}
#endif
#endif
