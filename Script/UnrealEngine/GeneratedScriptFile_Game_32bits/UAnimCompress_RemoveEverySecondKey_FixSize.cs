#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimCompress_RemoveEverySecondKey
	{
		static readonly int MinKeys__Offset;
		public int MinKeys
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+MinKeys__Offset, typeof(int));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+MinKeys__Offset, false);}
			
		}
		
		static readonly int bStartAtSecondKey__Offset;
		public bool bStartAtSecondKey
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bStartAtSecondKey__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bStartAtSecondKey__Offset, 1,0,1,1);}
			
		}
		
		static UAnimCompress_RemoveEverySecondKey()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimCompress_RemoveEverySecondKey");
			MinKeys__Offset=GetPropertyOffset(NativeClassPtr,"MinKeys");
			bStartAtSecondKey__Offset=GetPropertyOffset(NativeClassPtr,"bStartAtSecondKey");
			
		}
		
	}
	
}
#endif
#endif
