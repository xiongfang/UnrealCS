using System;
namespace UnrealEngine
{
	/// <summary>
	/// Struct used to define information for terminal types, e.g. types that can be contained
	/// by a container. Currently can represent strong/weak references to a type (only UObjects),
	/// a structure, or a primitive. Support for "Container of Containers" is done by wrapping
	/// a structure, rather than implicitly defining names for containers.
	/// </summary>
	public partial struct FEdGraphTerminalType
	{
		/// <summary>Category</summary>
		public FString TerminalCategory;
		/// <summary>Sub-category</summary>
		public FString TerminalSubCategory;
		/// <summary>Whether or not this pin is a immutable const value</summary>
		public bool bTerminalIsConst;
		/// <summary>Whether or not this is a weak reference</summary>
		public bool bTerminalIsWeakPointer;
		
	}
	
}
