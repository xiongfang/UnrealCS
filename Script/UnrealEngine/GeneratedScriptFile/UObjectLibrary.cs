using System;
namespace UnrealEngine
{
	public partial class UObjectLibrary:UObject
	{
		/// <summary>Class that Objects must be of. If ContainsBlueprints is true, this is the native class that the blueprints are instances of and not UClass</summary>
		public UClass ObjectBaseClass;
		
		/// <summary>True if this library holds blueprint classes, false if it holds other objects</summary>
		public bool bHasBlueprintClasses;
		
		/// <summary>If this library should use weak pointers</summary>
		public bool bUseWeakReferences;
		
		/// <summary>True if we've already fully loaded this library, can't do it twice</summary>
		public bool bIsFullyLoaded;
		
		
	}
	
}
