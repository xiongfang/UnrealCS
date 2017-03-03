#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleEmitter
	{
		static readonly int EmitterName__Offset;
		public FName EmitterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+EmitterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterName__Offset, false);}
			
		}
		
		static readonly int SubUVDataOffset__Offset;
		public int SubUVDataOffset
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SubUVDataOffset__Offset, typeof(int));}
			
		}
		
		static readonly int EmitterRenderMode__Offset;
		public EEmitterRenderMode EmitterRenderMode
		{
			get{ CheckIsValid();return (EEmitterRenderMode)Marshal.PtrToStructure(_this.Get()+EmitterRenderMode__Offset, typeof(EEmitterRenderMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterRenderMode__Offset, false);}
			
		}
		
		static readonly int LODLevels__Offset;
		public TObjectArray<UParticleLODLevel>  LODLevels
		{
					get{ CheckIsValid();return new TObjectArray<UParticleLODLevel>((FScriptArray)Marshal.PtrToStructure(_this.Get()+LODLevels__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+LODLevels__Offset, false);}
			
		}
		
		static readonly int ConvertedModules__Offset;
		public bool ConvertedModules
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), ConvertedModules__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int PeakActiveParticles__Offset;
		public int PeakActiveParticles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+PeakActiveParticles__Offset, typeof(int));}
			
		}
		
		static readonly int InitialAllocationCount__Offset;
		public int InitialAllocationCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+InitialAllocationCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialAllocationCount__Offset, false);}
			
		}
		
		static readonly int MediumDetailSpawnRateScale__Offset;
		public float MediumDetailSpawnRateScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MediumDetailSpawnRateScale__Offset, typeof(float));}
			
		}
		
		static readonly int QualityLevelSpawnRateScale__Offset;
		public float QualityLevelSpawnRateScale
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+QualityLevelSpawnRateScale__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+QualityLevelSpawnRateScale__Offset, false);}
			
		}
		
		static readonly int DetailMode__Offset;
		public EDetailMode DetailMode
		{
			get{ CheckIsValid();return (EDetailMode)Marshal.PtrToStructure(_this.Get()+DetailMode__Offset, typeof(EDetailMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DetailMode__Offset, false);}
			
		}
		
		static readonly int bIsSoloing__Offset;
		public bool bIsSoloing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSoloing__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bCookedOut__Offset;
		public bool bCookedOut
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCookedOut__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bDisabledLODsKeepEmitterAlive__Offset;
		public bool bDisabledLODsKeepEmitterAlive
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisabledLODsKeepEmitterAlive__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisabledLODsKeepEmitterAlive__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bDisableWhenInsignficant__Offset;
		public bool bDisableWhenInsignficant
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableWhenInsignficant__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableWhenInsignficant__Offset, 1,0,8,8);}
			
		}
		
		static UParticleEmitter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleEmitter");
			EmitterName__Offset=GetPropertyOffset(NativeClassPtr,"EmitterName");
			SubUVDataOffset__Offset=GetPropertyOffset(NativeClassPtr,"SubUVDataOffset");
			EmitterRenderMode__Offset=GetPropertyOffset(NativeClassPtr,"EmitterRenderMode");
			LODLevels__Offset=GetPropertyOffset(NativeClassPtr,"LODLevels");
			ConvertedModules__Offset=GetPropertyOffset(NativeClassPtr,"ConvertedModules");
			PeakActiveParticles__Offset=GetPropertyOffset(NativeClassPtr,"PeakActiveParticles");
			InitialAllocationCount__Offset=GetPropertyOffset(NativeClassPtr,"InitialAllocationCount");
			MediumDetailSpawnRateScale__Offset=GetPropertyOffset(NativeClassPtr,"MediumDetailSpawnRateScale");
			QualityLevelSpawnRateScale__Offset=GetPropertyOffset(NativeClassPtr,"QualityLevelSpawnRateScale");
			DetailMode__Offset=GetPropertyOffset(NativeClassPtr,"DetailMode");
			bIsSoloing__Offset=GetPropertyOffset(NativeClassPtr,"bIsSoloing");
			bCookedOut__Offset=GetPropertyOffset(NativeClassPtr,"bCookedOut");
			bDisabledLODsKeepEmitterAlive__Offset=GetPropertyOffset(NativeClassPtr,"bDisabledLODsKeepEmitterAlive");
			bDisableWhenInsignficant__Offset=GetPropertyOffset(NativeClassPtr,"bDisableWhenInsignficant");
			
		}
		
	}
	
}
#endif
#endif
