#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeLooping
	{
		static readonly int LoopCount__Offset;
		public int LoopCount
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+LoopCount__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LoopCount__Offset, false);}
			
		}
		
		static readonly int bLoopIndefinitely__Offset;
		public bool bLoopIndefinitely
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLoopIndefinitely__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLoopIndefinitely__Offset, 1,0,1,1);}
			
		}
		
		static USoundNodeLooping()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeLooping");
			LoopCount__Offset=GetPropertyOffset(NativeClassPtr,"LoopCount");
			bLoopIndefinitely__Offset=GetPropertyOffset(NativeClassPtr,"bLoopIndefinitely");
			
		}
		
	}
	
}
#endif
#endif
