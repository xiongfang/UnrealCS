#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleRequired
	{
		static readonly int Material__Offset;
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
		public EParticleScreenAlignment ScreenAlignment
		{
			get{ CheckIsValid();return (EParticleScreenAlignment)Marshal.PtrToStructure(_this.Get()+ScreenAlignment__Offset, typeof(EParticleScreenAlignment));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ScreenAlignment__Offset, false);}
			
		}
		
		static readonly int MinFacingCameraBlendDistance__Offset;
		public float MinFacingCameraBlendDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MinFacingCameraBlendDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinFacingCameraBlendDistance__Offset, false);}
			
		}
		
		static readonly int MaxFacingCameraBlendDistance__Offset;
		public float MaxFacingCameraBlendDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxFacingCameraBlendDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxFacingCameraBlendDistance__Offset, false);}
			
		}
		
		static readonly int bUseLocalSpace__Offset;
		public bool bUseLocalSpace
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseLocalSpace__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseLocalSpace__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bKillOnDeactivate__Offset;
		public bool bKillOnDeactivate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bKillOnDeactivate__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bKillOnDeactivate__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bKillOnCompleted__Offset;
		public bool bKillOnCompleted
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bKillOnCompleted__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bKillOnCompleted__Offset, 1,0,4,4);}
			
		}
		
		static readonly int SortMode__Offset;
		public EParticleSortMode SortMode
		{
			get{ CheckIsValid();return (EParticleSortMode)Marshal.PtrToStructure(_this.Get()+SortMode__Offset, typeof(EParticleSortMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SortMode__Offset, false);}
			
		}
		
		static readonly int bUseLegacyEmitterTime__Offset;
		public bool bUseLegacyEmitterTime
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseLegacyEmitterTime__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseLegacyEmitterTime__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bRemoveHMDRoll__Offset;
		public bool bRemoveHMDRoll
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRemoveHMDRoll__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRemoveHMDRoll__Offset, 1,0,2,2);}
			
		}
		
		static readonly int EmitterDuration__Offset;
		public float EmitterDuration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmitterDuration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterDuration__Offset, false);}
			
		}
		
		static readonly int EmitterDurationLow__Offset;
		public float EmitterDurationLow
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmitterDurationLow__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterDurationLow__Offset, false);}
			
		}
		
		static readonly int bEmitterDurationUseRange__Offset;
		public bool bEmitterDurationUseRange
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEmitterDurationUseRange__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEmitterDurationUseRange__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDurationRecalcEachLoop__Offset;
		public bool bDurationRecalcEachLoop
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDurationRecalcEachLoop__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDurationRecalcEachLoop__Offset, 1,0,2,2);}
			
		}
		
		static readonly int EmitterLoops__Offset;
		public int EmitterLoops
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+EmitterLoops__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterLoops__Offset, false);}
			
		}
		
		static readonly int SpawnRate__Offset;
		public FRawDistributionFloat SpawnRate
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+SpawnRate__Offset, typeof(FRawDistributionFloat));}
			
		}
		
		static readonly int ParticleBurstMethod__Offset;
		public EParticleBurstMethod ParticleBurstMethod
		{
			get{ CheckIsValid();return (EParticleBurstMethod)Marshal.PtrToStructure(_this.Get()+ParticleBurstMethod__Offset, typeof(EParticleBurstMethod));}
			
		}
		
		static readonly int BurstList__Offset;
		public TStructArray<FParticleBurst> BurstList
		{
			get{ CheckIsValid();return new TStructArray<FParticleBurst>((FScriptArray)Marshal.PtrToStructure(_this.Get()+BurstList__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+BurstList__Offset, false);}
			
		}
		
		static readonly int EmitterDelay__Offset;
		public float EmitterDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmitterDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterDelay__Offset, false);}
			
		}
		
		static readonly int EmitterDelayLow__Offset;
		public float EmitterDelayLow
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EmitterDelayLow__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterDelayLow__Offset, false);}
			
		}
		
		static readonly int bEmitterDelayUseRange__Offset;
		public bool bEmitterDelayUseRange
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEmitterDelayUseRange__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEmitterDelayUseRange__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDelayFirstLoopOnly__Offset;
		public bool bDelayFirstLoopOnly
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDelayFirstLoopOnly__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDelayFirstLoopOnly__Offset, 1,0,2,2);}
			
		}
		
		static readonly int InterpolationMethod__Offset;
		public EParticleSubUVInterpMethod InterpolationMethod
		{
			get{ CheckIsValid();return (EParticleSubUVInterpMethod)Marshal.PtrToStructure(_this.Get()+InterpolationMethod__Offset, typeof(EParticleSubUVInterpMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpolationMethod__Offset, false);}
			
		}
		
		static readonly int SubImages_Horizontal__Offset;
		public int SubImages_Horizontal
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImages_Horizontal__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImages_Horizontal__Offset, false);}
			
		}
		
		static readonly int SubImages_Vertical__Offset;
		public int SubImages_Vertical
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubImages_Vertical__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SubImages_Vertical__Offset, false);}
			
		}
		
		static readonly int bScaleUV__Offset;
		public bool bScaleUV
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bScaleUV__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bScaleUV__Offset, 1,0,1,1);}
			
		}
		
		static readonly int RandomImageTime__Offset;
		public float RandomImageTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+RandomImageTime__Offset, typeof(float));}
			
		}
		
		static readonly int RandomImageChanges__Offset;
		public int RandomImageChanges
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+RandomImageChanges__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RandomImageChanges__Offset, false);}
			
		}
		
		static readonly int bOverrideSystemMacroUV__Offset;
		public bool bOverrideSystemMacroUV
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOverrideSystemMacroUV__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOverrideSystemMacroUV__Offset, 1,0,1,1);}
			
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
		
		static readonly int bUseMaxDrawCount__Offset;
		public bool bUseMaxDrawCount
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bUseMaxDrawCount__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bUseMaxDrawCount__Offset, 1,0,1,1);}
			
		}
		
		static readonly int MaxDrawCount__Offset;
		public int MaxDrawCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxDrawCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxDrawCount__Offset, false);}
			
		}
		
		static readonly int CutoutTexture__Offset;
		public UTexture2D CutoutTexture
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + CutoutTexture__Offset); if (v == IntPtr.Zero)return null; UTexture2D retValue = new UTexture2D(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + CutoutTexture__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + CutoutTexture__Offset, value._this.Get()); }
			
		}
		
		static readonly int BoundingMode__Offset;
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
		public float AlphaThreshold
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+AlphaThreshold__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+AlphaThreshold__Offset, false);}
			
		}
		
		static readonly int EmitterNormalsMode__Offset;
		public EEmitterNormalsMode EmitterNormalsMode
		{
			get{ CheckIsValid();return (EEmitterNormalsMode)Marshal.PtrToStructure(_this.Get()+EmitterNormalsMode__Offset, typeof(EEmitterNormalsMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterNormalsMode__Offset, false);}
			
		}
		
		static readonly int NormalsSphereCenter__Offset;
		public FVector NormalsSphereCenter
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+NormalsSphereCenter__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalsSphereCenter__Offset, false);}
			
		}
		
		static readonly int NormalsCylinderDirection__Offset;
		public FVector NormalsCylinderDirection
		{
			get{ CheckIsValid();return (FVector)Marshal.PtrToStructure(_this.Get()+NormalsCylinderDirection__Offset, typeof(FVector));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+NormalsCylinderDirection__Offset, false);}
			
		}
		
		static readonly int bOrbitModuleAffectsVelocityAlignment__Offset;
		public bool bOrbitModuleAffectsVelocityAlignment
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bOrbitModuleAffectsVelocityAlignment__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bOrbitModuleAffectsVelocityAlignment__Offset, 1,0,1,1);}
			
		}
		
		static readonly int NamedMaterialOverrides__Offset;
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
