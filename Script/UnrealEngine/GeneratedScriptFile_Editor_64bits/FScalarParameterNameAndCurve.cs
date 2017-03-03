#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure representing an animated scalar parameter and it's associated animation curve.</summary>
	[StructLayout(LayoutKind.Explicit,Size=128)]
	public partial struct FScalarParameterNameAndCurve
	{
		/// <summary>The name of the scalar parameter which is being animated.</summary>
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(12)]
		public int Index;
		/// <summary>The curve which contains the animation data for the scalar parameter.</summary>
		[FieldOffset(16)]
		public FRichCurve ParameterCurve;
		
	}
	
}
#endif
#endif
