#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=144)]
	public partial struct FComponentOverrideRecord
	{
		[FieldOffset(16)]
		public FComponentKey ComponentKey;
		[FieldOffset(56)]
		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
		
	}
	
}
#endif
#endif
