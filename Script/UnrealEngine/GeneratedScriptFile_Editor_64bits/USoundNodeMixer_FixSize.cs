#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Defines how concurrent sounds are mixed together</summary>
	public partial class USoundNodeMixer
	{
		static readonly int InputVolume__Offset;
		/// <summary>A volume for each input.  Automatically sized.</summary>
		public TStructArray<float> InputVolume
		{
			get{ CheckIsValid();return new TStructArray<float>((FScriptArray)Marshal.PtrToStructure(_this.Get()+InputVolume__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+InputVolume__Offset, false);}
			
		}
		
		static USoundNodeMixer()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeMixer");
			InputVolume__Offset=GetPropertyOffset(NativeClassPtr,"InputVolume");
			
		}
		
	}
	
}
#endif
#endif
