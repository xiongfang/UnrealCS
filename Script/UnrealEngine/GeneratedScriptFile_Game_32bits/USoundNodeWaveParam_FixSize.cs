#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeWaveParam
	{
		static readonly int WaveParameterName__Offset;
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
