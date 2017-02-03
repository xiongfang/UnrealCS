#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>This defines what constraint it is defined</summary>
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FTransformBaseConstraint
	{
		/// <summary>What transform type *</summary>
		public TStructArray<FRigTransformConstraint> TransformConstraints
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FRigTransformConstraint>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
