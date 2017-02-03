using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EStretch:byte
	{
		/// <summary>Does not scale the content.</summary>
		None=0,
		/// <summary>Scales the content non-uniformly filling the entire space of the area.</summary>
		Fill=1,
		/// <summary>
		/// Scales the content uniformly (preserving aspect ratio)
		/// until it can no longer scale the content without clipping it.
		/// </summary>
		ScaleToFit=2,
		/// <summary>
		/// Scales the content uniformly (preserving aspect ratio)
		/// until it can no longer scale the content without clipping it along the x-axis,
		/// the y-axis can/will be clipped.
		/// </summary>
		ScaleToFitX=3,
		/// <summary>
		/// Scales the content uniformly (preserving aspect ratio)
		/// until it can no longer scale the content without clipping it along the y-axis,
		/// the x-axis can/will be clipped.
		/// </summary>
		ScaleToFitY=4,
		/// <summary>
		/// Scales the content uniformly (preserving aspect ratio), until all sides meet
		/// or exceed the size of the area.  Will result in clipping the longer side.
		/// </summary>
		ScaleToFill=5,
		/// <summary>Scales the content according to the size of the safe zone currently applied to the viewport.</summary>
		ScaleBySafeZone=6,
		/// <summary>Scales the content by the scale specified by the user.</summary>
		UserSpecified=7,
		EStretch_MAX=8,
		
	}
	
}
