using System;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataRibbon:UParticleModuleTypeDataBase
	{
		/// <summary>
		/// The maximum amount to tessellate between two particles of the trail.
		/// Depending on the distance between the particles and the tangent change, the
		/// system will select a number of tessellation points
		///         [0..MaxTessellationBetweenParticles]
		/// </summary>
		public int MaxTessellationBetweenParticles;
		
		/// <summary>The number of sheets to render for the trail.</summary>
		public int SheetsPerTrail;
		
		/// <summary>The number of live trails</summary>
		public int MaxTrailCount;
		
		/// <summary>Max particles per trail</summary>
		public int MaxParticleInTrailCount;
		
		/// <summary>
		/// If true, when the system is deactivated, mark trails as dead.
		/// This means they will still render, but will not have more particles
		/// added to them, even if the system re-activates...
		/// </summary>
		public bool bDeadTrailsOnDeactivate;
		
		/// <summary>
		/// If true, when the source of a trail is 'lost' (ie, the source particle
		/// dies), mark the current trail as dead.
		/// </summary>
		public bool bDeadTrailsOnSourceLoss;
		
		/// <summary>If true, do not join the trail to the source position</summary>
		public bool bClipSourceSegement;
		
		/// <summary>If true, recalculate the previous tangent when a new particle is spawned</summary>
		public bool bEnablePreviousTangentRecalculation;
		
		/// <summary>If true, recalculate tangents every frame to allow velocity/acceleration to be applied</summary>
		public bool bTangentRecalculationEveryFrame;
		
		/// <summary>If true, ribbon will spawn a particle when it first starts moving</summary>
		public bool bSpawnInitialParticle;
		
		/// <summary>
		/// The 'render' axis for the trail (what axis the trail is stretched out on)
		///         Trails_CameraUp - Traditional camera-facing trail.
		///         Trails_SourceUp - Use the up axis of the source for each spawned particle.
		///         Trails_WorldUp  - Use the world up axis.
		/// </summary>
		public ETrailsRenderAxisOption RenderAxis;
		
		/// <summary>
		/// The tangent scalar for spawning.
		/// Angles between tangent A and B are mapped to [0.0f .. 1.0f]
		/// This is then multiplied by TangentTessellationScalar to give the number of particles to spawn
		/// </summary>
		public float TangentSpawningScalar;
		
		/// <summary>If true, render the trail geometry (this should typically be on)</summary>
		public bool bRenderGeometry;
		
		/// <summary>If true, render stars at each spawned particle point along the trail</summary>
		public bool bRenderSpawnPoints;
		
		/// <summary>If true, render a line showing the tangent at each spawned particle point along the trail</summary>
		public bool bRenderTangents;
		
		/// <summary>If true, render the tessellated path between spawned particles</summary>
		public bool bRenderTessellation;
		
		/// <summary>
		/// The (estimated) covered distance to tile the 2nd UV set at.
		/// If 0.0, a second UV set will not be passed in.
		/// </summary>
		public float TilingDistance;
		
		/// <summary>
		/// The distance step size for tessellation.
		/// # Tessellation Points = TruncToInt((Distance Between Spawned Particles) / DistanceTessellationStepSize))
		/// </summary>
		public float DistanceTessellationStepSize;
		
		/// <summary>
		/// If this flag is enabled, the system will scale the number of interpolated vertices
		/// based on the difference in the tangents of neighboring particles.
		/// Each pair of neighboring particles will compute the following CheckTangent value:
		///         CheckTangent = ((ParticleA Tangent DOT ParticleB Tangent) - 1.0f) * 0.5f
		/// If CheckTangent is LESS THAN 0.5, then the DistanceTessellationStepSize will be
		/// scaled based on the result. This will map so that from parallel to orthogonal
		/// (0..90 degrees) will scale from [0..1]. Anything greater than 90 degrees will clamp
		/// at a scale of 1.
		/// </summary>
		public bool bEnableTangentDiffInterpScale;
		
		/// <summary>
		/// The tangent scalar for tessellation.
		/// Angles between tangent A and B are mapped to [0.0f .. 1.0f]
		/// This is then multiplied by TangentTessellationScalar to give the number of points to tessellate
		/// </summary>
		public float TangentTessellationScalar;
		
		
	}
	
}
