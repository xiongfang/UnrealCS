#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UFloatingPawnMovement
	{
		static readonly int MaxSpeed__Offset;
		public float MaxSpeed
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSpeed__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSpeed__Offset, false);}
			
		}
		
		static readonly int Acceleration__Offset;
		public float Acceleration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Acceleration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Acceleration__Offset, false);}
			
		}
		
		static readonly int Deceleration__Offset;
		public float Deceleration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Deceleration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Deceleration__Offset, false);}
			
		}
		
		static readonly int TurningBoost__Offset;
		public float TurningBoost
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+TurningBoost__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+TurningBoost__Offset, false);}
			
		}
		
		static readonly int bPositionCorrected__Offset;
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
