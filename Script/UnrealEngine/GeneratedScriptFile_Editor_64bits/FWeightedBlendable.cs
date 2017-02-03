#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=16)]
	public partial struct FWeightedBlendable
	{
		/// <summary>0:no effect .. 1:full effect</summary>
		[FieldOffset(0)]
		public float Weight;
		/// <summary>should be of the IBlendableInterface* type but UProperties cannot express that</summary>
		
	}
	
}
#endif
#endif
