#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FCompositeSubFont
	{
		/// <summary>Typeface data for this sub-font</summary>
		[FieldOffset(0)]
		public FTypeface Typeface;
		/// <summary>Array of character ranges for which this sub-font should be used</summary>
		public TStructArray<FInt32Range> CharacterRanges
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FInt32Range>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+16, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+16, false);}}}
			
		}
		/// <summary>Amount to scale this sub-font so that it better matches the size of the default font</summary>
		[FieldOffset(32)]
		public float ScalingFactor;
		/// <summary>Name of this sub-font. Only used by the editor UI as a convenience to let you state the purpose of the font family.</summary>
		[FieldOffset(36)]
		public FName EditorName;
		
	}
	
}
#endif
#endif
