using System;
namespace UnrealEngine
{
	/// <summary>Configurable properties for control axes.</summary>
	public partial struct FInputAxisConfigEntry
	{
		/// <summary>Axis Key these properties apply to</summary>
		public FName AxisKeyName;
		/// <summary>Properties for the Axis Key</summary>
		public FInputAxisProperties AxisProperties;
		
	}
	
}
