using System;
namespace UnrealEngine
{
	/// <summary>Struct indicating a variable in the generated class</summary>
	public partial struct FBPVariableDescription
	{
		/// <summary>Name of the variable</summary>
		public FName VarName;
		/// <summary>A Guid that will remain constant even if the VarName changes</summary>
		public FGuid VarGuid;
		/// <summary>Type of the variable</summary>
		public FEdGraphPinType VarType;
		/// <summary>Friendly name of the variable</summary>
		public FString FriendlyName;
		/// <summary>Category this variable should be in</summary>
		public FText Category;
		/// <summary>Property flags for this variable - Changed from int32 to uint64</summary>
		public ulong PropertyFlags;
		public FName RepNotifyFunc;
		public ELifetimeCondition ReplicationCondition;
		/// <summary>Optional new default value stored as string</summary>
		public FString DefaultValue;
		
	}
	
}
