#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ALevelScriptActor
	{
		static readonly int bInputEnabled__Offset;
		public bool bInputEnabled
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bInputEnabled__Offset, 1, 0, 1, 1);}
			
		}
		
		static ALevelScriptActor()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LevelScriptActor");
			bInputEnabled__Offset=GetPropertyOffset(NativeClassPtr,"bInputEnabled");
			
		}
		
	}
	
}
#endif
#endif
