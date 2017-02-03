#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// FloatingPawnMovement is a movement component that provides simple movement for any Pawn class.
	/// Limits on speed and acceleration are provided, while gravity is not implemented.
	/// Normally the root component of the owning actor is moved, however another component may be selected (see SetUpdatedComponent()).
	/// During swept (non-teleporting) movement only collision of UpdatedComponent is considered, attached components will teleport to the end location ignoring collision.
	/// </summary>
	public partial class UFloatingPawnMovement
	{
		static readonly int MaxSpeed__Offset;
		/// <summary>Maximum velocity magnitude allowed for the controlled Pawn.</summary>
		public float MaxSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSpeed__Offset, false);}
			
		}
		
		static readonly int Acceleration__Offset;
		/// <summary>Acceleration applied by input (rate of change of velocity)</summary>
		public float Acceleration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Acceleration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Acceleration__Offset, false);}
			
		}
		
		static readonly int Deceleration__Offset;
		/// <summary>Deceleration applied when there is no input (rate of change of velocity)</summary>
		public float Deceleration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Deceleration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Deceleration__Offset, false);}
			
		}
		
		static readonly int TurningBoost__Offset;
		/// <summary>
		/// Setting affecting extra force applied when changing direction, making turns have less drift and become more responsive.
		/// Velocity magnitude is not allowed to increase, that only happens due to normal acceleration. It may decrease with large direction changes.
		/// Larger values apply extra force to reach the target direction more quickly, while a zero value disables any extra turn force.
		/// </summary>
		public float TurningBoost
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TurningBoost__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TurningBoost__Offset, false);}
			
		}
		
		static readonly int bPositionCorrected__Offset;
		/// <summary>Set to true when a position correction is applied. Used to avoid recalculating velocity when this occurs.</summary>
		public bool bPositionCorrected
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPositionCorrected__Offset, 1, 0, 1, 1);}
			
		}
		
		static UFloatingPawnMovement()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("FloatingPawnMovement");
			MaxSpeed__Offset=GetPropertyOffset(NativeClassPtr,"MaxSpeed");
			Acceleration__Offset=GetPropertyOffset(NativeClassPtr,"Acceleration");
			Deceleration__Offset=GetPropertyOffset(NativeClassPtr,"Deceleration");
			TurningBoost__Offset=GetPropertyOffset(NativeClassPtr,"TurningBoost");
			bPositionCorrected__Offset=GetPropertyOffset(NativeClassPtr,"bPositionCorrected");
			
		}
		
	}
	
}
#endif
#endif
