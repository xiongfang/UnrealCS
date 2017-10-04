using System;
namespace UnrealEngine
{
	/// <summary>A struct used for caching part of a property path.  Don't use this class directly.</summary>
	public partial struct FPropertyPathSegment
	{
		/// <summary>The sub-component of the property path, a single value between .'s of the path</summary>
		public FName Name;
		/// <summary>The optional array index.</summary>
		public int ArrayIndex;
		/// <summary>The cached Class or ScriptStruct that was used last to resolve Name to a property.</summary>
		public UStruct Struct;
		/// <summary>
		/// The cached property on the Struct that this Name resolved to on it last time Resolve was called, if
		/// the Struct doesn't change, this value is returned to avoid performing another Field lookup.
		/// </summary>
		public UField Field;
		
	}
	
}
