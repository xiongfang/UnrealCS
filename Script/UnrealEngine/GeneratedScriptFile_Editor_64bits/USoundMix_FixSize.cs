#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundMix
	{
		static readonly int bApplyEQ__Offset;
		/// <summary>Whether to apply the EQ effect</summary>
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
		/// <summary>Array of changes to be applied to groups.</summary>
		public TStructArray<FSoundClassAdjuster> SoundClassEffects
		{
			get{ CheckIsValid();return new TStructArray<FSoundClassAdjuster>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SoundClassEffects__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SoundClassEffects__Offset, false);}
			
		}
		
		static readonly int InitialDelay__Offset;
		/// <summary>Initial delay in seconds before the the mix is applied.</summary>
		public float InitialDelay
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+InitialDelay__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+InitialDelay__Offset, false);}
			
		}
		
		static readonly int FadeInTime__Offset;
		/// <summary>Time taken in seconds for the mix to fade in.</summary>
		public float FadeInTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FadeInTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FadeInTime__Offset, false);}
			
		}
		
		static readonly int Duration__Offset;
		/// <summary>Duration of mix, negative means it will be applied until another mix is set.</summary>
		public float Duration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Duration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Duration__Offset, false);}
			
		}
		
		static readonly int FadeOutTime__Offset;
		/// <summary>Time taken in seconds for the mix to fade out.</summary>
		public float FadeOutTime
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+FadeOutTime__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+FadeOutTime__Offset, false);}
			
		}
		
		static readonly int bChanged__Offset;
		/// <summary>Transient property used to trigger real-time updates of the active EQ filter for editor previewing</summary>
		public bool bChanged
		{
			get{ CheckIsValid();return BoolWrap.Get(_this.Get(), bChanged__Offset, 1, 0, 1, 1);}
			
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
			bChanged__Offset=GetPropertyOffset(NativeClassPtr,"bChanged");
			
		}
		
	}
	
}
#endif
#endif
