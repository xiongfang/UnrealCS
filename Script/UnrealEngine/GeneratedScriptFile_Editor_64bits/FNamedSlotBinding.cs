#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The state passed into OnPaint that we can expose as a single painting structure to blueprints to
	/// allow script code to override OnPaint behavior.
	/// </summary>
	[StructLayout(LayoutKind.Explicit,Size=24)]
	public partial struct FNamedSlotBinding
	{
		[FieldOffset(0)]
		public FName Name;
		
	}
	
}
#endif
#endif
