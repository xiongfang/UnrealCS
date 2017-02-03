#if WITH_GAME
#if PLATFORM_32BITS
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
		
		static USoundNode()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNode");
			ChildNodes__Offset=GetPropertyOffset(NativeClassPtr,"ChildNodes");
			
		}
		
	}
	
}
#endif
#endif
