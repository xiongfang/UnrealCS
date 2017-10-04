using System;
namespace UnrealEngine
{
	/// <summary>Configurable properties for control axes, used to transform raw input into game ready values.</summary>
	public partial struct FInputAxisProperties
	{
		/// <summary>What the dead zone of the axis is.  For control axes such as analog sticks.</summary>
		public float DeadZone;
		/// <summary>Scaling factor to multiply raw value by.</summary>
		public float Sensitivity;
		/// <summary>For applying curves to [0..1] axes, e.g. analog sticks</summary>
		public float Exponent;
		/// <summary>Inverts reported values for this axis</summary>
		public bool bInvert;
		
	}
	
}
