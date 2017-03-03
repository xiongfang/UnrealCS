#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FWidgetNavigationData
	{
		[FieldOffset(4)]
		public FName WidgetToFocus;
		
	}
	
}
#endif
#endif
