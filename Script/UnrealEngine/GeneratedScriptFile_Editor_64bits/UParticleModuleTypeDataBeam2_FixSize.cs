#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataBeam2
	{
		static readonly int BeamMethod__Offset;
		/// <summary>
		/// The method with which to form the beam(s). Must be one of the following:
		///         PEB2M_Distance  - Use the distance property to emit a beam along the X-axis of the emitter.
		///         PEB2M_Target    - Emit a beam from the source to the supplied target.
		///         PEB2M_Branch    - Currently unimplemented.
		/// </summary>
		public EBeam2Method BeamMethod
		{
			get{ CheckIsValid();return (EBeam2Method)Marshal.PtrToStructure(_this.Get()+BeamMethod__Offset, typeof(EBeam2Method));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BeamMethod__Offset, false);}
			
		}
		
		static readonly int TextureTile__Offset;
		/// <summary>
		/// The number of times to tile the texture along each beam.
		/// Overridden by TextureTilingDistance if it is > 0.0.
		///     1st UV set only. 2nd UV set does not Tile.
		/// </summary>
		public int TextureTile
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TextureTile__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextureTile__Offset, false);}
			
		}
		
		static readonly int TextureTileDistance__Offset;
		/// <summary>
		/// The distance per texture tile.
		///     1st UV set only. 2nd UV set does not Tile.
		/// </summary>
		public float TextureTileDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TextureTileDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextureTileDistance__Offset, false);}
			
		}
		
		static readonly int Sheets__Offset;
		/// <summary>The number of sheets to render</summary>
		public int Sheets
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Sheets__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Sheets__Offset, false);}
			
		}
		
		static readonly int MaxBeamCount__Offset;
		/// <summary>The number of live beams</summary>
		public int MaxBeamCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxBeamCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxBeamCount__Offset, false);}
			
		}
		
		static readonly int Speed__Offset;
		/// <summary>
		/// The speed at which the beam should move from source to target when firing up.
		///     '0' indicates instantaneous
		/// </summary>
		public float Speed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Speed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Speed__Offset, false);}
			
		}
		
		static readonly int InterpolationPoints__Offset;
		/// <summary>
		/// Indicates whether the beam should be interpolated.
		///     <= 0 --> no
		///     >  0 --> yes (and is equal to the number of interpolation steps that should be taken.
		/// </summary>
		public int InterpolationPoints
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+InterpolationPoints__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpolationPoints__Offset, false);}
			
		}
		
		static readonly int bAlwaysOn__Offset;
		/// <summary>If true, there will ALWAYS be a beam...</summary>
		public bool bAlwaysOn
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysOn__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysOn__Offset, 1,0,1,1);}
			
		}
		
		static readonly int UpVectorStepSize__Offset;
		/// <summary>
		/// The approach to use for determining the Up vector(s) for the beam.
		/// 0 indicates that the Up FVector should be calculated at EVERY point in the beam.
		/// 1 indicates a single Up FVector should be determined at the start of the beam and used at every point.
		/// N indicates an Up FVector should be calculated every N points of the beam and interpolated between them.
		///     [NOTE: This mode is currently unsupported.]
		/// </summary>
		public int UpVectorStepSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+UpVectorStepSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UpVectorStepSize__Offset, false);}
			
		}
		
		static readonly int BranchParentName__Offset;
		/// <summary>
		/// The name of the emitter to branch from (if mode is PEB2M_Branch)
		/// MUST BE IN THE SAME PARTICLE SYSTEM!
		/// </summary>
		public FName BranchParentName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+BranchParentName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BranchParentName__Offset, false);}
			
		}
		
		static readonly int Distance__Offset;
		/// <summary>
		/// The distance along the X-axis to stretch the beam
		/// Distance is only used if BeamMethod is PEB2M_Distance
		/// </summary>
		public FRawDistributionFloat Distance
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Distance__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Distance__Offset, false);}
			
		}
		
		static readonly int TaperMethod__Offset;
		/// <summary>
		/// Tapering mode - one of the following:
		/// PEBTM_None              - No tapering is applied
		/// PEBTM_Full              - Taper the beam relative to source-->target, regardless of current beam length
		/// PEBTM_Partial   - Taper the beam relative to source-->location, 0=source,1=endpoint
		/// </summary>
		public EBeamTaperMethod TaperMethod
		{
			get{ CheckIsValid();return (EBeamTaperMethod)Marshal.PtrToStructure(_this.Get()+TaperMethod__Offset, typeof(EBeamTaperMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TaperMethod__Offset, false);}
			
		}
		
		static readonly int TaperFactor__Offset;
		/// <summary>Tapering factor, 0 = source of beam, 1 = target</summary>
		public FRawDistributionFloat TaperFactor
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+TaperFactor__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TaperFactor__Offset, false);}
			
		}
		
		static readonly int TaperScale__Offset;
		/// <summary>
		/// Tapering scaling
		///     This is intended to be either a constant, uniform or a ParticleParam.
		///     If a curve is used, 0/1 mapping of source/target... which could be integrated into
		///     the taper factor itself, and therefore makes no sense.
		/// </summary>
		public FRawDistributionFloat TaperScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+TaperScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TaperScale__Offset, false);}
			
		}
		
		static readonly int RenderGeometry__Offset;
		/// <summary>Beam Rendering Variables.</summary>
		public bool RenderGeometry
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), RenderGeometry__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), RenderGeometry__Offset, 1,0,1,1);}
			
		}
		
		static readonly int RenderDirectLine__Offset;
		public bool RenderDirectLine
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), RenderDirectLine__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), RenderDirectLine__Offset, 1,0,2,2);}
			
		}
		
		static readonly int RenderLines__Offset;
		public bool RenderLines
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), RenderLines__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), RenderLines__Offset, 1,0,4,4);}
			
		}
		
		static readonly int RenderTessellation__Offset;
		public bool RenderTessellation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), RenderTessellation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), RenderTessellation__Offset, 1,0,8,8);}
			
		}
		
		static UParticleModuleTypeDataBeam2()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleTypeDataBeam2");
			BeamMethod__Offset=GetPropertyOffset(NativeClassPtr,"BeamMethod");
			TextureTile__Offset=GetPropertyOffset(NativeClassPtr,"TextureTile");
			TextureTileDistance__Offset=GetPropertyOffset(NativeClassPtr,"TextureTileDistance");
			Sheets__Offset=GetPropertyOffset(NativeClassPtr,"Sheets");
			MaxBeamCount__Offset=GetPropertyOffset(NativeClassPtr,"MaxBeamCount");
			Speed__Offset=GetPropertyOffset(NativeClassPtr,"Speed");
			InterpolationPoints__Offset=GetPropertyOffset(NativeClassPtr,"InterpolationPoints");
			bAlwaysOn__Offset=GetPropertyOffset(NativeClassPtr,"bAlwaysOn");
			UpVectorStepSize__Offset=GetPropertyOffset(NativeClassPtr,"UpVectorStepSize");
			BranchParentName__Offset=GetPropertyOffset(NativeClassPtr,"BranchParentName");
			Distance__Offset=GetPropertyOffset(NativeClassPtr,"Distance");
			TaperMethod__Offset=GetPropertyOffset(NativeClassPtr,"TaperMethod");
			TaperFactor__Offset=GetPropertyOffset(NativeClassPtr,"TaperFactor");
			TaperScale__Offset=GetPropertyOffset(NativeClassPtr,"TaperScale");
			RenderGeometry__Offset=GetPropertyOffset(NativeClassPtr,"RenderGeometry");
			RenderDirectLine__Offset=GetPropertyOffset(NativeClassPtr,"RenderDirectLine");
			RenderLines__Offset=GetPropertyOffset(NativeClassPtr,"RenderLines");
			RenderTessellation__Offset=GetPropertyOffset(NativeClassPtr,"RenderTessellation");
			
		}
		
	}
	
}
#endif
#endif
