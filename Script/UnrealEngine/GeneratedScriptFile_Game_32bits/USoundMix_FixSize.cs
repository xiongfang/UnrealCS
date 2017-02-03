#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundMix
	{
		static readonly int bApplyEQ__Offset;
		public bool bApplyEQ
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bApplyEQ__Offset, 1, 0, 1, 1);}
			set{ CheckIsValid();BoolWrap.Set(value,_this.Get(), bApplyEQ__Offset, 1,0,1,1);}
			
		}
		
		static readonly int EQPriority__Offset;
		public float EQPriority
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+EQPriority__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EQPriority__Offset, false);}
			
		}
		
		static readonly int EQSettings__Offset;
		public FAudioEQEffect EQSettings
		{
			get{ CheckIsValid();return (FAudioEQEffect)Marshal.PtrToStructure(_this.Get()+EQSettings__Offset, typeof(FAudioEQEffect));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+EQSettings__Offset, false);}
			
		}
		
		static readonly int SoundClassEffects__Offset;
		public TStructArray<FSoundClassAdjuster> SoundClassEffects
		{
			get{ CheckIsValid();return new TStructArray<FSoundClassAdjuster>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SoundClassEffects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SoundClassEffects__Offset, false);}
			
		}
		
		static readonly int InitialDelay__Offset;
		public float InitialDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialDelay__Offset, false);}
			
		}
		
		static readonly int FadeInTime__Offset;
		public float FadeInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FadeInTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FadeInTime__Offset, false);}
			
		}
		
		static readonly int Duration__Offset;
		public float Duration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Duration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Duration__Offset, false);}
			
		}
		
		static readonly int FadeOutTime__Offset;
		public float FadeOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FadeOutTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FadeOutTime__Offset, false);}
			
		}
		
		static USoundMix()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundMix");
			bApplyEQ__Offset=GetPropertyOffset(NativeClassPtr,"bApplyEQ");
			EQPriority__Offset=GetPropertyOffset(NativeClassPtr,"EQPriority");
			EQSettings__Offset=GetPropertyOffset(NativeClassPtr,"EQSettings");
			SoundClassEffects__Offset=GetPropertyOffset(NativeClassPtr,"SoundClassEffects");
			InitialDelay__Offset=GetPropertyOffset(NativeClassPtr,"InitialDelay");
			FadeInTime__Offset=GetPropertyOffset(NativeClassPtr,"FadeInTime");
			Duration__Offset=GetPropertyOffset(NativeClassPtr,"Duration");
			FadeOutTime__Offset=GetPropertyOffset(NativeClassPtr,"FadeOutTime");
			
		}
		
	}
	
}
#endif
#endif
