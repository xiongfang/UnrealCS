using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum ETextJustify:byte
	{
		/// <summary>
		/// Justify the text logically to the left.
		/// When text is flowing left-to-right, this will align text visually to the left.
		/// When text is flowing right-to-left, this will align text visually to the right.
		/// </summary>
		Left=0,
		/// <summary>
		/// Justify the text in the center.
		/// Text flow direction has no impact on this justification mode.
		/// </summary>
		Center=1,
		/// <summary>
		/// Justify the text logically to the right.
		/// When text is flowing left-to-right, this will align text visually to the right.
		/// When text is flowing right-to-left, this will align text visually to the left.
		/// </summary>
		Right=2,
		ETextJustify_MAX=3,
		
	}
	
}
