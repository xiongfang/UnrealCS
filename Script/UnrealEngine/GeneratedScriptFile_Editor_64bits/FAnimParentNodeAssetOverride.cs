#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FAnimParentNodeAssetOverride
	{
		[FieldOffset(8)]
		public FGuid ParentNodeGuid;
		
	}
	
}
#endif
#endif
