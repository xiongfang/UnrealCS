using System;
namespace UnrealEngine
{
	public partial struct FDelegateRuntimeBinding
	{
		/// <summary>The widget that will be bound to the live data.</summary>
		public FString ObjectName;
		/// <summary>The property on the widget that will have a binding placed on it.</summary>
		public FName PropertyName;
		/// <summary>The function or property we're binding to on the source object.</summary>
		public FName FunctionName;
		public FDynamicPropertyPath SourcePath;
		
	}
	
}
