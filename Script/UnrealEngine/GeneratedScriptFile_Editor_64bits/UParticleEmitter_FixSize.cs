#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleEmitter
	{
		static readonly int EmitterName__Offset;
		/// <summary>The name of the emitter.</summary>
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
		/// <summary>
		/// How to render the emitter particles. Can be one of the following:
		///         ERM_Normal      - As the intended sprite/mesh
		///         ERM_Point       - As a 2x2 pixel block with no scaling and the color set in EmitterEditorColor
		///         ERM_Cross       - As a cross of lines, scaled to the size of the particle in EmitterEditorColor
		///         ERM_None        - Do not render
		/// </summary>
		public EEmitterRenderMode EmitterRenderMode
		{
			get{ CheckIsValid();return (EEmitterRenderMode)Marshal.PtrToStructure(_this.Get()+EmitterRenderMode__Offset, typeof(EEmitterRenderMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterRenderMode__Offset, false);}
			
		}
		
		static readonly int EmitterEditorColor__Offset;
		/// <summary>The color of the emitter in the curve editor and debug rendering modes.</summary>
		public FColor EmitterEditorColor
		{
			get{ CheckIsValid();return (FColor)Marshal.PtrToStructure(_this.Get()+EmitterEditorColor__Offset, typeof(FColor));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EmitterEditorColor__Offset, false);}
			
		}
		
		static readonly int LODLevels__Offset;
		/// <summary>'Private' data - not required by the editor</summary>
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
		/// <summary>Initial allocation count - overrides calculated peak count if > 0</summary>
		public int InitialAllocationCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+InitialAllocationCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialAllocationCount__Offset, false);}
			
		}
		
		static readonly int MediumDetailSpawnRateScale__Offset;
		/// <summary>
		/// Scales the spawn rate of this emitter when the engine is running in medium or low detail mode.
		/// This can be used to optimize particle draw cost in splitscreen.
		/// A value of 0 effectively disables this emitter outside of high detail mode,
		/// And this does not affect spawn per unit, unless the value is 0.
		/// </summary>
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
		/// <summary>If detail mode is >= system detail mode, primitive won't be rendered.</summary>
		public EDetailMode DetailMode
		{
			get{ CheckIsValid();return (EDetailMode)Marshal.PtrToStructure(_this.Get()+DetailMode__Offset, typeof(EDetailMode));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DetailMode__Offset, false);}
			
		}
		
		static readonly int bCollapsed__Offset;
		/// <summary>This value indicates the emitter should be drawn 'collapsed' in Cascade</summary>
		public bool bCollapsed
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCollapsed__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bCollapsed__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIsSoloing__Offset;
		/// <summary>If true, then show only this emitter in the editor</summary>
		public bool bIsSoloing
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIsSoloing__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bCookedOut__Offset;
		/// <summary>
		/// If true, then this emitter was 'cooked out' by the cooker.
		/// This means it was completely disabled, but to preserve any
		/// indexing schemes, it is left in place.
		/// </summary>
		public bool bCookedOut
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bCookedOut__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int bDisabledLODsKeepEmitterAlive__Offset;
		/// <summary>When true, if the current LOD is disabled the emitter will be kept alive. Otherwise, the emitter will be considered complete if the current LOD is disabled.</summary>
		public bool bDisabledLODsKeepEmitterAlive
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisabledLODsKeepEmitterAlive__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisabledLODsKeepEmitterAlive__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bDisableWhenInsignficant__Offset;
		/// <summary>When true, emitters deemed insignificant will have their tick and render disabled Instantly. When false they will simple stop spawning new particles.</summary>
		public bool bDisableWhenInsignficant
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDisableWhenInsignficant__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDisableWhenInsignficant__Offset, 1,0,16,16);}
			
		}
		
		static UParticleEmitter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleEmitter");
			EmitterName__Offset=GetPropertyOffset(NativeClassPtr,"EmitterName");
			SubUVDataOffset__Offset=GetPropertyOffset(NativeClassPtr,"SubUVDataOffset");
			EmitterRenderMode__Offset=GetPropertyOffset(NativeClassPtr,"EmitterRenderMode");
			EmitterEditorColor__Offset=GetPropertyOffset(NativeClassPtr,"EmitterEditorColor");
			LODLevels__Offset=GetPropertyOffset(NativeClassPtr,"LODLevels");
			ConvertedModules__Offset=GetPropertyOffset(NativeClassPtr,"ConvertedModules");
			PeakActiveParticles__Offset=GetPropertyOffset(NativeClassPtr,"PeakActiveParticles");
			InitialAllocationCount__Offset=GetPropertyOffset(NativeClassPtr,"InitialAllocationCount");
			MediumDetailSpawnRateScale__Offset=GetPropertyOffset(NativeClassPtr,"MediumDetailSpawnRateScale");
			QualityLevelSpawnRateScale__Offset=GetPropertyOffset(NativeClassPtr,"QualityLevelSpawnRateScale");
			DetailMode__Offset=GetPropertyOffset(NativeClassPtr,"DetailMode");
			bCollapsed__Offset=GetPropertyOffset(NativeClassPtr,"bCollapsed");
			bIsSoloing__Offset=GetPropertyOffset(NativeClassPtr,"bIsSoloing");
			bCookedOut__Offset=GetPropertyOffset(NativeClassPtr,"bCookedOut");
			bDisabledLODsKeepEmitterAlive__Offset=GetPropertyOffset(NativeClassPtr,"bDisabledLODsKeepEmitterAlive");
			bDisableWhenInsignficant__Offset=GetPropertyOffset(NativeClassPtr,"bDisableWhenInsignficant");
			
		}
		
	}
	
}
#endif
#endif
