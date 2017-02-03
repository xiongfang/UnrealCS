#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataRibbon
	{
		static readonly int MaxTessellationBetweenParticles__Offset;
		public int MaxTessellationBetweenParticles
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxTessellationBetweenParticles__Offset, typeof(int));}
			
		}
		
		static readonly int SheetsPerTrail__Offset;
		public int SheetsPerTrail
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+SheetsPerTrail__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SheetsPerTrail__Offset, false);}
			
		}
		
		static readonly int MaxTrailCount__Offset;
		public int MaxTrailCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxTrailCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxTrailCount__Offset, false);}
			
		}
		
		static readonly int MaxParticleInTrailCount__Offset;
		public int MaxParticleInTrailCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxParticleInTrailCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxParticleInTrailCount__Offset, false);}
			
		}
		
		static readonly int bDeadTrailsOnDeactivate__Offset;
		public bool bDeadTrailsOnDeactivate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDeadTrailsOnDeactivate__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDeadTrailsOnDeactivate__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bDeadTrailsOnSourceLoss__Offset;
		public bool bDeadTrailsOnSourceLoss
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDeadTrailsOnSourceLoss__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDeadTrailsOnSourceLoss__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bClipSourceSegement__Offset;
		public bool bClipSourceSegement
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bClipSourceSegement__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bClipSourceSegement__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bEnablePreviousTangentRecalculation__Offset;
		public bool bEnablePreviousTangentRecalculation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePreviousTangentRecalculation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePreviousTangentRecalculation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bTangentRecalculationEveryFrame__Offset;
		public bool bTangentRecalculationEveryFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTangentRecalculationEveryFrame__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTangentRecalculationEveryFrame__Offset, 1,0,16,16);}
			
		}
		
		static readonly int bSpawnInitialParticle__Offset;
		public bool bSpawnInitialParticle
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSpawnInitialParticle__Offset, 1, 0, 32, 32);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSpawnInitialParticle__Offset, 1,0,32,32);}
			
		}
		
		static readonly int RenderAxis__Offset;
		public ETrailsRenderAxisOption RenderAxis
		{
			get{ CheckIsValid();return (ETrailsRenderAxisOption)Marshal.PtrToStructure(_this.Get()+RenderAxis__Offset, typeof(ETrailsRenderAxisOption));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+RenderAxis__Offset, false);}
			
		}
		
		static readonly int TangentSpawningScalar__Offset;
		public float TangentSpawningScalar
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TangentSpawningScalar__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TangentSpawningScalar__Offset, false);}
			
		}
		
		static readonly int bRenderGeometry__Offset;
		public bool bRenderGeometry
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderGeometry__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderGeometry__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bRenderSpawnPoints__Offset;
		public bool bRenderSpawnPoints
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderSpawnPoints__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderSpawnPoints__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bRenderTangents__Offset;
		public bool bRenderTangents
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderTangents__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderTangents__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bRenderTessellation__Offset;
		public bool bRenderTessellation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bRenderTessellation__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bRenderTessellation__Offset, 1,0,8,8);}
			
		}
		
		static readonly int TilingDistance__Offset;
		public float TilingDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TilingDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TilingDistance__Offset, false);}
			
		}
		
		static readonly int DistanceTessellationStepSize__Offset;
		public float DistanceTessellationStepSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceTessellationStepSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceTessellationStepSize__Offset, false);}
			
		}
		
		static readonly int bEnableTangentDiffInterpScale__Offset;
		public bool bEnableTangentDiffInterpScale
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnableTangentDiffInterpScale__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnableTangentDiffInterpScale__Offset, 1,0,1,1);}
			
		}
		
		static readonly int TangentTessellationScalar__Offset;
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
