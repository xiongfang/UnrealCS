using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates vertical alignment options, i.e. for widget slots.</summary>
	public enum EVerticalAlignment:byte
	{
		/// <summary>Fill the entire height.</summary>
		VAlign_Fill=0,
		/// <summary>Top-align.</summary>
		VAlign_Top=1,
		/// <summary>Center-align.</summary>
		VAlign_Center=2,
		/// <summary>Bottom-align.</summary>
		VAlign_Bottom=3,
		VAlign_MAX=4,
		
	}
	
}
