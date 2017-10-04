using System;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataBeam2:UParticleModuleTypeDataBase
	{
		/// <summary>
		/// The method with which to form the beam(s). Must be one of the following:
		///         PEB2M_Distance  - Use the distance property to emit a beam along the X-axis of the emitter.
		///         PEB2M_Target    - Emit a beam from the source to the supplied target.
		///         PEB2M_Branch    - Currently unimplemented.
		/// </summary>
		public EBeam2Method BeamMethod;
		
		/// <summary>
		/// The number of times to tile the texture along each beam.
		/// Overridden by TextureTilingDistance if it is > 0.0.
		///     1st UV set only. 2nd UV set does not Tile.
		/// </summary>
		public int TextureTile;
		
		/// <summary>
		/// The distance per texture tile.
		///     1st UV set only. 2nd UV set does not Tile.
		/// </summary>
		public float TextureTileDistance;
		
		/// <summary>The number of sheets to render</summary>
		public int Sheets;
		
		/// <summary>The number of live beams</summary>
		public int MaxBeamCount;
		
		/// <summary>
		/// The speed at which the beam should move from source to target when firing up.
		///     '0' indicates instantaneous
		/// </summary>
		public float Speed;
		
		/// <summary>
		/// Indicates whether the beam should be interpolated.
		///     <= 0 --> no
		///     >  0 --> yes (and is equal to the number of interpolation steps that should be taken.
		/// </summary>
		public int InterpolationPoints;
		
		/// <summary>If true, there will ALWAYS be a beam...</summary>
		public bool bAlwaysOn;
		
		/// <summary>
		/// The approach to use for determining the Up vector(s) for the beam.
		/// 0 indicates that the Up FVector should be calculated at EVERY point in the beam.
		/// 1 indicates a single Up FVector should be determined at the start of the beam and used at every point.
		/// N indicates an Up FVector should be calculated every N points of the beam and interpolated between them.
		///     [NOTE: This mode is currently unsupported.]
		/// </summary>
		public int UpVectorStepSize;
		
		/// <summary>
		/// The name of the emitter to branch from (if mode is PEB2M_Branch)
		/// MUST BE IN THE SAME PARTICLE SYSTEM!
		/// </summary>
		public FName BranchParentName;
		
		/// <summary>
		/// The distance along the X-axis to stretch the beam
		/// Distance is only used if BeamMethod is PEB2M_Distance
		/// </summary>
		public FRawDistributionFloat Distance;
		
		/// <summary>
		/// Tapering mode - one of the following:
		/// PEBTM_None              - No tapering is applied
		/// PEBTM_Full              - Taper the beam relative to source-->target, regardless of current beam length
		/// PEBTM_Partial   - Taper the beam relative to source-->location, 0=source,1=endpoint
		/// </summary>
		public EBeamTaperMethod TaperMethod;
		
		/// <summary>Tapering factor, 0 = source of beam, 1 = target</summary>
		public FRawDistributionFloat TaperFactor;
		
		/// <summary>
		/// Tapering scaling
		///     This is intended to be either a constant, uniform or a ParticleParam.
		///     If a curve is used, 0/1 mapping of source/target... which could be integrated into
		///     the taper factor itself, and therefore makes no sense.
		/// </summary>
		public FRawDistributionFloat TaperScale;
		
		/// <summary>Beam Rendering Variables.</summary>
		public bool RenderGeometry;
		
		public bool RenderDirectLine;
		
		public bool RenderLines;
		
		public bool RenderTessellation;
		
		
	}
	
}
