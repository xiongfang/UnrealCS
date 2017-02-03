#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Editable vector parameter.</summary>
	[StructLayout(LayoutKind.Explicit,Size=44)]
	public partial struct FVectorParameterValue
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(12)]
		public FLinearColor ParameterValue;
		[FieldOffset(28)]
		public FGuid ExpressionGUID;
		
	}
	
}
#endif
#endif
