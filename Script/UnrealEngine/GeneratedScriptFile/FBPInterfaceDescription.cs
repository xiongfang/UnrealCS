using System;
namespace UnrealEngine
{
	/// <summary>Struct containing information about what interfaces are implemented in this blueprint</summary>
	public partial struct FBPInterfaceDescription
	{
		/// <summary>Reference to the interface class we're adding to this blueprint</summary>
		public TSubclassOf<UInterface>  Interface;
		
	}
	
}
