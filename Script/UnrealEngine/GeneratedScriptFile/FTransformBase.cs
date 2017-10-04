using System;
namespace UnrealEngine
{
	/// <summary>This is a mapping table between bone in a particular skeletal mesh and bone of this skeleton set.</summary>
	public partial struct FTransformBase
	{
		public FName Node;
		public FTransformBaseConstraint Constraints;
		
	}
	
}
