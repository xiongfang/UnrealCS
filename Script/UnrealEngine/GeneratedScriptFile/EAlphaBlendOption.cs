using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EAlphaBlendOption:byte
	{
		/// <summary>Linear interpolation</summary>
		Linear=0,
		/// <summary>Cubic-in interpolation</summary>
		Cubic=1,
		/// <summary>Hermite-Cubic</summary>
		HermiteCubic=2,
		/// <summary>Sinusoidal interpolation</summary>
		Sinusoidal=3,
		/// <summary>Quadratic in-out interpolation</summary>
		QuadraticInOut=4,
		/// <summary>Cubic in-out interpolation</summary>
		CubicInOut=5,
		/// <summary>Quartic in-out interpolation</summary>
		QuarticInOut=6,
		/// <summary>Quintic in-out interpolation</summary>
		QuinticInOut=7,
		/// <summary>Circular-in interpolation</summary>
		CircularIn=8,
		/// <summary>Circular-out interpolation</summary>
		CircularOut=9,
		/// <summary>Circular in-out interpolation</summary>
		CircularInOut=10,
		/// <summary>Exponential-in interpolation</summary>
		ExpIn=11,
		/// <summary>Exponential-Out interpolation</summary>
		ExpOut=12,
		/// <summary>Exponential in-out interpolation</summary>
		ExpInOut=13,
		/// <summary>Custom interpolation, will use custom curve inside an FAlphaBlend or linear if none has been set</summary>
		Custom=14,
		EAlphaBlendOption_MAX=15,
		
	}
	
}
