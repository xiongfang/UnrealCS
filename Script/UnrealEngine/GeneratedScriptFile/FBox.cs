using System;
namespace UnrealEngine
{
	/// <summary>
	/// A bounding box.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Box.h
	/// </summary>
	public partial struct FBox
	{
		public FVector Min;
		public FVector Max;
		public byte IsValid;
		
	}
	
}
