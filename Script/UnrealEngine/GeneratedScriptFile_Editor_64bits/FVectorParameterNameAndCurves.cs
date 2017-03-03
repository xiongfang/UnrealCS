#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure representing an animated vector parameter and it's associated animation curve.</summary>
	[StructLayout(LayoutKind.Explicit,Size=352)]
	public partial struct FVectorParameterNameAndCurves
	{
		/// <summary>The name of the vector parameter which is being animated.</summary>
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(12)]
		public int Index;
		/// <summary>The curve which contains the animation data for the x component of the vector parameter.</summary>
		[FieldOffset(16)]
		public FRichCurve XCurve;
		/// <summary>The curve which contains the animation data for the y component of the vector parameter.</summary>
		[FieldOffset(128)]
		public FRichCurve YCurve;
		/// <summary>The curve which contains the animation data for the z component of the vector parameter.</summary>
		[FieldOffset(240)]
		public FRichCurve ZCurve;
		
	}
	
}
#endif
#endif
