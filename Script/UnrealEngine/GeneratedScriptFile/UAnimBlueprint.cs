using System;
namespace UnrealEngine
{
	public partial class UAnimBlueprint:UBlueprint
	{
		/// <summary>The kind of skeleton that animation graphs compiled from the blueprint will animate</summary>
		public USkeleton TargetSkeleton;
		
		/// <summary>
		/// Allows this anim Blueprint to update its native update, blend tree, montages and asset players on
		/// a worker thread. The compiler will attempt to pick up any issues that may occur with threaded update.
		/// For updates to run in multiple threads both this flag and the project setting "Allow Multi Threaded
		/// Animation Update" should be set.
		/// </summary>
		public bool bUseMultiThreadedAnimationUpdate;
		
		/// <summary>
		/// Selecting this option will cause the compiler to emit warnings whenever a call into Blueprint
		/// is made from the animation graph. This can help track down optimizations that need to be made.
		/// </summary>
		public bool bWarnAboutBlueprintUsage;
		
		
	}
	
}
