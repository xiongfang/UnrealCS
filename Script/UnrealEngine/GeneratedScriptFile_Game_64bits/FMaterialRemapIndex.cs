#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FMaterialRemapIndex
	{
		[FieldOffset(0)]
		public uint ImportVersionKey;
		public TStructArray<int> MaterialRemap
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<int>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+8, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+8, false);}}}
			
		}
		
	}
	
}
#endif
#endif
