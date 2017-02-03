#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UInterpTrackSound
	{
		static readonly int Sounds__Offset;
		/// <summary>Array of sounds to play at specific times.</summary>
		public TStructArray<FSoundTrackKey> Sounds
		{
			get{ CheckIsValid();return new TStructArray<FSoundTrackKey>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Sounds__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Sounds__Offset, false);}
			
		}
		
		static readonly int bPlayOnReverse__Offset;
		/// <summary>if set, sound plays only when playing the matinee in reverse instead of when the matinee plays forward</summary>
		public bool bPlayOnReverse
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bPlayOnReverse__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bPlayOnReverse__Offset, 1,0,1,1);}
			
		}
		
		static readonly int bContinueSoundOnMatineeEnd__Offset;
		/// <summary>If true, sounds on this track will not be forced to finish when the matinee sequence finishes.</summary>
		public bool bContinueSoundOnMatineeEnd
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bContinueSoundOnMatineeEnd__Offset, 1, 0, 2, 2);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bContinueSoundOnMatineeEnd__Offset, 1,0,2,2);}
			
		}
		
		static readonly int bSuppressSubtitles__Offset;
		/// <summary>If true, don't show subtitles for sounds played by this track.</summary>
		public bool bSuppressSubtitles
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bSuppressSubtitles__Offset, 1, 0, 4, 4);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bSuppressSubtitles__Offset, 1,0,4,4);}
			
		}
		
		static readonly int bTreatAsDialogue__Offset;
		/// <summary>If true and track is controlling a pawn, makes the pawn "speak" the given audio.</summary>
		public bool bTreatAsDialogue
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bTreatAsDialogue__Offset, 1, 0, 8, 8);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bTreatAsDialogue__Offset, 1,0,8,8);}
			
		}
		
		static readonly int bAttach__Offset;
		public bool bAttach
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bAttach__Offset, 1, 0, 16, 16);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bAttach__Offset, 1,0,16,16);}
			
		}
		
		static UInterpTrackSound()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("InterpTrackSound");
			Sounds__Offset=GetPropertyOffset(NativeClassPtr,"Sounds");
			bPlayOnReverse__Offset=GetPropertyOffset(NativeClassPtr,"bPlayOnReverse");
			bContinueSoundOnMatineeEnd__Offset=GetPropertyOffset(NativeClassPtr,"bContinueSoundOnMatineeEnd");
			bSuppressSubtitles__Offset=GetPropertyOffset(NativeClassPtr,"bSuppressSubtitles");
			bTreatAsDialogue__Offset=GetPropertyOffset(NativeClassPtr,"bTreatAsDialogue");
			bAttach__Offset=GetPropertyOffset(NativeClassPtr,"bAttach");
			
		}
		
	}
	
}
#endif
#endif
