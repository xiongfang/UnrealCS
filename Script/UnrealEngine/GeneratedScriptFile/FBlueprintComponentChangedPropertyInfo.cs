using System;
namespace UnrealEngine
{
	/// <summary>A single changed Blueprint component property.</summary>
	public partial struct FBlueprintComponentChangedPropertyInfo
	{
		/// <summary>The name of the changed property.</summary>
		public FName PropertyName;
		/// <summary>The array index of the changed property.</summary>
		public int ArrayIndex;
		/// <summary>The parent struct (owner) of the changed property.</summary>
		public UStruct PropertyScope;
		
	}
	
}
