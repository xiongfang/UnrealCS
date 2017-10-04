using System;
namespace UnrealEngine
{
	public partial class UPropertyBinding:UObject
	{
		/// <summary>The property path to trace to resolve this binding on the Source Object</summary>
		public FDynamicPropertyPath SourcePath;
		
		/// <summary>Used to determine if a binding already exists on the object and if this binding can be safely removed.</summary>
		public FName DestinationProperty;
		
		
	}
	
}
