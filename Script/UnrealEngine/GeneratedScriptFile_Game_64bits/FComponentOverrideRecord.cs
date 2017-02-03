#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FComponentOverrideRecord
	{
		[FieldOffset(16)]
		public FComponentKey ComponentKey;
		[FieldOffset(48)]
		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
		
	}
	
}
#endif
#endif
