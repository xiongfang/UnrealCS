#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A rich, editable float curve</summary>
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FRichCurve
	{
		/// <summary>Pre-infinity extrapolation state</summary>
		[FieldOffset(88)]
		public ERichCurveExtrapolation PreInfinityExtrap;
		/// <summary>Post-infinity extrapolation state</summary>
		[FieldOffset(89)]
		public ERichCurveExtrapolation PostInfinityExtrap;
		/// <summary>Default value</summary>
		[FieldOffset(92)]
		public float DefaultValue;
		/// <summary>Sorted array of keys</summary>
		public TStructArray<FRichCurveKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FRichCurveKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+96, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+96, false);}}}
			
		}
		/// <summary>Map of which key handles go to which indices.</summary>
		[FieldOffset(8)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
