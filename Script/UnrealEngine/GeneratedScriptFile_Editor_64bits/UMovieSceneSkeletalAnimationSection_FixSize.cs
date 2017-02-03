#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Movie scene section that control skeletal animation</summary>
	public partial class UMovieSceneSkeletalAnimationSection
	{
		static readonly int AnimSequence__Offset;
		public UAnimSequence AnimSequence
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + AnimSequence__Offset); if (v == IntPtr.Zero)return null; UAnimSequence retValue = new UAnimSequence(); retValue._this = v; return retValue; }
			
		}
		
		static readonly int Animation__Offset;
		/// <summary>The animation this section plays</summary>
		public UAnimSequenceBase Animation
		{
			get{ CheckIsValid(); IntPtr v = Marshal.ReadIntPtr(_this.Get() + Animation__Offset); if (v == IntPtr.Zero)return null; UAnimSequenceBase retValue = new UAnimSequenceBase(); retValue._this = v; return retValue; }
			set{ CheckIsValid(); if (value == null)Marshal.WriteIntPtr(_this.Get() + Animation__Offset, IntPtr.Zero);else Marshal.WriteIntPtr(_this.Get() + Animation__Offset, value._this.Get()); }
			
		}
		
		static readonly int StartOffset__Offset;
		/// <summary>The offset into the beginning of the animation clip</summary>
		public float StartOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+StartOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+StartOffset__Offset, false);}
			
		}
		
		static readonly int EndOffset__Offset;
		/// <summary>The offset into the end of the animation clip</summary>
		public float EndOffset
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EndOffset__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EndOffset__Offset, false);}
			
		}
		
		static readonly int PlayRate__Offset;
		/// <summary>The playback rate of the animation clip</summary>
		public float PlayRate
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PlayRate__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PlayRate__Offset, false);}
			
		}
		
		static readonly int bReverse__Offset;
		/// <summary>Reverse the playback of the animation clip</summary>
		public bool bReverse
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bReverse__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bReverse__Offset, 1,0,1,1);}
			
		}
		
		static readonly int SlotName__Offset;
		/// <summary>The slot name to use for the animation</summary>
		public FName SlotName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+SlotName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+SlotName__Offset, false);}
			
		}
		
		static UMovieSceneSkeletalAnimationSection()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("MovieSceneSkeletalAnimationSection");
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
