#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneVectorSection
	{
		static readonly int Curves__Offset;
		public FRichCurve Curves
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Curves__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int ChannelsUsed__Offset;
		public int ChannelsUsed
		{
			get{ CheckIsValid();return (int)Marshal.PtrToStructure(_this.Get()+ChannelsUsed__Offset, typeof(int));}
			
		}
		
		static UMovieSceneVectorSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneVectorSection");
			Curves__Offset=GetPropertyOffset(NativeClassPtr,"Curves");
			ChannelsUsed__Offset=GetPropertyOffset(NativeClassPtr,"ChannelsUsed");
			
		}
		
	}
	
}
#endif
#endif
