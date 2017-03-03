#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneEnumTrack
	{
		static readonly int Enum__Offset;
		public UEnum Enum
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Enum__Offset); if (v == IntPtr.Zero)return null; UEnum retValue = new UEnum(); retValue._this = v; return retValue; }
			
		}
		
		static UMovieSceneEnumTrack()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneEnumTrack");
			Enum__Offset=GetPropertyOffset(NativeClassPtr,"Enum");
			
		}
		
	}
	
}
#endif
#endif
