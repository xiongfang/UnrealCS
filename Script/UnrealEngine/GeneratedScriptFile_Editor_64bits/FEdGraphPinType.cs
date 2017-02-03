#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Struct used to define the type of information carried on this pin</summary>
	[StructLayout(LayoutKind.Explicit,Size=88)]
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
		/// <summary>Whether or not this pin represents an array of values</summary>
		public bool bIsArray
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 80, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 80, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not this pin is a value passed by reference or not</summary>
		public bool bIsReference
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 81, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 81, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not this pin is a immutable const value</summary>
		public bool bIsConst
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 82, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 82, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Whether or not this is a weak reference</summary>
		public bool bIsWeakPointer
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 83, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 83, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
