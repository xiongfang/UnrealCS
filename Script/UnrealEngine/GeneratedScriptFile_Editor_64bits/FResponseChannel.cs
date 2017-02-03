#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FResponseChannel
	{
		/// <summary>
		/// This should match DisplayName of ECollisionChannel
		///     Meta data of custom channels can be used as well
		/// </summary>
		[FieldOffset(0)]
		public FName Channel;
		[FieldOffset(12)]
		public ECollisionResponse Response;
		
	}
	
}
#endif
#endif
