using System;
namespace UnrealEngine
{
	/// <summary>
	/// FVector_NetQuantize100
	/// 2 decimal place of precision.
	/// Up to 30 bits per component.
	/// Valid range: 2^30 / 100 = +/- 10,737,418.24
	/// </summary>
	public partial struct FVector_NetQuantize100
	{
		public float X;
		public float Y;
		public float Z;
		
	}
	
}
