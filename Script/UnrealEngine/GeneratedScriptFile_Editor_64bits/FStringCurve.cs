#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Implements a curve of FStrings.</summary>
	[StructLayout(LayoutKind.Explicit,Size=120)]
	public partial struct FStringCurve
	{
		/// <summary>Default value</summary>
		[FieldOffset(88)]
		public FString DefaultValue;
		/// <summary>Sorted array of keys</summary>
		public TStructArray<FStringCurveKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FStringCurveKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+104, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+104, false);}}}
			
		}
		/// <summary>Map of which key handles go to which indices.</summary>
		[FieldOffset(8)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
