#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=184)]
	public partial struct FPredictProjectilePathResult
	{
		public TStructArray<FPredictProjectilePathPointData> PathData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FPredictProjectilePathPointData>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		[FieldOffset(16)]
		public FPredictProjectilePathPointData LastTraceDestination;
		[FieldOffset(48)]
		public FHitResult HitResult;
		
	}
	
}
#endif
#endif
