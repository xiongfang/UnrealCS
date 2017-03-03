#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>LOD specific setup for the skeletal mesh component.</summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FSkelMeshComponentLODInfo
	{
		/// <summary>Material corresponds to section. To show/hide each section, use this.</summary>
		public TStructArray<bool> HiddenMaterials
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<bool>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		
	}
	
}
#endif
#endif
