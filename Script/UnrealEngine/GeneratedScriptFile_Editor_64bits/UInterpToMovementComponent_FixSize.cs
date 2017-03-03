#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Move the root component between a series of points over a given time *
	/// @see UMovementComponent
	/// </summary>
	public partial class UInterpToMovementComponent
	{
		static readonly int Duration__Offset;
		/// <summary>How long to take to move from the first point to the last (or vice versa)</summary>
		public float Duration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Duration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Duration__Offset, false);}
			
		}
		
		static readonly int bPauseOnImpact__Offset;
		/// <summary>If true, will pause movement on impact. If false it will behave as if the end of the movement range was reached based on the BehaviourType.</summary>
		public bool bPauseOnImpact
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPauseOnImpact__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPauseOnImpact__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bForceSubStepping__Offset;
		/// <summary>
		/// If true, forces sub-stepping to break up movement into discrete smaller steps to improve accuracy of the trajectory.
		/// Objects that move in a straight line typically do *not* need to set this, as movement always uses continuous collision detection (sweeps) so collision is not missed.
		/// Sub-stepping is automatically enabled when under the effects of gravity or when homing towards a target.
		/// @see MaxSimulationTimeStep, MaxSimulationIterations
		/// </summary>
		public bool bForceSubStepping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bForceSubStepping__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bForceSubStepping__Offset, 1,0,1,1);}
			
		}
		
		static readonly int OnInterpToReverse__Offset;
		/// <summary>Called when InterpTo impacts something and reverse is enabled.</summary>
		public FMulticastScriptDelegate OnInterpToReverse
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInterpToReverse__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInterpToReverse__Offset, false);}
			
		}
		
		static readonly int OnInterpToStop__Offset;
		/// <summary>Called when InterpTo has come to a stop.</summary>
		public FMulticastScriptDelegate OnInterpToStop
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnInterpToStop__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnInterpToStop__Offset, false);}
			
		}
		
		static readonly int OnWaitBeginDelegate__Offset;
		/// <summary>Called when InterpTo has come to a stop but will resume when possible.</summary>
		public FMulticastScriptDelegate OnWaitBeginDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnWaitBeginDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnWaitBeginDelegate__Offset, false);}
			
		}
		
		static readonly int OnWaitEndDelegate__Offset;
		/// <summary>Called when InterpTo has resumed following a stop.</summary>
		public FMulticastScriptDelegate OnWaitEndDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnWaitEndDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnWaitEndDelegate__Offset, false);}
			
		}
		
		static readonly int OnResetDelegate__Offset;
		/// <summary>Called when InterpTo reached the end and reset back to start .</summary>
		public FMulticastScriptDelegate OnResetDelegate
		{
			get{ CheckIsValid(); return ((FMulticastScriptDelegate)Marshal.PtrToStructure(_this.Get()+OnResetDelegate__Offset, typeof(FMulticastScriptDelegate)));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+OnResetDelegate__Offset, false);}
			
		}
		
		static readonly int MaxSimulationTimeStep__Offset;
		/// <summary>
		/// Max time delta for each discrete simulation step.
		/// Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationIterations, bForceSubStepping
		/// </summary>
		public float MaxSimulationTimeStep
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+MaxSimulationTimeStep__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationTimeStep__Offset, false);}
			
		}
		
		static readonly int MaxSimulationIterations__Offset;
		/// <summary>
		/// Max number of iterations used for each discrete simulation step.
		/// Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// @see MaxSimulationTimeStep, bForceSubStepping
		/// </summary>
		public int MaxSimulationIterations
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MaxSimulationIterations__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MaxSimulationIterations__Offset, false);}
			
		}
		
		static readonly int ControlPoints__Offset;
		/// <summary>List of control points to visit.</summary>
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
