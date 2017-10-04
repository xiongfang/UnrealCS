using System;
namespace UnrealEngine
{
	/// <summary>Struct used to define the type of information carried on this pin</summary>
	public partial struct FEdGraphPinType
	{
		/// <summary>Category of pin type</summary>
		public FString PinCategory;
		/// <summary>Sub-category of pin type</summary>
		public FString PinSubCategory;
		/// <summary>Sub-category member reference</summary>
		public FSimpleMemberReference PinSubCategoryMemberReference;
		/// <summary>Data used to determine value types when bIsMap is true</summary>
		public FEdGraphTerminalType PinValueType;
		/// <summary>Whether or not this pin represents a map of keys to values</summary>
		public bool bIsMap;
		/// <summary>Whether or not this pin represents a set of (unique) values</summary>
		public bool bIsSet;
		/// <summary>Whether or not this pin represents an array of values</summary>
		public bool bIsArray;
		/// <summary>Whether or not this pin is a value passed by reference or not</summary>
		public bool bIsReference;
		/// <summary>Whether or not this pin is a immutable const value</summary>
		public bool bIsConst;
		/// <summary>Whether or not this is a weak reference</summary>
		public bool bIsWeakPointer;
		
	}
	
}
