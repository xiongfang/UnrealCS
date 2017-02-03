#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataBeam2
	{
		static readonly int BeamMethod__Offset;
		public EBeam2Method BeamMethod
		{
			get{ CheckIsValid();return (EBeam2Method)Marshal.PtrToStructure(_this.Get()+BeamMethod__Offset, typeof(EBeam2Method));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BeamMethod__Offset, false);}
			
		}
		
		static readonly int TextureTile__Offset;
		public int TextureTile
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+TextureTile__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextureTile__Offset, false);}
			
		}
		
		static readonly int TextureTileDistance__Offset;
		public float TextureTileDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TextureTileDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TextureTileDistance__Offset, false);}
			
		}
		
		static readonly int Sheets__Offset;
		public int Sheets
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+Sheets__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Sheets__Offset, false);}
			
		}
		
		static readonly int MaxBeamCount__Offset;
		public int MaxBeamCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxBeamCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxBeamCount__Offset, false);}
			
		}
		
		static readonly int Speed__Offset;
		public float Speed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Speed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Speed__Offset, false);}
			
		}
		
		static readonly int InterpolationPoints__Offset;
		public int InterpolationPoints
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+InterpolationPoints__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InterpolationPoints__Offset, false);}
			
		}
		
		static readonly int bAlwaysOn__Offset;
		public bool bAlwaysOn
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAlwaysOn__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAlwaysOn__Offset, 1,0,1,1);}
			
		}
		
		static readonly int UpVectorStepSize__Offset;
		public int UpVectorStepSize
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+UpVectorStepSize__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UpVectorStepSize__Offset, false);}
			
		}
		
		static readonly int BranchParentName__Offset;
		public FName BranchParentName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+BranchParentName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+BranchParentName__Offset, false);}
			
		}
		
		static readonly int Distance__Offset;
		public FRawDistributionFloat Distance
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+Distance__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Distance__Offset, false);}
			
		}
		
		static readonly int TaperMethod__Offset;
		public EBeamTaperMethod TaperMethod
		{
			get{ CheckIsValid();return (EBeamTaperMethod)Marshal.PtrToStructure(_this.Get()+TaperMethod__Offset, typeof(EBeamTaperMethod));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TaperMethod__Offset, false);}
			
		}
		
		static readonly int TaperFactor__Offset;
		public FRawDistributionFloat TaperFactor
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+TaperFactor__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TaperFactor__Offset, false);}
			
		}
		
		static readonly int TaperScale__Offset;
		public FRawDistributionFloat TaperScale
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+TaperScale__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TaperScale__Offset, false);}
			
		}
		
		static readonly int RenderGeometry__Offset;
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
