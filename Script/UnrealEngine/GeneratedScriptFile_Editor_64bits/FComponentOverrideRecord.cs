#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=136)]
	public partial struct FComponentOverrideRecord
	{
		[FieldOffset(8)]
		public FComponentKey ComponentKey;
		[FieldOffset(48)]
		public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
		
	}
	
}
#endif
#endif
