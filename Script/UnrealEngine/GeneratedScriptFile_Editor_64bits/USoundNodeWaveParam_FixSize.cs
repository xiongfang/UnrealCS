#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	/// <summary>Sound node that takes a runtime parameter for the wave to play</summary>
	public partial class USoundNodeWaveParam
	{
		static readonly int WaveParameterName__Offset;
		/// <summary>The name of the wave parameter to use to look up the SoundWave we should play</summary>
		public FName WaveParameterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+WaveParameterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+WaveParameterName__Offset, false);}
			
		}
		
		static USoundNodeWaveParam()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeWaveParam");
			WaveParameterName__Offset=GetPropertyOffset(NativeClassPtr,"WaveParameterName");
			
		}
		
	}
	
}
#endif
#endif
