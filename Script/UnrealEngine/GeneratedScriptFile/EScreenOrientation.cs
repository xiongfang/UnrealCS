using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>The list of possible device/screen orientation for mobile devices</summary>
	public enum EScreenOrientation:byte
	{
		/// <summary>The orientation is not known</summary>
		Unknown=0,
		/// <summary>The orientation is portrait with the home button at the bottom</summary>
		Portrait=1,
		/// <summary>The orientation is portrait with the home button at the top</summary>
		PortraitUpsideDown=2,
		/// <summary>The orientation is landscape with the home button at the right side</summary>
		LandscapeLeft=3,
		/// <summary>The orientation is landscape with the home button at the left side</summary>
		LandscapeRight=4,
		/// <summary>The orientation is as if place on a desk with the screen upward</summary>
		FaceUp=5,
		/// <summary>The orientation is as if place on a desk with the screen downward</summary>
		FaceDown=6,
		EScreenOrientation_MAX=7,
		
	}
	
}
