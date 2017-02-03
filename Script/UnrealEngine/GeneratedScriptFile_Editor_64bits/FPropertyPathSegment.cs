#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A struct used for caching part of a property path.  Don't use this class directly.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FPropertyPathSegment
	{
		/// <summary>The sub-component of the property path, a single value between .'s of the path</summary>
		[FieldOffset(0)]
		public FName Name;
		/// <summary>The optional array index.</summary>
		[FieldOffset(12)]
		public int ArrayIndex;
		/// <summary>The cached Class or ScriptStruct that was used last to resolve Name to a property.</summary>
		/// <summary>
		/// The cached property on the Struct that this Name resolved to on it last time Resolve was called, if
		/// the Struct doesn't change, this value is returned to avoid performing another Field lookup.
		/// </summary>
		
	}
	
}
#endif
#endif
