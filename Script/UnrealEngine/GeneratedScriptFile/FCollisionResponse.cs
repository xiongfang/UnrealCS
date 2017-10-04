using System;
namespace UnrealEngine
{
	public partial struct FCollisionResponse
	{
		/// <summary>
		/// Types of objects that this physics objects will collide with. // @todo : make this to be transient, so that it doesn't have to save anymore
		/// // we have to still load them until resave
		/// </summary>
		public FCollisionResponseContainer ResponseToChannels;
		
	}
	
}
