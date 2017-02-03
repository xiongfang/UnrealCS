#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct containing information about what interfaces are implemented in this blueprint</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FBPInterfaceDescription
	{
		/// <summary>Reference to the interface class we're adding to this blueprint</summary>
		/// <summary>References to the graphs associated with the required functions for this interface</summary>
		public TObjectArray<UEdGraph> Graphs
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UEdGraph>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+8, false);}}}
			
		}
		
	}
	
}
#endif
#endif
