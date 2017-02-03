#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FFontData
	{
		[FieldOffset(0)]
		public FString FontFilename;
		[FieldOffset(24)]
		public EFontHinting Hinting;
		public TStructArray<byte> FontData
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<byte>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		
	}
	
}
#endif
#endif
