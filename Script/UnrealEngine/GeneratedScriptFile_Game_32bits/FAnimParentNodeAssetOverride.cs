#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FAnimParentNodeAssetOverride
	{
		[FieldOffset(4)]
		public FGuid ParentNodeGuid;
		
	}
	
}
#endif
#endif
