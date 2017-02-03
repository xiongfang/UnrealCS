#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNode
	{
		static readonly int ChildNodes__Offset;
		public TObjectArray<USoundNode>  ChildNodes
		{
					get{ CheckIsValid();return new TObjectArray<USoundNode>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChildNodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChildNodes__Offset, false);}
			
		}
		
		static readonly int GraphNode__Offset;
		/// <summary>Node's Graph representation, used to get position.</summary>
		public UEdGraphNode GraphNode
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + GraphNode__Offset); if (v == IntPtr.Zero)return null; UEdGraphNode retValue = new UEdGraphNode(); retValue._this = v; return retValue; }
			
		}
		
		static USoundNode()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNode");
			ChildNodes__Offset=GetPropertyOffset(NativeClassPtr,"ChildNodes");
			GraphNode__Offset=GetPropertyOffset(NativeClassPtr,"GraphNode");
			
		}
		
	}
	
}
#endif
#endif
