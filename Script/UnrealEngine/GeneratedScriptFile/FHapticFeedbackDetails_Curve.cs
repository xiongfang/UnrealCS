using System;
namespace UnrealEngine
{
	public partial struct FHapticFeedbackDetails_Curve
	{
		/// <summary>The frequency to vibrate the haptic device at.  Frequency ranges vary by device!</summary>
		public FRuntimeFloatCurve Frequency;
		/// <summary>The amplitude to vibrate the haptic device at.  Amplitudes are normalized over the range [0.0, 1.0], with 1.0 being the max setting of the device</summary>
		public FRuntimeFloatCurve Amplitude;
		
	}
	
}
