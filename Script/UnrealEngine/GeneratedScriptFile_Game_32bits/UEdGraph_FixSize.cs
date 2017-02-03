#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UEdGraph
	{
		static readonly int Schema__Offset;
		public TSubclassOf<UEdGraphSchema>  Schema
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Schema__Offset); return v; }
			
		}
		
		static readonly int Nodes__Offset;
		public TObjectArray<UEdGraphNode>  Nodes
		{
					get{ CheckIsValid();return new TObjectArray<UEdGraphNode>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Nodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Nodes__Offset, false);}
			
		}
		
		static readonly int bEditable__Offset;
		public bool bEditable
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bEditable__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int bAllowDeletion__Offset;
		public bool bAllowDeletion
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowDeletion__Offset, 1, 0, 2, 2);}
			
		}
		
		static readonly int bAllowRenaming__Offset;
		public bool bAllowRenaming
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAllowRenaming__Offset, 1, 0, 4, 4);}
			
		}
		
		static UEdGraph()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("EdGraph");
			Schema__Offset=GetPropertyOffset(NativeClassPtr,"Schema");
			Nodes__Offset=GetPropertyOffset(NativeClassPtr,"Nodes");
			bEditable__Offset=GetPropertyOffset(NativeClassPtr,"bEditable");
			bAllowDeletion__Offset=GetPropertyOffset(NativeClassPtr,"bAllowDeletion");
			bAllowRenaming__Offset=GetPropertyOffset(NativeClassPtr,"bAllowRenaming");
			
		}
		
	}
	
}
#endif
#endif
