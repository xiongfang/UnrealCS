using System;
namespace UnrealEngine
{
	/// <summary>Latent action info</summary>
	public partial struct FLatentActionInfo
	{
		/// <summary>The resume point within the function to execute</summary>
		public int Linkage;
		/// <summary>the UUID for this action</summary>
		public int UUID;
		/// <summary>The function to execute.</summary>
		public FName ExecutionFunction;
		/// <summary>Object to execute the function on.</summary>
		public UObject CallbackTarget;
		
	}
	
}
