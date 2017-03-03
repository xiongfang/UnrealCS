#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Container for the result of a projectile path trace (using PredictProjectilePath).</summary>
	[StructLayout(LayoutKind.Explicit,Size=176)]
	public partial struct FPredictProjectilePathResult
	{
		/// <summary>Info for each point on the path.</summary>
		public TStructArray<FPredictProjectilePathPointData> PathData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FPredictProjectilePathPointData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>Info on the last point we tried to trace to, which may have been beyond the final hit.</summary>
		[FieldOffset(16)]
		public FPredictProjectilePathPointData LastTraceDestination;
		/// <summary>Hit along the trace, if tracing with collision was enabled.</summary>
		[FieldOffset(44)]
		public FHitResult HitResult;
		
	}
	
}
#endif
#endif
