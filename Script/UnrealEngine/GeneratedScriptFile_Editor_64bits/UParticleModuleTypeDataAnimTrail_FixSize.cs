#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleTypeDataAnimTrail
	{
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
		
		static readonly int bEnablePreviousTangentRecalculation__Offset;
		/// <summary>If true, recalculate the previous tangent when a new particle is spawned</summary>
		public bool bEnablePreviousTangentRecalculation
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEnablePreviousTangentRecalculation__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bEnablePreviousTangentRecalculation__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bTangentRecalculationEveryFrame__Offset;
		/// <summary>If true, recalculate tangents every frame to allow velocity/acceleration to be applied</summary>
		public bool bTangentRecalculationEveryFrame
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTangentRecalculationEveryFrame__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTangentRecalculationEveryFrame__Offset, 1,0,4,4);}
			
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
		/// # Tessellation Points = TruncToInt((Distance Between Spawned Particles) / DistanceTessellationStepSize)). If 0 then there is no distance tessellation.
		/// </summary>
		public float DistanceTessellationStepSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+DistanceTessellationStepSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DistanceTessellationStepSize__Offset, false);}
			
		}
		
		static readonly int TangentTessellationStepSize__Offset;
		/// <summary>
		/// The tangent scalar for tessellation.
		/// This is the degree change in the tangent direction [0...180] required to warrant an additional tessellation point. If 0 then there is no tangent tessellation.
		/// </summary>
		public float TangentTessellationStepSize
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TangentTessellationStepSize__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TangentTessellationStepSize__Offset, false);}
			
		}
		
		static readonly int WidthTessellationStepSize__Offset;
		/// <summary>
		/// The width step size for tessellation.
		/// This is the number of world units change in the width required to warrant an additional tessellation point. If 0 then there is no width tessellation.
		/// </summary>
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
