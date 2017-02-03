#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Editable texture parameter.</summary>
	[StructLayout(LayoutKind.Explicit,Size=40)]
	public partial struct FTextureParameterValue
	{
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(24)]
		public FGuid ExpressionGUID;
		
	}
	
}
#endif
#endif
