#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Editable font parameter.</summary>
	[StructLayout(LayoutKind.Explicit,Size=48)]
	public partial struct FFontParameterValue
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(24)]
		public int FontPage;
		[FieldOffset(28)]
		public FGuid ExpressionGUID;
		
	}
	
}
#endif
#endif
