#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USimpleConstructionScript
	{
		static readonly int RootNodes__Offset;
		/// <summary>Root nodes of the construction script</summary>
		public TObjectArray<USCS_Node>  RootNodes
		{
					get{ CheckIsValid();return new TObjectArray<USCS_Node>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RootNodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RootNodes__Offset, false);}
			
		}
		
		static readonly int AllNodes__Offset;
		/// <summary>All nodes that exist in the hierarchy of this SimpleConstructionScript</summary>
		public TObjectArray<USCS_Node>  AllNodes
		{
					get{ CheckIsValid();return new TObjectArray<USCS_Node>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AllNodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AllNodes__Offset, false);}
			
		}
		
		static readonly int DefaultSceneRootNode__Offset;
		/// <summary>Default scene root node; used when no other nodes are available to use as the root</summary>
		public USCS_Node DefaultSceneRootNode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultSceneRootNode__Offset); if (v == IntPtr.Zero)return null; USCS_Node retValue = new USCS_Node(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RootNode__Offset;
		/// <summary>(DEPRECATED) Root node of the construction script</summary>
		public USCS_Node RootNode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RootNode__Offset); if (v == IntPtr.Zero)return null; USCS_Node retValue = new USCS_Node(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ActorComponentNodes__Offset;
		/// <summary>(DEPRECATED) Actor Component based nodes are stored here.  They cannot be in the tree hierarchy</summary>
		public TObjectArray<USCS_Node>  ActorComponentNodes
		{
					get{ CheckIsValid();return new TObjectArray<USCS_Node>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ActorComponentNodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ActorComponentNodes__Offset, false);}
			
		}
		
		static USimpleConstructionScript()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SimpleConstructionScript");
			RootNodes__Offset=GetPropertyOffset(NativeClassPtr,"RootNodes");
			AllNodes__Offset=GetPropertyOffset(NativeClassPtr,"AllNodes");
			DefaultSceneRootNode__Offset=GetPropertyOffset(NativeClassPtr,"DefaultSceneRootNode");
			RootNode__Offset=GetPropertyOffset(NativeClassPtr,"RootNode");
			ActorComponentNodes__Offset=GetPropertyOffset(NativeClassPtr,"ActorComponentNodes");
			
		}
		
	}
	
}
#endif
#endif
