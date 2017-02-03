#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Sound node that contains a reference to the dialogue table to pull from and be played</summary>
	public partial class USoundNodeDialoguePlayer
	{
		static readonly int DialogueWaveParameter__Offset;
		public FDialogueWaveParameter DialogueWaveParameter
		{
			get{ CheckIsValid();return (FDialogueWaveParameter)Marshal.PtrToStructure(_this.Get()+DialogueWaveParameter__Offset, typeof(FDialogueWaveParameter));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+DialogueWaveParameter__Offset, false);}
			
		}
		
		static readonly int bLooping__Offset;
		/// <summary>Whether the dialogue line should be played looping</summary>
		public bool bLooping
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bLooping__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bLooping__Offset, 1,0,1,1);}
			
		}
		
		static USoundNodeDialoguePlayer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeDialoguePlayer");
			DialogueWaveParameter__Offset=GetPropertyOffset(NativeClassPtr,"DialogueWaveParameter");
			bLooping__Offset=GetPropertyOffset(NativeClassPtr,"bLooping");
			
		}
		
	}
	
}
#endif
#endif
