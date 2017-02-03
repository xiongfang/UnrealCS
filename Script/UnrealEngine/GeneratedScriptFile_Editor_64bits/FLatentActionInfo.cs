#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Latent action info</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FLatentActionInfo
	{
		/// <summary>The resume point within the function to execute</summary>
		[FieldOffset(0)]
		public int Linkage;
		/// <summary>the UUID for this action</summary>
		[FieldOffset(4)]
		public int UUID;
		/// <summary>The function to execute.</summary>
		[FieldOffset(8)]
		public FName ExecutionFunction;
		/// <summary>Object to execute the function on.</summary>
		
	}
	
}
#endif
#endif
