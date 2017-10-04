using System;
namespace UnrealEngine
{
	/// <summary>
	/// Defines a mapping between an axis and key
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Input/index.html
	/// </summary>
	public partial struct FInputAxisKeyMapping
	{
		/// <summary>Friendly name of axis, e.g "MoveForward"</summary>
		public FName AxisName;
		/// <summary>Key to bind it to.</summary>
		public FKey Key;
		/// <summary>Multiplier to use for the mapping when accumulating the axis value</summary>
		public float Scale;
		
	}
	
}
