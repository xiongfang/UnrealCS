using System;
namespace UnrealEngine
{
	/// <summary>
	/// FVector_NetQuantize10
	/// 1 decimal place of precision.
	/// Up to 24 bits per component.
	/// Valid range: 2^24 / 10 = +/- 1,677,721.6
	/// </summary>
	public partial struct FVector_NetQuantize10
	{
		public float X;
		public float Y;
		public float Z;
		
	}
	
}
