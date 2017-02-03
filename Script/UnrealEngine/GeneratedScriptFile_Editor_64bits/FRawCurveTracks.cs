#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Raw Curve data for serialization</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FRawCurveTracks
	{
		public TStructArray<FFloatCurve> FloatCurves
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FFloatCurve>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>
		/// @note : Currently VectorCurves are not evaluated or used for anything else but transient data for modifying bone track
		///                      Note that it doesn't have UPROPERTY tag yet. In the future, we'd like this to be serialized, but not for now
		/// </summary>
		public TStructArray<FVectorCurve> VectorCurves
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FVectorCurve>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>@note : TransformCurves are used to edit additive animation in editor.</summary>
		public TStructArray<FTransformCurve> TransformCurves
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FTransformCurve>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
