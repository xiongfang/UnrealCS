#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UMovieSceneSkeletalAnimationSection
	{
		static readonly int Params__Offset;
		public FMovieSceneSkeletalAnimationParams Params
		{
			get{ CheckIsValid();return (FMovieSceneSkeletalAnimationParams)Marshal.PtrToStructure(_this.Get()+Params__Offset, typeof(FMovieSceneSkeletalAnimationParams));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Params__Offset, false);}
			
		}
		
		static readonly int AnimSequence__Offset;
		public UAnimSequence AnimSequence
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimSequence__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Animation__Offset;
		public UAnimSequenceBase Animation
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Animation__Offset); if (v == IntPtr.Zero)return null; UAnimSequenceBase retValue = new UAnimSequenceBase(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int StartOffset__Offset;
		public float StartOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartOffset__Offset, typeof(float));}
			
		}
		
		static readonly int EndOffset__Offset;
		public float EndOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EndOffset__Offset, typeof(float));}
			
		}
		
		static readonly int PlayRate__Offset;
		public float PlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayRate__Offset, typeof(float));}
			
		}
		
		static readonly int bReverse__Offset;
		public bool bReverse
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReverse__Offset, 1, 0, 1, 1);}
			
		}
		
		static readonly int SlotName__Offset;
		public FName SlotName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SlotName__Offset, typeof(FName));}
			
		}
		
		static UMovieSceneSkeletalAnimationSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSkeletalAnimationSection");
			Params__Offset=GetPropertyOffset(NativeClassPtr,"Params");
			AnimSequence__Offset=GetPropertyOffset(NativeClassPtr,"AnimSequence");
			Animation__Offset=GetPropertyOffset(NativeClassPtr,"Animation");
			StartOffset__Offset=GetPropertyOffset(NativeClassPtr,"StartOffset");
			EndOffset__Offset=GetPropertyOffset(NativeClassPtr,"EndOffset");
			PlayRate__Offset=GetPropertyOffset(NativeClassPtr,"PlayRate");
			bReverse__Offset=GetPropertyOffset(NativeClassPtr,"bReverse");
			SlotName__Offset=GetPropertyOffset(NativeClassPtr,"SlotName");
			
		}
		
	}
	
}
#endif
#endif
