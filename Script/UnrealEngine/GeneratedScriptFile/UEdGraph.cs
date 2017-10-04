using System;
namespace UnrealEngine
{
	public partial class UEdGraph:UObject
	{
		/// <summary>The schema that this graph obeys</summary>
		public TSubclassOf<UEdGraphSchema>  Schema;
		
		/// <summary>If true, graph can be edited by the user</summary>
		public bool bEditable;
		
		/// <summary>
		/// If true, graph can be deleted from the whatever container it is in. For FunctionGraphs
		/// this flag is reset to false on load (unless the function is the construction script or
		/// AnimGraph)
		/// </summary>
		public bool bAllowDeletion;
		
		/// <summary>If true, graph can be renamed; Note: Graph can also be renamed if bAllowDeletion is true currently</summary>
		public bool bAllowRenaming;
		
		/// <summary>Guid for this graph</summary>
		public FGuid GraphGuid;
		
		/// <summary>Guid of interface graph this graph comes from (used for conforming)</summary>
		public FGuid InterfaceGuid;
		
		
	}
	
}
