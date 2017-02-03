#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure for custom channel setup information.</summary>
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FCustomChannelSetup
	{
		/// <summary>Which channel you'd like to customize *</summary>
		[FieldOffset(0)]
		public ECollisionChannel Channel;
		/// <summary>Name of channel you'd like to show up *</summary>
		[FieldOffset(4)]
		public FName Name;
		/// <summary>Default Response for the channel</summary>
		[FieldOffset(16)]
		public ECollisionResponse DefaultResponse;
		/// <summary>Sets meta data TraceType="1" for the enum entry if true. Otherwise, this channel will be treated as object query channel, so you can query object types*</summary>
		public bool bTraceType
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 17, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 17, 1, 0, 1, 255); } }}
			
		}
		/// <summary>Specifies if this is static object. Otherwise it will be dynamic object. This is used for query all objects vs all static objects vs all dynamic objects *</summary>
		public bool bStaticObject
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 18, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 18, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
