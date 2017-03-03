#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpToMovementComponent
	{
		static readonly int Duration__Offset;
		public float Duration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Duration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Duration__Offset, false);}
			
		}
		
		static readonly int bPauseOnImpact__Offset;
		public bool bPauseOnImpact
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPauseOnImpact__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPauseOnImpact__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bForceSubStepping__Offset;
		public bool bForceSubStepping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceSubStepping__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceSubStepping__Offset, 1,0,1,1);}
			
		}
		
		static readonly int OnInterpToReverse__Offset;
		public FMulticastScriptDelegate OnInterpToReverse
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInterpToReverse__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInterpToReverse__Offset, false);}
			
		}
		
		static readonly int OnInterpToStop__Offset;
		public FMulticastScriptDelegate OnInterpToStop
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInterpToStop__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInterpToStop__Offset, false);}
			
		}
		
		static readonly int OnWaitBeginDelegate__Offset;
		public FMulticastScriptDelegate OnWaitBeginDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnWaitBeginDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnWaitBeginDelegate__Offset, false);}
			
		}
		
		static readonly int OnWaitEndDelegate__Offset;
		public FMulticastScriptDelegate OnWaitEndDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnWaitEndDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnWaitEndDelegate__Offset, false);}
			
		}
		
		static readonly int OnResetDelegate__Offset;
		public FMulticastScriptDelegate OnResetDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnResetDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnResetDelegate__Offset, false);}
			
		}
		
		static readonly int MaxSimulationTimeStep__Offset;
		public float MaxSimulationTimeStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSimulationTimeStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationTimeStep__Offset, false);}
			
		}
		
		static readonly int MaxSimulationIterations__Offset;
		public int MaxSimulationIterations
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSimulationIterations__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationIterations__Offset, false);}
			
		}
		
		static readonly int ControlPoints__Offset;
		public TStructArray<FInterpControlPoint> ControlPoints
		{
			get{ CheckIsValid();return new TStructArray<FInterpControlPoint>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ControlPoints__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ControlPoints__Offset, false);}
			
		}
		
		static UInterpToMovementComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpToMovementComponent");
			Duration__Offset=GetPropertyOffset(NativeClassPtr,"Duration");
			bPauseOnImpact__Offset=GetPropertyOffset(NativeClassPtr,"bPauseOnImpact");
			bForceSubStepping__Offset=GetPropertyOffset(NativeClassPtr,"bForceSubStepping");
			OnInterpToReverse__Offset=GetPropertyOffset(NativeClassPtr,"OnInterpToReverse");
			OnInterpToStop__Offset=GetPropertyOffset(NativeClassPtr,"OnInterpToStop");
			OnWaitBeginDelegate__Offset=GetPropertyOffset(NativeClassPtr,"OnWaitBeginDelegate");
			OnWaitEndDelegate__Offset=GetPropertyOffset(NativeClassPtr,"OnWaitEndDelegate");
			OnResetDelegate__Offset=GetPropertyOffset(NativeClassPtr,"OnResetDelegate");
			MaxSimulationTimeStep__Offset=GetPropertyOffset(NativeClassPtr,"MaxSimulationTimeStep");
			MaxSimulationIterations__Offset=GetPropertyOffset(NativeClassPtr,"MaxSimulationIterations");
			ControlPoints__Offset=GetPropertyOffset(NativeClassPtr,"ControlPoints");
			
		}
		
	}
	
}
#endif
#endif
