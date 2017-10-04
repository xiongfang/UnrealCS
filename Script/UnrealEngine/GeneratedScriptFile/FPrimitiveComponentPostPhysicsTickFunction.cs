using System;
namespace UnrealEngine
{
	/// <summary>
	/// Tick function that calls UPrimitiveComponent::PostPhysicsTick
	/// //DEPRECATED: This struct has been deprecated. Please use your own tick functions if you need something other than the primary tick function
	/// </summary>
	public partial struct FPrimitiveComponentPostPhysicsTickFunction
	{
		/// <summary>
		/// Defines the minimum tick group for this tick function. These groups determine the relative order of when objects tick during a frame update.
		/// Given prerequisites, the tick may be delayed.
		/// @see ETickingGroup
		/// @see FTickFunction::AddPrerequisite()
		/// </summary>
		public ETickingGroup TickGroup;
		/// <summary>
		/// Defines the tick group that this tick function must finish in. These groups determine the relative order of when objects tick during a frame update.
		/// @see ETickingGroup
		/// </summary>
		public ETickingGroup EndTickGroup;
		/// <summary>Bool indicating that this function should execute even if the game is paused. Pause ticks are very limited in capabilities. *</summary>
		public bool bTickEvenWhenPaused;
		/// <summary>If false, this tick function will never be registered and will never tick. Only settable in defaults.</summary>
		public bool bCanEverTick;
		/// <summary>If true, this tick function will start enabled, but can be disabled later on.</summary>
		public bool bStartWithTickEnabled;
		/// <summary>If we allow this tick to run on a dedicated server</summary>
		public bool bAllowTickOnDedicatedServer;
		/// <summary>The frequency in seconds at which this tick function will be executed.  If less than or equal to 0 then it will tick every frame</summary>
		public float TickInterval;
		
	}
	
}
