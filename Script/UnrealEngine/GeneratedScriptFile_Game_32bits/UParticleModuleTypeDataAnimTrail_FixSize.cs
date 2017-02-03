#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataAnimTrail
	{
		static readonly int bDeadTrailsOnDeactivate__Offset;
		public bool bDeadTrailsOnDeactivate
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bDeadTrailsOnDeactivate__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bDeadTrailsOnDeactivate__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bEnablePreviousTangentRecalculation__Offset;
		public bool bEnablePreviousTangentRecalculation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePreviousTangentRecalculation__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePreviousTangentRecalculation__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bTangentRecalculationEveryFrame__Offset;
		public bool bTangentRecalculationEveryFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTangentRecalculationEveryFrame__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTangentRecalculationEveryFrame__Offset, 1,0,4,4);}
			
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
		
		static readonly int TangentTessellationStepSize__Offset;
		public float TangentTessellationStepSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TangentTessellationStepSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TangentTessellationStepSize__Offset, false);}
			
		}
		
		static readonly int WidthTessellationStepSize__Offset;
		public float WidthTessellationStepSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+WidthTessellationStepSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WidthTessellationStepSize__Offset, false);}
			
		}
		
		static UParticleModuleTypeDataAnimTrail()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleTypeDataAnimTrail");
			bDeadTrailsOnDeactivate__Offset=GetPropertyOffset(NativeClassPtr,"bDeadTrailsOnDeactivate");
			bEnablePreviousTangentRecalculation__Offset=GetPropertyOffset(NativeClassPtr,"bEnablePreviousTangentRecalculation");
			bTangentRecalculationEveryFrame__Offset=GetPropertyOffset(NativeClassPtr,"bTangentRecalculationEveryFrame");
			TilingDistance__Offset=GetPropertyOffset(NativeClassPtr,"TilingDistance");
			DistanceTessellationStepSize__Offset=GetPropertyOffset(NativeClassPtr,"DistanceTessellationStepSize");
			TangentTessellationStepSize__Offset=GetPropertyOffset(NativeClassPtr,"TangentTessellationStepSize");
			WidthTessellationStepSize__Offset=GetPropertyOffset(NativeClassPtr,"WidthTessellationStepSize");
			
		}
		
	}
	
}
#endif
#endif
