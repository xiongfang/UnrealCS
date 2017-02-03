#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Structure representing an animated vector parameter and it's associated animation curve.</summary>
	[StructLayout(LayoutKind.Explicit,Size=496)]
	public partial struct FColorParameterNameAndCurves
	{
		/// <summary>The name of the vector parameter which is being animated.</summary>
		[FieldOffset(0)]
		public FName ParameterName;
		[FieldOffset(12)]
		public int Index;
		/// <summary>The curve which contains the animation data for the red component of the color parameter.</summary>
		[FieldOffset(16)]
		public FRichCurve RedCurve;
		/// <summary>The curve which contains the animation data for the green component of the color parameter.</summary>
		[FieldOffset(136)]
		public FRichCurve GreenCurve;
		/// <summary>The curve which contains the animation data for the blue component of the color parameter.</summary>
		[FieldOffset(256)]
		public FRichCurve BlueCurve;
		/// <summary>The curve which contains the animation data for the alpha component of the color parameter.</summary>
		[FieldOffset(376)]
		public FRichCurve AlphaCurve;
		
	}
	
}
#endif
#endif
