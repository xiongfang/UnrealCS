using System;
namespace UnrealEngine
{
	public partial class UParticleEmitter:UObject
	{
		/// <summary>The name of the emitter.</summary>
		public FName EmitterName;
		
		public int SubUVDataOffset;
		
		/// <summary>
		/// How to render the emitter particles. Can be one of the following:
		///         ERM_Normal      - As the intended sprite/mesh
		///         ERM_Point       - As a 2x2 pixel block with no scaling and the color set in EmitterEditorColor
		///         ERM_Cross       - As a cross of lines, scaled to the size of the particle in EmitterEditorColor
		///         ERM_None        - Do not render
		/// </summary>
		public EEmitterRenderMode EmitterRenderMode;
		
		/// <summary>The color of the emitter in the curve editor and debug rendering modes.</summary>
		public FColor EmitterEditorColor;
		
		public bool ConvertedModules;
		
		public int PeakActiveParticles;
		
		/// <summary>Initial allocation count - overrides calculated peak count if > 0</summary>
		public int InitialAllocationCount;
		
		/// <summary>
		/// Scales the spawn rate of this emitter when the engine is running in medium or low detail mode.
		/// This can be used to optimize particle draw cost in splitscreen.
		/// A value of 0 effectively disables this emitter outside of high detail mode,
		/// And this does not affect spawn per unit, unless the value is 0.
		/// </summary>
		public float MediumDetailSpawnRateScale;
		
		public float QualityLevelSpawnRateScale;
		
		/// <summary>If detail mode is >= system detail mode, primitive won't be rendered.</summary>
		public EDetailMode DetailMode;
		
		/// <summary>This value indicates the emitter should be drawn 'collapsed' in Cascade</summary>
		public bool bCollapsed;
		
		/// <summary>If true, then show only this emitter in the editor</summary>
		public bool bIsSoloing;
		
		/// <summary>
		/// If true, then this emitter was 'cooked out' by the cooker.
		/// This means it was completely disabled, but to preserve any
		/// indexing schemes, it is left in place.
		/// </summary>
		public bool bCookedOut;
		
		/// <summary>When true, if the current LOD is disabled the emitter will be kept alive. Otherwise, the emitter will be considered complete if the current LOD is disabled.</summary>
		public bool bDisabledLODsKeepEmitterAlive;
		
		/// <summary>When true, emitters deemed insignificant will have their tick and render disabled Instantly. When false they will simple stop spawning new particles.</summary>
		public bool bDisableWhenInsignficant;
		
		
	}
	
}
