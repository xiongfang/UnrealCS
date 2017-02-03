#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Rig Controller for bone transform *</summary>
	[StructLayout(LayoutKind.Explicit,Size=112)]
	public partial struct FNode
	{
		/// <summary>Name of the original node. We don't allow to change this. This is used for identity.*</summary>
		[FieldOffset(0)]
		public FName Name;
		/// <summary>We save Parent Node but if the parent node is removed, it will reset to root</summary>
		[FieldOffset(12)]
		public FName ParentName;
		/// <summary>Absolute transform of the node. Hoping to use this data in the future to render</summary>
		[FieldOffset(32)]
		public FTransform Transform;
		/// <summary>This is Display Name where it will be used to display in Retarget Manager. This name has to be unique.</summary>
		[FieldOffset(80)]
		public FString DisplayName;
		public bool bAdvanced
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 96, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 96, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
