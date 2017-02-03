#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Editable scalar parameter.</summary>
	[StructLayout(LayoutKind.Explicit,Size=32)]
	public partial struct FScalarParameterValue
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(12)]
		public float ParameterValue;
		[FieldOffset(16)]
		public FGuid ExpressionGUID;
		
	}
	
}
#endif
#endif
