#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UParticleModuleSpawnPerUnit
	{
		static readonly int UnitScalar__Offset;
		/// <summary>
		/// The scalar to apply to the distance traveled.
		/// The value from SpawnPerUnit is divided by this value to give the actual
		/// number of particles per unit.
		/// </summary>
		public float UnitScalar
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+UnitScalar__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+UnitScalar__Offset, false);}
			
		}
		
		static readonly int SpawnPerUnit__Offset;
		/// <summary>
		/// The amount to spawn per meter distribution.
		/// The value is retrieved using the EmitterTime.
		/// </summary>
		public FRawDistributionFloat SpawnPerUnit
		{
			get{ CheckIsValid();return (FRawDistributionFloat)Marshal.PtrToStructure(_this.Get()+SpawnPerUnit__Offset, typeof(FRawDistributionFloat));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SpawnPerUnit__Offset, false);}
			
		}
		
		static readonly int bIgnoreSpawnRateWhenMoving__Offset;
		/// <summary>
		/// If true, process the default spawn rate when not moving...
		/// When not moving, skip the default spawn rate.
		/// If false, return the bProcessSpawnRate setting.
		/// </summary>
		public bool bIgnoreSpawnRateWhenMoving
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreSpawnRateWhenMoving__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreSpawnRateWhenMoving__Offset, 1,0,1,1);}
			
		}
		
		static readonly int MovementTolerance__Offset;
		/// <summary>
		/// The tolerance for moving vs. not moving w.r.t. the bIgnoreSpawnRateWhenMoving flag.
		/// Ie, if (DistanceMoved < (UnitScalar x MovementTolerance)) then consider it not moving.
		/// </summary>
		public float MovementTolerance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MovementTolerance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MovementTolerance__Offset, false);}
			
		}
		
		static readonly int MaxFrameDistance__Offset;
		/// <summary>
		/// The maximum valid movement for a single frame.
		/// If 0.0, then the check is not performed.
		/// Currently, if the distance moved between frames is greater than this
		/// then NO particles will be spawned.
		/// This is primiarily intended to cover cases where the PSystem is
		/// attached to teleporting objects.
		/// </summary>
		public float MaxFrameDistance
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxFrameDistance__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxFrameDistance__Offset, false);}
			
		}
		
		static readonly int bIgnoreMovementAlongX__Offset;
		/// <summary>If true, ignore the X-component of the movement</summary>
		public bool bIgnoreMovementAlongX
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreMovementAlongX__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreMovementAlongX__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bIgnoreMovementAlongY__Offset;
		/// <summary>If true, ignore the Y-component of the movement</summary>
		public bool bIgnoreMovementAlongY
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bIgnoreMovementAlongY__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bIgnoreMovementAlongY__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bIgnoreMovementAlongZ__Offset;
		/// <summary>If true, ignore the Z-component of the movement</summary>
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
