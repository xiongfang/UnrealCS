using System;
namespace UnrealEngine
{
	/// <summary>
	/// FVector_NetQuantize
	/// 0 decimal place of precision.
	/// Up to 20 bits per component.
	/// Valid range: 2^20 = +/- 1,048,576
	/// Note: this is the historical UE format for vector net serialization
	/// </summary>
	public partial struct FVector_NetQuantize
	{
		public float X;
		public float Y;
		public float Z;
		
	}
	
}
