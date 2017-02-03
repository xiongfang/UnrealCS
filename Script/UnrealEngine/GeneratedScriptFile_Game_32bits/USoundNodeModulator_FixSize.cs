#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeModulator
	{
		static readonly int PitchMin__Offset;
		public float PitchMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchMin__Offset, false);}
			
		}
		
		static readonly int PitchMax__Offset;
		public float PitchMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+PitchMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+PitchMax__Offset, false);}
			
		}
		
		static readonly int VolumeMin__Offset;
		public float VolumeMin
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeMin__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeMin__Offset, false);}
			
		}
		
		static readonly int VolumeMax__Offset;
		public float VolumeMax
		{
			get{ CheckIsValid();return (float)Marshal.PtrToStructure(_this.Get()+VolumeMax__Offset, typeof(float));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+VolumeMax__Offset, false);}
			
		}
		
		static USoundNodeModulator()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeModulator");
			PitchMin__Offset=GetPropertyOffset(NativeClassPtr,"PitchMin");
			PitchMax__Offset=GetPropertyOffset(NativeClassPtr,"PitchMax");
			VolumeMin__Offset=GetPropertyOffset(NativeClassPtr,"VolumeMin");
			VolumeMax__Offset=GetPropertyOffset(NativeClassPtr,"VolumeMax");
			
		}
		
	}
	
}
#endif
#endif
