using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Provides rounding modes for converting numbers into localized text</summary>
	public enum ERoundingMode:byte
	{
		/// <summary>Rounds to the nearest place, equidistant ties go to the value which is closest to an even value: 1.5 becomes 2, 0.5 becomes 0</summary>
		HalfToEven=0,
		/// <summary>Rounds to nearest place, equidistant ties go to the value which is further from zero: -0.5 becomes -1.0, 0.5 becomes 1.0</summary>
		HalfFromZero=1,
		/// <summary>Rounds to nearest place, equidistant ties go to the value which is closer to zero: -0.5 becomes 0, 0.5 becomes 0.</summary>
		HalfToZero=2,
		/// <summary>Rounds to the value which is further from zero, "larger" in absolute value: 0.1 becomes 1, -0.1 becomes -1</summary>
		FromZero=3,
		/// <summary>Rounds to the value which is closer to zero, "smaller" in absolute value: 0.1 becomes 0, -0.1 becomes 0</summary>
		ToZero=4,
		/// <summary>Rounds to the value which is more negative: 0.1 becomes 0, -0.1 becomes -1</summary>
		ToNegativeInfinity=5,
		/// <summary>Rounds to the value which is more positive: 0.1 becomes 1, -0.1 becomes 0</summary>
		ToPositiveInfinity=6,
		AX=7,
		
	}
	
}
