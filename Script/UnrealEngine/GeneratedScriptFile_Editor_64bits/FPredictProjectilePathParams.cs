#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Input parameters to PredictProjectilePath functions.</summary>
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FPredictProjectilePathParams
	{
		/// <summary>Location of the start of the trace.</summary>
		[FieldOffset(0)]
		public FVector StartLocation;
		/// <summary>Initial launch velocity at the start of the trace.</summary>
		[FieldOffset(12)]
		public FVector LaunchVelocity;
		/// <summary>Whether to trace along the path looking for blocking collision and stopping at the first hit.</summary>
		public bool bTraceWithCollision
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 24, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 24, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Projectile radius, used when tracing for collision. If <= 0, a line trace is used instead.</summary>
		[FieldOffset(28)]
		public float ProjectileRadius;
		/// <summary>Maximum simulation time for the virtual projectile.</summary>
		[FieldOffset(32)]
		public float MaxSimTime;
		/// <summary>Whether or not to use TraceChannel, if tracing with collision.</summary>
		public bool bTraceWithChannel
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 36, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 36, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Trace channel to use, if tracing with collision.</summary>
		[FieldOffset(37)]
		public ECollisionChannel TraceChannel;
		/// <summary>Object type to use, if tracing with collision.</summary>
		public TStructArray<EObjectTypeQuery> ObjectTypes
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<EObjectTypeQuery>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+40, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+40, false);}}}
			
		}
		/// <summary>Actors to ignore when tracing with collision.</summary>
		public TObjectArray<AActor> ActorsToIgnore
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<AActor>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+56, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+56, false);}}}
			
		}
		/// <summary>Determines size of each sub-step in the simulation (chopping up MaxSimTime). Recommended between 10 to 30 depending on desired quality versus performance.</summary>
		[FieldOffset(72)]
		public float SimFrequency;
		/// <summary>Optional override of Gravity (if 0, uses WorldGravityZ).</summary>
		[FieldOffset(76)]
		public float OverrideGravityZ;
		/// <summary>Debug drawing duration option.</summary>
		[FieldOffset(80)]
		public EDrawDebugTrace DrawDebugType;
		/// <summary>Duration of debug lines (only relevant for DrawDebugType::Duration)</summary>
		[FieldOffset(84)]
		public float DrawDebugTime;
		/// <summary>Trace against complex collision (triangles rather than simple primitives) if tracing with collision.</summary>
		public bool bTraceComplex
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 88, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 88, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
