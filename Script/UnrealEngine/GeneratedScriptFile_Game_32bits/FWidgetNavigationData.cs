#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=20)]
	public partial struct FWidgetNavigationData
	{
		[FieldOffset(0)]
		public EUINavigationRule Rule;
		[FieldOffset(4)]
		public FName WidgetToFocus;
		
	}
	
}
#endif
#endif
