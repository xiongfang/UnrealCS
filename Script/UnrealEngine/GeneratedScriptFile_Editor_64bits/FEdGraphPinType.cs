#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct used to define the type of information carried on this pin</summary>
	[StructLayout(LayoutKind.Explicit,Size=136)]
	public partial struct FEdGraphPinType
	{
		/// <summary>Category of pin type</summary>
		[FieldOffset(0)]
		public FString PinCategory;
		/// <summary>Sub-category of pin type</summary>
		[FieldOffset(16)]
		public FString PinSubCategory;
		/// <summary>Sub-category member reference</summary>
		[FieldOffset(40)]
		public FSimpleMemberReference PinSubCategoryMemberReference;
		/// <summary>Data used to determine value types when bIsMap is true</summary>
		[FieldOffset(80)]
		public FEdGraphTerminalType PinValueType;
		/// <summary>Whether or not this pin represents a map of keys to values</summary>
		public bool bIsMap
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 128, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 128, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not this pin represents a set of (unique) values</summary>
		public bool bIsSet
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 129, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 129, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not this pin represents an array of values</summary>
		public bool bIsArray
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 130, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 130, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not this pin is a value passed by reference or not</summary>
		public bool bIsReference
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 131, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 131, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not this pin is a immutable const value</summary>
		public bool bIsConst
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 132, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 132, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not this is a weak reference</summary>
		public bool bIsWeakPointer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 133, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 133, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
