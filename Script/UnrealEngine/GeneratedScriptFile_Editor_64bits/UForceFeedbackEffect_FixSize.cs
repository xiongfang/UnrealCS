#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>A predefined force-feedback effect to be played on a controller</summary>
	public partial class UForceFeedbackEffect
	{
		static readonly int ChannelDetails__Offset;
		public TStructArray<FForceFeedbackChannelDetails> ChannelDetails
		{
			get{ CheckIsValid();return new TStructArray<FForceFeedbackChannelDetails>((FScriptArray)Marshal.PtrToStructure(_this.Get()+ChannelDetails__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+ChannelDetails__Offset, false);}
			
		}
		
		static readonly int Duration__Offset;
		/// <summary>Duration of force feedback pattern in seconds.</summary>
		public float Duration
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+Duration__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Duration__Offset, false);}
			
		}
		
		static UForceFeedbackEffect()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("ForceFeedbackEffect");
			ChannelDetails__Offset=GetPropertyOffset(NativeClassPtr,"ChannelDetails");
			Duration__Offset=GetPropertyOffset(NativeClassPtr,"Duration");
			
		}
		
	}
	
}
#endif
#endif
