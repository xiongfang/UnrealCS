using System;
namespace UnrealEngine
{
	public partial class UInterpGroupInst:UObject
	{
		/// <summary>UInterpGroup within the InterpData that this is an instance of.</summary>
		public UInterpGroup Group;
		
		/// <summary>
		/// Actor that this Group instance is acting upon.
		/// NB: that this may be set to NULL at any time as a result of the  AActor  being destroyed.
		/// </summary>
		public AActor GroupActor;
		
		
	}
	
}
