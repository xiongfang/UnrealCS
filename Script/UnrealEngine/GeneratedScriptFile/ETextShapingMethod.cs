using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// Methods that can be used to shape text.
	/// @note If you change this enum, make sure and update CVarDefaultTextShapingMethod and GetDefaultTextShapingMethod.
	/// </summary>
	public enum ETextShapingMethod:byte
	{
		/// <summary>
		/// Automatically picks the fastest possible shaping method (either KerningOnly or FullShaping) based on the reading direction of the text.
		/// Left-to-right text uses the KerningOnly method, and right-to-left text uses the FullShaping method.
		/// </summary>
		Auto=0,
		/// <summary>
		/// Provides fake shaping using only kerning data.
		/// This can be faster than full shaping, but won't render complex right-to-left or bi-directional glyphs (such as Arabic) correctly.
		/// This can be useful as an optimization when you know your text block will only show simple glyphs (such as numbers).
		/// </summary>
		KerningOnly=1,
		/// <summary>
		/// Provides full text shaping, allowing accurate rendering of complex right-to-left or bi-directional glyphs (such as Arabic).
		/// This mode will perform ligature replacement for all languages (such as the combined "fi" glyph in English).
		/// </summary>
		FullShaping=2,
		ETextShapingMethod_MAX=3,
		
	}
	
}
