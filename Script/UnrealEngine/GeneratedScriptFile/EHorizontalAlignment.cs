using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Enumerates horizontal alignment options, i.e. for widget slots.</summary>
	public enum EHorizontalAlignment:byte
	{
		/// <summary>Fill the entire width.</summary>
		HAlign_Fill=0,
		/// <summary>Left-align.</summary>
		HAlign_Left=1,
		/// <summary>Center-align.</summary>
		HAlign_Center=2,
		/// <summary>Right-align.</summary>
		HAlign_Right=3,
		HAlign_MAX=4,
		
	}
	
}
