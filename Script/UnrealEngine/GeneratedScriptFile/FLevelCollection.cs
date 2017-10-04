using System;
namespace UnrealEngine
{
	/// <summary>
	/// Contains a group of levels of a particular ELevelCollectionType within a UWorld
	/// and the context required to properly tick/update those levels. This object is move-only.
	/// </summary>
	public partial struct FLevelCollection
	{
		/// <summary>
		/// The GameState associated with this collection. This may be different than the UWorld's GameState
		/// since the source collection and the duplicated collection will have their own instances.
		/// </summary>
		public AGameStateBase GameState;
		/// <summary>
		/// The network driver associated with this collection.
		/// The source collection and the duplicated collection will have their own instances.
		/// </summary>
		public UNetDriver NetDriver;
		/// <summary>
		/// The demo network driver associated with this collection.
		/// The source collection and the duplicated collection will have their own instances.
		/// </summary>
		public UDemoNetDriver DemoNetDriver;
		/// <summary>
		/// The persistent level associated with this collection.
		/// The source collection and the duplicated collection will have their own instances.
		/// </summary>
		public ULevel PersistentLevel;
		
	}
	
}
