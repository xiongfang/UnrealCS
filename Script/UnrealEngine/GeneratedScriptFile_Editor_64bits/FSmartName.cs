#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FSmartName
	{
		/// <summary>name</summary>
		[FieldOffset(0)]
		public FName DisplayName;
		[FieldOffset(16)]
		public FGuid Guid;
		
	}
	
}
#endif
#endif
