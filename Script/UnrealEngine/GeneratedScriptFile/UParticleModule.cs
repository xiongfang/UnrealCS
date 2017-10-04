using System;
namespace UnrealEngine
{
	public partial class UParticleModule:UObject
	{
		/// <summary>If true, the module performs operations on particles during Spawning</summary>
		public bool bSpawnModule;
		
		/// <summary>If true, the module performs operations on particles during Updating</summary>
		public bool bUpdateModule;
		
		/// <summary>If true, the module performs operations on particles during final update</summary>
		public bool bFinalUpdateModule;
		
		/// <summary>If true, the module performs operations on particles during update and/or final update for GPU emitters</summary>
		public bool bUpdateForGPUEmitter;
		
		/// <summary>If true, the module displays FVector curves as colors</summary>
		public bool bCurvesAsColor;
		
		/// <summary>If true, the module should render its 3D visualization helper</summary>
		public bool b3DDrawMode;
		
		/// <summary>If true, the module supports rendering a 3D visualization helper</summary>
		public bool bSupported3DDrawMode;
		
		/// <summary>If true, the module is enabled</summary>
		public bool bEnabled;
		
		/// <summary>If true, the module has had editing enabled on it</summary>
		public bool bEditable;
		
		/// <summary>
		/// If true, this flag indicates that auto-generation for LOD will result in
		/// an exact duplicate of the module, regardless of the percentage.
		/// If false, it will result in a module with different settings.
		/// </summary>
		public bool LODDuplicate;
		
		/// <summary>If true, the module supports RandomSeed setting</summary>
		public bool bSupportsRandomSeed;
		
		/// <summary>If true, the module should be told when looping</summary>
		public bool bRequiresLoopingNotification;
		
		/// <summary>
		/// The LOD levels this module is present in.
		/// Bit-flags are used to indicate validity for a given LOD level.
		/// For example, if
		///         ((1 << Level) & LODValidity) != 0
		/// then the module is used in that LOD.
		/// </summary>
		public byte LODValidity;
		
		/// <summary>
		/// The color to draw the modules curves in the curve editor.
		///     If bCurvesAsColor is true, it overrides this value.
		/// </summary>
		public FColor ModuleEditorColor;
		
		
	}
	
}
