#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataRibbon
	{
		static readonly int MaxTessellationBetweenParticles__Offset;
		/// <summary>
		/// The maximum amount to tessellate between two particles of the trail.
		/// Depending on the distance between the particles and the tangent change, the
		/// system will select a number of tessellation points
		///         [0..MaxTessellationBetweenParticles]
		/// </summary>
		public int MaxTessellationBetweenParticles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxTessellationBetweenParticles__Offset, typeof(int));}
			
		}
		
		static readonly int SheetsPerTrail__Offset;
		/// <summary>The number of sheets to render for the trail.</summary>
		public int SheetsPerTrail
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SheetsPerTrail__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SheetsPerTrail__Offset, false);}
			
		}
		
		static readonly int MaxTrailCount__Offset;
		/// <summary>The number of live trails</summary>
		public int MaxTrailCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxTrailCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxTrailCount__Offset, false);}
			
		}
		
		static readonly int MaxParticleInTrailCount__Offset;
		/// <summary>Max particles per trail</summary>
		public int MaxParticleInTrailCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxParticleInTrailCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxParticleInTrailCount__Offset, false);}
			
		}
		
		static readonly int bDeadTrailsOnDeactivate__Offset;
		/// <summary>
		/// If true, when the system is deactivated, mark trails as dead.
		/// This means they will still render, but will not have more particles
		/// added to them, even if the system re-activates...
		/// </summary>
		public bool bDeadTrailsOnDeactivate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDeadTrailsOnDeactivate__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDeadTrailsOnDeactivate__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDeadTrailsOnSourceLoss__Offset;
		/// <summary>
		/// If true, when the source of a trail is 'lost' (ie, the source particle
		/// dies), mark the current trail as dead.
		/// </summary>
		public bool bDeadTrailsOnSourceLoss
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDeadTrailsOnSourceLoss__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDeadTrailsOnSourceLoss__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bClipSourceSegement__Offset;
		/// <summary>If true, do not join the trail to the source position</summary>
		public bool bClipSourceSegement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClipSourceSegement__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClipSourceSegement__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bEnablePreviousTangentRecalculation__Offset;
		/// <summary>If true, recalculate the previous tangent when a new particle is spawned</summary>
		public bool bEnablePreviousTangentRecalculation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePreviousTangentRecalculation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePreviousTangentRecalculation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bTangentRecalculationEveryFrame__Offset;
		/// <summary>If true, recalculate tangents every frame to allow velocity/acceleration to be applied</summary>
		public bool bTangentRecalculationEveryFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTangentRecalculationEveryFrame__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTangentRecalculationEveryFrame__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bSpawnInitialParticle__Offset;
		/// <summary>If true, ribbon will spawn a particle when it first starts moving</summary>
		public bool bSpawnInitialParticle
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSpawnInitialParticle__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSpawnInitialParticle__Offset, 1,0,32,32);}
			
		}
		
		static readonly int RenderAxis__Offset;
		/// <summary>
		/// The 'render' axis for the trail (what axis the trail is stretched out on)
		///         Trails_CameraUp - Traditional camera-facing trail.
		///         Trails_SourceUp - Use the up axis of the source for each spawned particle.
		///         Trails_WorldUp  - Use the world up axis.
		/// </summary>
		public ETrailsRenderAxisOption RenderAxis
		{
			get{ CheckIsValid();return (ETrailsRenderAxisOption)Marshal.PtrToStructure(_this.Get()+RenderAxis__Offset, typeof(ETrailsRenderAxisOption));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RenderAxis__Offset, false);}
			
		}
		
		static readonly int TangentSpawningScalar__Offset;
		/// <summary>
		/// The tangent scalar for spawning.
		/// Angles between tangent A and B are mapped to [0.0f .. 1.0f]
		/// This is then multiplied by TangentTessellationScalar to give the number of particles to spawn
		/// </summary>
		public float TangentSpawningScalar
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TangentSpawningScalar__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TangentSpawningScalar__Offset, false);}
			
		}
		
		static readonly int bRenderGeometry__Offset;
		/// <summary>If true, render the trail geometry (this should typically be on)</summary>
		public bool bRenderGeometry
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderGeometry__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderGeometry__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bRenderSpawnPoints__Offset;
		/// <summary>If true, render stars at each spawned particle point along the trail</summary>
		public bool bRenderSpawnPoints
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderSpawnPoints__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderSpawnPoints__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bRenderTangents__Offset;
		/// <summary>If true, render a line showing the tangent at each spawned particle point along the trail</summary>
		public bool bRenderTangents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderTangents__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderTangents__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bRenderTessellation__Offset;
		/// <summary>If true, render the tessellated path between spawned particles</summary>
		public bool bRenderTessellation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderTessellation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderTessellation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int TilingDistance__Offset;
		/// <summary>
		/// The (estimated) covered distance to tile the 2nd UV set at.
		/// If 0.0, a second UV set will not be passed in.
		/// </summary>
		public float TilingDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TilingDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TilingDistance__Offset, false);}
			
		}
		
		static readonly int DistanceTessellationStepSize__Offset;
		/// <summary>
		/// The distance step size for tessellation.
		/// # Tessellation Points = TruncToInt((Distance Between Spawned Particles) / DistanceTessellationStepSize))
		/// </summary>
		public float DistanceTessellationStepSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceTessellationStepSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceTessellationStepSize__Offset, false);}
			
		}
		
		static readonly int bEnableTangentDiffInterpScale__Offset;
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
		public bool bEnableTangentDiffInterpScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableTangentDiffInterpScale__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableTangentDiffInterpScale__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TangentTessellationScalar__Offset;
		/// <summary>
		/// The tangent scalar for tessellation.
		/// Angles between tangent A and B are mapped to [0.0f .. 1.0f]
		/// This is then multiplied by TangentTessellationScalar to give the number of points to tessellate
		/// </summary>
		public float TangentTessellationScalar
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TangentTessellationScalar__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TangentTessellationScalar__Offset, false);}
			
		}
		
		static UParticleModuleTypeDataRibbon()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleTypeDataRibbon");
			MaxTessellationBetweenParticles__Offset=GetPropertyOffset(NativeClassPtr,"MaxTessellationBetweenParticles");
			SheetsPerTrail__Offset=GetPropertyOffset(NativeClassPtr,"SheetsPerTrail");
			MaxTrailCount__Offset=GetPropertyOffset(NativeClassPtr,"MaxTrailCount");
			MaxParticleInTrailCount__Offset=GetPropertyOffset(NativeClassPtr,"MaxParticleInTrailCount");
			bDeadTrailsOnDeactivate__Offset=GetPropertyOffset(NativeClassPtr,"bDeadTrailsOnDeactivate");
			bDeadTrailsOnSourceLoss__Offset=GetPropertyOffset(NativeClassPtr,"bDeadTrailsOnSourceLoss");
			bClipSourceSegement__Offset=GetPropertyOffset(NativeClassPtr,"bClipSourceSegement");
			bEnablePreviousTangentRecalculation__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePreviousTangentRecalculation");
			bTangentRecalculationEveryFrame__Offset=GetPropertyOffset(NativeClassPtr,"bTangentRecalculationEveryFrame");
			bSpawnInitialParticle__Offset=GetPropertyOffset(NativeClassPtr,"bSpawnInitialParticle");
			RenderAxis__Offset=GetPropertyOffset(NativeClassPtr,"RenderAxis");
			TangentSpawningScalar__Offset=GetPropertyOffset(NativeClassPtr,"TangentSpawningScalar");
			bRenderGeometry__Offset=GetPropertyOffset(NativeClassPtr,"bRenderGeometry");
			bRenderSpawnPoints__Offset=GetPropertyOffset(NativeClassPtr,"bRenderSpawnPoints");
			bRenderTangents__Offset=GetPropertyOffset(NativeClassPtr,"bRenderTangents");
			bRenderTessellation__Offset=GetPropertyOffset(NativeClassPtr,"bRenderTessellation");
			TilingDistance__Offset=GetPropertyOffset(NativeClassPtr,"TilingDistance");
			DistanceTessellationStepSize__Offset=GetPropertyOffset(NativeClassPtr,"DistanceTessellationStepSize");
			bEnableTangentDiffInterpScale__Offset=GetPropertyOffset(NativeClassPtr,"bEnableTangentDiffInterpScale");
			TangentTessellationScalar__Offset=GetPropertyOffset(NativeClassPtr,"TangentTessellationScalar");
			
		}
		
	}
	
}
#endif
#endif
