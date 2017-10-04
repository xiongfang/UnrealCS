using System;
namespace UnrealEngine
{
	public partial struct FResponseChannel
	{
		/// <summary>
		/// This should match DisplayName of ECollisionChannel
		///     Meta data of custom channels can be used as well
		/// </summary>
		public FName Channel;
		public ECollisionResponse Response;
		
	}
	
}
