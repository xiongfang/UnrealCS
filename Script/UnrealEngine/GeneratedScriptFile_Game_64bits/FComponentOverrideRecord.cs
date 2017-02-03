#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=120)]
	public partial struct FComponentOverrideRecord
	{
		[FieldOffset(8)]
		public FComponentKey ComponentKey;
		[FieldOffset(40)]
		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
		
	}
	
}
#endif
#endif
