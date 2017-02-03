using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>
	/// The different directions that text can flow within a paragraph of text.
	/// @note If you change this enum, make sure and update CVarDefaultTextFlowDirection and GetDefaultTextFlowDirection.
	/// </summary>
	public enum ETextFlowDirection:byte
	{
		/// <summary>Automatically detect the flow direction for each paragraph from its text</summary>
		Auto=0,
		/// <summary>Force text to be flowed left-to-right</summary>
		LeftToRight=1,
		/// <summary>Force text to be flowed right-to-left</summary>
		RightToLeft=2,
		ETextFlowDirection_MAX=3,
		
	}
	
}
