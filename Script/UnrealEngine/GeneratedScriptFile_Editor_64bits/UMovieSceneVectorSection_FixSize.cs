#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A vector section.</summary>
	public partial class UMovieSceneVectorSection
	{
		static readonly int Curves__Offset;
		/// <summary>Vector t</summary>
		public FRichCurve Curves
		{
			get{ CheckIsValid();return (FRichCurve)Marshal.PtrToStructure(_this.Get()+Curves__Offset, typeof(FRichCurve));}
			
		}
		
		static readonly int ChannelsUsed__Offset;
		/// <summary>How many curves are actually used</summary>
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
