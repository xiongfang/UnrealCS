using System;
namespace UnrealEngine
{
	/// <summary>Entry for a delegate to assign after a blueprint has been instanced</summary>
	public partial struct FBlueprintComponentDelegateBinding
	{
		/// <summary>Name of component property that contains delegate we want to assign to.</summary>
		public FName ComponentPropertyName;
		/// <summary>Name of property on the component that we want to assign to.</summary>
		public FName DelegatePropertyName;
		/// <summary>Name of function that we want to bind to the delegate.</summary>
		public FName FunctionNameToBind;
		
	}
	
}
