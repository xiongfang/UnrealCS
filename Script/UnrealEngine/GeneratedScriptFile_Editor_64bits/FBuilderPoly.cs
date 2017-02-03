#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Internal state, not accessible to script.</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FBuilderPoly
	{
		public TStructArray<int> VertexIndices
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		[FieldOffset(16)]
		public int Direction;
		[FieldOffset(20)]
		public FName ItemName;
		[FieldOffset(32)]
		public int PolyFlags;
		
	}
	
}
#endif
#endif
