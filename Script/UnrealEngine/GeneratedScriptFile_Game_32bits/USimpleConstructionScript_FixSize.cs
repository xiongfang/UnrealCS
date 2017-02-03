#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USimpleConstructionScript
	{
		static readonly int RootNodes__Offset;
		public TObjectArray<USCS_Node>  RootNodes
		{
					get{ CheckIsValid();return new TObjectArray<USCS_Node>((FScriptArray)Marshal.PtrToStructure(_this.Get()+RootNodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+RootNodes__Offset, false);}
			
		}
		
		static readonly int AllNodes__Offset;
		public TObjectArray<USCS_Node>  AllNodes
		{
					get{ CheckIsValid();return new TObjectArray<USCS_Node>((FScriptArray)Marshal.PtrToStructure(_this.Get()+AllNodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+AllNodes__Offset, false);}
			
		}
		
		static readonly int DefaultSceneRootNode__Offset;
		public USCS_Node DefaultSceneRootNode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + DefaultSceneRootNode__Offset); if (v == IntPtr.Zero)return null; USCS_Node retValue = new USCS_Node(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int RootNode__Offset;
		public USCS_Node RootNode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + RootNode__Offset); if (v == IntPtr.Zero)return null; USCS_Node retValue = new USCS_Node(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int ActorComponentNodes__Offset;
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
