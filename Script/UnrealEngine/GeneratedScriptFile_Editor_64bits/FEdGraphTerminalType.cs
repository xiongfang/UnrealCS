#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Struct used to define information for terminal types, e.g. types that can be contained
	/// by a container. Currently can represent strong/weak references to a type (only UObjects),
	/// a structure, or a primitive. Support for "Container of Containers" is done by wrapping
	/// a structure, rather than implicitly defining names for containers.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FEdGraphTerminalType
	{
		/// <summary>Category</summary>
		[FieldOffset(0)]
		public FString TerminalCategory;
		/// <summary>Sub-category</summary>
		[FieldOffset(16)]
		public FString TerminalSubCategory;
		/// <summary>Whether or not this pin is a immutable const value</summary>
		public bool bTerminalIsConst
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 40, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 40, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not this is a weak reference</summary>
		public bool bTerminalIsWeakPointer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 41, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 41, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
