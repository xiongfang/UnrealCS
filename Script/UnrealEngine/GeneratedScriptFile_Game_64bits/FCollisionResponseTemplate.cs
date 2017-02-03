#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=96)]
	public partial struct FCollisionResponseTemplate
	{
		[FieldOffset(0)]
		public FName Name;
		[FieldOffset(8)]
		public ECollisionEnabled CollisionEnabled;
		[FieldOffset(16)]
		public FName ObjectTypeName;
		public TStructArray<FResponseChannel> CustomResponses
		{
						get{ unsafe { fixed (void* p = &this) { return new TStructArray<FResponseChannel>((FScriptArray)Marshal.PtrToStructure(new IntPtr(p)+24, typeof(FScriptArray)));}}}
						set{ unsafe { fixed (void* p = &this) { Marshal.StructureToPtr(value.InterArray, new IntPtr(p)+24, false);}}}
			
		}
		[FieldOffset(40)]
		public FString HelpMessage;
		public bool bCanModify
		{
			get{ unsafe { fixed (void* p = &this) { return BoolWrap.Get(new IntPtr(p), 56, 1, 0, 1, 255); } }}
			set{unsafe { fixed (void* p = &this) { BoolWrap.Set(value, new IntPtr(p), 56, 1, 0, 1, 255); } }}
			
		}
		
	}
	
}
#endif
#endif
