using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>SProgressBar Fill Type</summary>
	public enum EProgressBarFillType:byte
	{
		/// <summary>will fill up from the left side to the right</summary>
		LeftToRight=0,
		/// <summary>will fill up from the right side to the left side</summary>
		RightToLeft=1,
		/// <summary>will fill up from the center to the outer edges</summary>
		FillFromCenter=2,
		/// <summary>will fill up from the top to the the bottom</summary>
		TopToBottom=3,
		/// <summary>will fill up from the bottom to the the top</summary>
		BottomToTop=4,
		EProgressBarFillType_MAX=5,
		
	}
	
}
