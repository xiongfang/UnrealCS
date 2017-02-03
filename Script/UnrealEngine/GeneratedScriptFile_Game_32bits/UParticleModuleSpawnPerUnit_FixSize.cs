#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSpawnPerUnit
	{
		static readonly int UnitScalar__Offset;
		public float UnitScalar
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UnitScalar__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UnitScalar__Offset, false);}
			
		}
		
		static readonly int SpawnPerUnit__Offset;
		public FRawDistributionFloat SpawnPerUnit
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+SpawnPerUnit__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpawnPerUnit__Offset, false);}
			
		}
		
		static readonly int bIgnoreSpawnRateWhenMoving__Offset;
		public bool bIgnoreSpawnRateWhenMoving
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreSpawnRateWhenMoving__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreSpawnRateWhenMoving__Offset, 1,0,1,1);}
			
		}
		
		static readonly int MovementTolerance__Offset;
		public float MovementTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTolerance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MovementTolerance__Offset, false);}
			
		}
		
		static readonly int MaxFrameDistance__Offset;
		public float MaxFrameDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxFrameDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxFrameDistance__Offset, false);}
			
		}
		
		static readonly int bIgnoreMovementAlongX__Offset;
		public bool bIgnoreMovementAlongX
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreMovementAlongX__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreMovementAlongX__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIgnoreMovementAlongY__Offset;
		public bool bIgnoreMovementAlongY
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreMovementAlongY__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreMovementAlongY__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bIgnoreMovementAlongZ__Offset;
		public bool bIgnoreMovementAlongZ
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreMovementAlongZ__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreMovementAlongZ__Offset, 1,0,4,4);}
			
		}
		
		static UParticleModuleSpawnPerUnit()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ParticleModuleSpawnPerUnit");
			UnitScalar__Offset=GetPropertyOffset(NativeClassPtr,"UnitScalar");
			SpawnPerUnit__Offset=GetPropertyOffset(NativeClassPtr,"SpawnPerUnit");
			bIgnoreSpawnRateWhenMoving__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreSpawnRateWhenMoving");
			MovementTolerance__Offset=GetPropertyOffset(NativeClassPtr,"MovementTolerance");
			MaxFrameDistance__Offset=GetPropertyOffset(NativeClassPtr,"MaxFrameDistance");
			bIgnoreMovementAlongX__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreMovementAlongX");
			bIgnoreMovementAlongY__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreMovementAlongY");
			bIgnoreMovementAlongZ__Offset=GetPropertyOffset(NativeClassPtr,"bIgnoreMovementAlongZ");
			
		}
		
	}
	
}
#endif
#endif
