#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEdGraph
	{
		static readonly int Schema__Offset;
		/// <summary>The schema that this graph obeys</summary>
		public TSubclassOf<UEdGraphSchema>  Schema
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Schema__Offset); return v; }
			
		}
		
		static readonly int Nodes__Offset;
		/// <summary>Set of all nodes in this graph</summary>
		public TObjectArray<UEdGraphNode>  Nodes
		{
					get{ CheckIsValid();return new TObjectArray<UEdGraphNode>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Nodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Nodes__Offset, false);}
			
		}
		
		static readonly int bEditable__Offset;
		/// <summary>If true, graph can be edited by the user</summary>
		public bool bEditable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEditable__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bAllowDeletion__Offset;
		/// <summary>
		/// If true, graph can be deleted from the whatever container it is in. For FunctionGraphs
		/// this flag is reset to false on load (unless the function is the construction script or
		/// AnimGraph)
		/// </summary>
		public bool bAllowDeletion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowDeletion__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bAllowRenaming__Offset;
		/// <summary>If true, graph can be renamed; Note: Graph can also be renamed if bAllowDeletion is true currently</summary>
		public bool bAllowRenaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowRenaming__Offset, 1, 0, 4, 4);}
			
		}
		
		static readonly int SubGraphs__Offset;
		/// <summary>Child graphs that are a part of this graph; the separation is purely visual</summary>
		public TObjectArray<UEdGraph>  SubGraphs
		{
					get{ CheckIsValid();return new TObjectArray<UEdGraph>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SubGraphs__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SubGraphs__Offset, false);}
			
		}
		
		static readonly int GraphGuid__Offset;
		/// <summary>Guid for this graph</summary>
		public FGuid GraphGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+GraphGuid__Offset, typeof(FGuid));}
			
		}
		
		static readonly int InterfaceGuid__Offset;
		/// <summary>Guid of interface graph this graph comes from (used for conforming)</summary>
		public FGuid InterfaceGuid
		{
			get{ CheckIsValid();return (FGuid)Marshal.PtrToStructure(_this.Get()+InterfaceGuid__Offset, typeof(FGuid));}
			
		}
		
		static UEdGraph()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EdGraph");
			Schema__Offset=GetPropertyOffset(NativeClassPtr,"Schema");
			Nodes__Offset=GetPropertyOffset(NativeClassPtr,"Nodes");
			bEditable__Offset=GetPropertyOffset(NativeClassPtr,"bEditable");
			bAllowDeletion__Offset=GetPropertyOffset(NativeClassPtr,"bAllowDeletion");
			bAllowRenaming__Offset=GetPropertyOffset(NativeClassPtr,"bAllowRenaming");
			SubGraphs__Offset=GetPropertyOffset(NativeClassPtr,"SubGraphs");
			GraphGuid__Offset=GetPropertyOffset(NativeClassPtr,"GraphGuid");
			InterfaceGuid__Offset=GetPropertyOffset(NativeClassPtr,"InterfaceGuid");
			
		}
		
	}
	
}
#endif
#endif
