#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FEdGraphPinReference
	{
		/// <summary>The pin's unique ID. Updated at Set and Save time.</summary>
		[FieldOffset(8)]
		public FGuid PinId;
		
	}
	
}
#endif
#endif
