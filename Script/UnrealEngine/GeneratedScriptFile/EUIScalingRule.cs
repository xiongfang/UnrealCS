using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The Side to use when scaling the UI.</summary>
	public enum EUIScalingRule:byte
	{
		/// <summary>Evaluates the scale curve based on the shortest side of the viewport.</summary>
		ShortestSide=0,
		/// <summary>Evaluates the scale curve based on the longest side of the viewport.</summary>
		LongestSide=1,
		/// <summary>Evaluates the scale curve based on the X axis of the viewport.</summary>
		Horizontal=2,
		/// <summary>Evaluates the scale curve based on the Y axis of the viewport.</summary>
		Vertical=3,
		/// <summary>Custom - Allows custom rule interpretation.</summary>
		Custom=4,
		EUIScalingRule_MAX=5,
		
	}
	
}
