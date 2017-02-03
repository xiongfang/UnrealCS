using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public enum EComponentCreationMethod:byte
	{
		/// <summary>A component that is part of a native class.</summary>
		Native=0,
		/// <summary>A component that is created from a template defined in the Components section of the Blueprint.</summary>
		SimpleConstructionScript=1,
		/// <summary>A dynamically created component, either from the UserConstructionScript or from a Add Component node in a Blueprint event graph.</summary>
		UserConstructionScript=2,
		/// <summary>A component added to a single Actor instance via the Component section of the Actor's details panel.</summary>
		Instance=3,
		EComponentCreationMethod_MAX=4,
		
	}
	
}
