#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ALevelBounds
	{
		static readonly int bAutoUpdateBounds__Offset;
		public bool bAutoUpdateBounds
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAutoUpdateBounds__Offset, 1, 0, 1, 255);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAutoUpdateBounds__Offset, 1,0,1,255);}
			
		}
		
		static ALevelBounds()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LevelBounds");
			bAutoUpdateBounds__Offset=GetPropertyOffset(NativeClassPtr,"bAutoUpdateBounds");
			
		}
		
	}
	
}
#endif
#endif
