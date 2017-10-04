using System;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataAnimTrail:UParticleModuleTypeDataBase
	{
		/// <summary>
		/// If true, when the system is deactivated, mark trails as dead.
		/// This means they will still render, but will not have more particles
		/// added to them, even if the system re-activates...
		/// </summary>
		public bool bDeadTrailsOnDeactivate;
		
		/// <summary>If true, recalculate the previous tangent when a new particle is spawned</summary>
		public bool bEnablePreviousTangentRecalculation;
		
		/// <summary>If true, recalculate tangents every frame to allow velocity/acceleration to be applied</summary>
		public bool bTangentRecalculationEveryFrame;
		
		/// <summary>
		/// The (estimated) covered distance to tile the 2nd UV set at.
		/// If 0.0, a second UV set will not be passed in.
		/// </summary>
		public float TilingDistance;
		
		/// <summary>
		/// The distance step size for tessellation.
		/// # Tessellation Points = TruncToInt((Distance Between Spawned Particles) / DistanceTessellationStepSize)). If 0 then there is no distance tessellation.
		/// </summary>
		public float DistanceTessellationStepSize;
		
		/// <summary>
		/// The tangent scalar for tessellation.
		/// This is the degree change in the tangent direction [0...180] required to warrant an additional tessellation point. If 0 then there is no tangent tessellation.
		/// </summary>
		public float TangentTessellationStepSize;
		
		/// <summary>
		/// The width step size for tessellation.
		/// This is the number of world units change in the width required to warrant an additional tessellation point. If 0 then there is no width tessellation.
		/// </summary>
		public float WidthTessellationStepSize;
		
		
	}
	
}
