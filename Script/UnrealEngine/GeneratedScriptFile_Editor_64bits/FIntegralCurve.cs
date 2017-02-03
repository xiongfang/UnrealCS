#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>An integral curve, which holds the key time and the key value</summary>
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FIntegralCurve
	{
		/// <summary>The keys, ordered by time</summary>
		public TStructArray<FIntegralKey> Keys
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FIntegralKey>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+88, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+88, false);}}}
			
		}
		/// <summary>Default value</summary>
		[FieldOffset(104)]
		public int DefaultValue;
		public bool bUseDefaultValueBeforeFirstKey
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 108, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 108, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Map of which key handles go to which indices.</summary>
		[FieldOffset(8)]
		public FKeyHandleMap KeyHandlesToIndices;
		
	}
	
}
#endif
#endif
