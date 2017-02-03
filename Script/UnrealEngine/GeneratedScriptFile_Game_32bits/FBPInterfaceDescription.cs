#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FBPInterfaceDescription
	{
		public TObjectArray<UEdGraph> Graphs
		{
						get{ unsafe { fixed (void* p = &this) { return new TObjectArray<UEdGraph>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+4, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray,new IntPtr(p)+4, false);}}}
			
		}
		
	}
	
}
#endif
#endif
