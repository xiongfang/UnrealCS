using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Provides different easing functions that can be used in blueprints</summary>
	public enum EEasingFunc:byte
	{
		/// <summary>Simple linear interpolation.</summary>
		Linear=0,
		/// <summary>Simple step interpolation.</summary>
		Step=1,
		/// <summary>Sinusoidal in interpolation.</summary>
		SinusoidalIn=2,
		/// <summary>Sinusoidal out interpolation.</summary>
		SinusoidalOut=3,
		/// <summary>Sinusoidal in/out interpolation.</summary>
		SinusoidalInOut=4,
		/// <summary>Smoothly accelerates, but does not decelerate into the target.  Ease amount controlled by BlendExp.</summary>
		EaseIn=5,
		/// <summary>Immediately accelerates, but smoothly decelerates into the target.  Ease amount controlled by BlendExp.</summary>
		EaseOut=6,
		/// <summary>Smoothly accelerates and decelerates.  Ease amount controlled by BlendExp.</summary>
		EaseInOut=7,
		/// <summary>Easing in using an exponential</summary>
		ExpoIn=8,
		/// <summary>Easing out using an exponential</summary>
		ExpoOut=9,
		/// <summary>Easing in/out using an exponential method</summary>
		ExpoInOut=10,
		/// <summary>Easing is based on a half circle.</summary>
		CircularIn=11,
		/// <summary>Easing is based on an inverted half circle.</summary>
		CircularOut=12,
		/// <summary>Easing is based on two half circles.</summary>
		CircularInOut=13,
		EEasingFunc_MAX=14,
		
	}
	
}
