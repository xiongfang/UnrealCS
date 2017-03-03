#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleSystem
	{
		static readonly int SystemUpdateMode__Offset;
		public EParticleSystemUpdateMode SystemUpdateMode
		{
			get{ CheckIsValid();return (EParticleSystemUpdateMode)Marshal.PtrToStructure(_this.Get()+SystemUpdateMode__Offset, typeof(EParticleSystemUpdateMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SystemUpdateMode__Offset, false);}
			
		}
		
		static readonly int UpdateTime_FPS__Offset;
		public float UpdateTime_FPS
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UpdateTime_FPS__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UpdateTime_FPS__Offset, false);}
			
		}
		
		static readonly int UpdateTime_Delta__Offset;
		public float UpdateTime_Delta
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UpdateTime_Delta__Offset, typeof(float));}
			
		}
		
		static readonly int WarmupTime__Offset;
		public float WarmupTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WarmupTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WarmupTime__Offset, false);}
			
		}
		
		static readonly int WarmupTickRate__Offset;
		public float WarmupTickRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WarmupTickRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WarmupTickRate__Offset, false);}
			
		}
		
		static readonly int Emitters__Offset;
		public TObjectArray<UParticleEmitter>  Emitters
		{
					get{ CheckIsValid();return new TObjectArray<UParticleEmitter>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Emitters__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Emitters__Offset, false);}
			
		}
		
		static readonly int PreviewComponent__Offset;
		public UParticleSystemComponent PreviewComponent
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + PreviewComponent__Offset); if (v == IntPtr.Zero)return null; UParticleSystemComponent retValue = new UParticleSystemComponent(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int CurveEdSetup__Offset;
		public UInterpCurveEdSetup CurveEdSetup
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CurveEdSetup__Offset); if (v == IntPtr.Zero)return null; UInterpCurveEdSetup retValue = new UInterpCurveEdSetup(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int bOrientZAxisTowardCamera__Offset;
		public bool bOrientZAxisTowardCamera
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOrientZAxisTowardCamera__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOrientZAxisTowardCamera__Offset, 1,0,1,1);}
			
		}
		
		static readonly int LODDistanceCheckTime__Offset;
		public float LODDistanceCheckTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+LODDistanceCheckTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODDistanceCheckTime__Offset, false);}
			
		}
		
		static readonly int LODMethod__Offset;
		public ParticleSystemLODMethod LODMethod
		{
			get{ CheckIsValid();return (ParticleSystemLODMethod)Marshal.PtrToStructure(_this.Get()+LODMethod__Offset, typeof(ParticleSystemLODMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LODMethod__Offset, false);}
			
		}
		
		static readonly int LODDistances__Offset;
		public TStructArray<float> LODDistances
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODDistances__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODDistances__Offset, false);}
			
		}
		
		static readonly int bRegenerateLODDuplicate__Offset;
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
		public bool bUseFixedRelativeBoundingBox
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseFixedRelativeBoundingBox__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseFixedRelativeBoundingBox__Offset, 1,0,1,1);}
			
		}
		
		static readonly int FixedRelativeBoundingBox__Offset;
		public FBox FixedRelativeBoundingBox
		{
			get{ CheckIsValid();return (FBox)Marshal.PtrToStructure(_this.Get()+FixedRelativeBoundingBox__Offset, typeof(FBox));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FixedRelativeBoundingBox__Offset, false);}
			
		}
		
		static readonly int SecondsBeforeInactive__Offset;
		public float SecondsBeforeInactive
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+SecondsBeforeInactive__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SecondsBeforeInactive__Offset, false);}
			
		}
		
		static readonly int bShouldResetPeakCounts__Offset;
		public bool bShouldResetPeakCounts
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bShouldResetPeakCounts__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bHasPhysics__Offset;
		public bool bHasPhysics
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bHasPhysics__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bUseRealtimeThumbnail__Offset;
		public bool bUseRealtimeThumbnail
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseRealtimeThumbnail__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseRealtimeThumbnail__Offset, 1,0,4,4);}
			
		}
		
		static readonly int ThumbnailImageOutOfDate__Offset;
		public bool ThumbnailImageOutOfDate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ThumbnailImageOutOfDate__Offset, 1, 0, 8, 8);}
			
		}
		
		static readonly int Delay__Offset;
		public float Delay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Delay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Delay__Offset, false);}
			
		}
		
		static readonly int DelayLow__Offset;
		public float DelayLow
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DelayLow__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DelayLow__Offset, false);}
			
		}
		
		static readonly int bUseDelayRange__Offset;
		public bool bUseDelayRange
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseDelayRange__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseDelayRange__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bAutoDeactivate__Offset;
		public bool bAutoDeactivate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoDeactivate__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoDeactivate__Offset, 1,0,1,255);}
			
		}
		
		static readonly int MinTimeBetweenTicks__Offset;
		public uint MinTimeBetweenTicks
		{
			get{ CheckIsValid();return (uint)Marshal.PtrToStructure(_this.Get()+MinTimeBetweenTicks__Offset, typeof(uint));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinTimeBetweenTicks__Offset, false);}
			
		}
		
		static readonly int InsignificanceDelay__Offset;
		public float InsignificanceDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InsignificanceDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InsignificanceDelay__Offset, false);}
			
		}
		
		static readonly int MacroUVPosition__Offset;
		public FVector MacroUVPosition
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+MacroUVPosition__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MacroUVPosition__Offset, false);}
			
		}
		
		static readonly int MacroUVRadius__Offset;
		public float MacroUVRadius
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MacroUVRadius__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MacroUVRadius__Offset, false);}
			
		}
		
		static readonly int OcclusionBoundsMethod__Offset;
		public EParticleSystemOcclusionBoundsMethod OcclusionBoundsMethod
		{
			get{ CheckIsValid();return (EParticleSystemOcclusionBoundsMethod)Marshal.PtrToStructure(_this.Get()+OcclusionBoundsMethod__Offset, typeof(EParticleSystemOcclusionBoundsMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OcclusionBoundsMethod__Offset, false);}
			
		}
		
		static readonly int CustomOcclusionBounds__Offset;
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
			CurveEdSetup__Offset=GetPropertyOffset(NativeClassPtr,"CurveEdSetup");
			bOrientZAxisTowardCamera__Offset=GetPropertyOffset(NativeClassPtr,"bOrientZAxisTowardCamera");
			LODDistanceCheckTime__Offset=GetPropertyOffset(NativeClassPtr,"LODDistanceCheckTime");
			LODMethod__Offset=GetPropertyOffset(NativeClassPtr,"LODMethod");
			LODDistances__Offset=GetPropertyOffset(NativeClassPtr,"LODDistances");
			bRegenerateLODDuplicate__Offset=GetPropertyOffset(NativeClassPtr,"bRegenerateLODDuplicate");
			LODSettings__Offset=GetPropertyOffset(NativeClassPtr,"LODSettings");
			bUseFixedRelativeBoundingBox__Offset=GetPropertyOffset(NativeClassPtr,"bUseFixedRelativeBoundingBox");
			FixedRelativeBoundingBox__Offset=GetPropertyOffset(NativeClassPtr,"FixedRelativeBoundingBox");
			SecondsBeforeInactive__Offset=GetPropertyOffset(NativeClassPtr,"SecondsBeforeInactive");
			bShouldResetPeakCounts__Offset=GetPropertyOffset(NativeClassPtr,"bShouldResetPeakCounts");
			bHasPhysics__Offset=GetPropertyOffset(NativeClassPtr,"bHasPhysics");
			bUseRealtimeThumbnail__Offset=GetPropertyOffset(NativeClassPtr,"bUseRealtimeThumbnail");
			ThumbnailImageOutOfDate__Offset=GetPropertyOffset(NativeClassPtr,"ThumbnailImageOutOfDate");
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
