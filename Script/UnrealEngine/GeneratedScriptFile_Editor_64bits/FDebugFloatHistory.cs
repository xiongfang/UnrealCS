#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure for recording float values and displaying them as an Histogram through DrawDebugFloatHistory.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FDebugFloatHistory
	{
		/// <summary>Samples</summary>
		public TStructArray<float> Samples
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+0, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+0, false);}}}
			
		}
		/// <summary>Max Samples to record.</summary>
		[FieldOffset(16)]
		public float MaxSamples;
		/// <summary>Min value to record.</summary>
		[FieldOffset(20)]
		public float MinValue;
		/// <summary>Max value to record.</summary>
		[FieldOffset(24)]
		public float MaxValue;
		/// <summary>Auto adjust Min/Max as new values are recorded?</summary>
		public bool bAutoAdjustMinMax
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 28, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 28, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
