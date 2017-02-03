#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Struct used for storing one per-instance named parameter for this AudioComponent.
	/// Certain nodes in the SoundCue may reference parameters by name so they can be adjusted per-instance.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FAudioComponentParam
	{
		/// <summary>Name of the parameter</summary>
		[FieldOffset(0)]
		public FName ParamName;
		/// <summary>Value of the parameter when used as a float</summary>
		[FieldOffset(12)]
		public float FloatParam;
		/// <summary>Value of the parameter when used as a boolean</summary>
		public bool BoolParam
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 16, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 16, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Value of the parameter when used as an integer</summary>
		[FieldOffset(20)]
		public int IntParam;
		/// <summary>Value of the parameter when used as a sound wave</summary>
		
	}
	
}
#endif
#endif
