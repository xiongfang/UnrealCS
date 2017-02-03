#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class URig
	{
		static readonly int TransformBases__Offset;
		public TStructArray<FTransformBase> TransformBases
		{
			get{ CheckIsValid();return new TStructArray<FTransformBase>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TransformBases__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TransformBases__Offset, false);}
			
		}
		
		static readonly int Nodes__Offset;
		public TStructArray<FNode> Nodes
		{
			get{ CheckIsValid();return new TStructArray<FNode>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Nodes__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Nodes__Offset, false);}
			
		}
		
		static URig()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("Rig");
			TransformBases__Offset=GetPropertyOffset(NativeClassPtr,"TransformBases");
			Nodes__Offset=GetPropertyOffset(NativeClassPtr,"Nodes");
			
		}
		
	}
	
}
#endif
#endif
