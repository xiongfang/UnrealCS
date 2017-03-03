#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Alpha Blend class that supports different blend options as well as custom curves</summary>
	[StructLayout(LayoutKind.Explicit,Size=56)]
	public partial struct FAlphaBlend
	{
		/// <summary>If you're using Custom BlendOption, you can specify curve</summary>
		/// <summary>Blend Time</summary>
		[FieldOffset(16)]
		public float BlendTime;
		
	}
	
}
#endif
#endif
