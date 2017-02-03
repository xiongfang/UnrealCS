using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines the controller hands for tracking.  Could be expanded, as needed, to facilitate non-handheld controllers</summary>
	public enum EControllerHand:byte
	{
		Left=0,
		Right=1,
		Pad=2,
		ExternalCamera=3,
		Special_1=4,
		Special_2=5,
		Special_3=6,
		Special_4=7,
		Special_5=8,
		Special_6=9,
		Special_7=10,
		Special_8=11,
		Special_9=12,
		EControllerHand_MAX=13,
		
	}
	
}
