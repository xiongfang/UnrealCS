#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UAnimComposite
	{
		static readonly int AnimationTrack__Offset;
		public FAnimTrack AnimationTrack
		{
			get{ CheckIsValid();return (FAnimTrack)Marshal.PtrToStructure(_this.Get()+AnimationTrack__Offset, typeof(FAnimTrack));}
			
		}
		
		static UAnimComposite()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("AnimComposite");
			AnimationTrack__Offset=GetPropertyOffset(NativeClassPtr,"AnimationTrack");
			
		}
		
	}
	
}
#endif
#endif
