using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Used by FPostProcessSettings Auto Exposure</summary>
	public enum EAutoExposureMethod:byte
	{
		/// <summary>Not supported on mobile, requires compute shader to construct 64 bin histogram</summary>
		AEM_Histogram=0,
		/// <summary>Not supported on mobile, faster method that computes single value by downsampling</summary>
		AEM_Basic=1,
		AEM_MAX=2,
		
	}
	
}
