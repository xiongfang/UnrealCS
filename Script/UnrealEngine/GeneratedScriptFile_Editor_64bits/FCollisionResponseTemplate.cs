#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure for collision response templates.</summary>
	[StructLayout(LayoutKind.Explicit,Size=104)]
	public partial struct FCollisionResponseTemplate
	{
		[FieldOffset(0)]
		public FName Name;
		[FieldOffset(12)]
		public ECollisionEnabled CollisionEnabled;
		[FieldOffset(16)]
		public FName ObjectTypeName;
		/// <summary>Types of objects that this physics objects will collide with.</summary>
		public TStructArray<FResponseChannel> CustomResponses
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FResponseChannel>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+32, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+32, false);}}}
			
		}
		/// <summary>Help message for collision profile *</summary>
		[FieldOffset(48)]
		public FString HelpMessage;
		/// <summary>Help message for collision profile *</summary>
		public bool bCanModify
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 64, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 64, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
