using System;
namespace UnrealEngine
{
	/// <summary>
	/// Transform composed of Quat/Translation/Scale.
	/// The full C++ class is located here: Engine\Source\Runtime\Core\Public\Math\Transform.h
	/// </summary>
	public partial struct FTransform
	{
		public FQuat Rotation;
		public FVector Translation;
		public FVector Scale3D;
		
	}
	
}
