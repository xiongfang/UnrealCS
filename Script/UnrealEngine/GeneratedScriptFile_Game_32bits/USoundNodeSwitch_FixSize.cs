#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USoundNodeSwitch
	{
		static readonly int IntParameterName__Offset;
		public FName IntParameterName
		{
			get{ CheckIsValid();return (FName)Marshal.PtrToStructure(_this.Get()+IntParameterName__Offset, typeof(FName));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IntParameterName__Offset, false);}
			
		}
		
		static USoundNodeSwitch()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SoundNodeSwitch");
			IntParameterName__Offset=GetPropertyOffset(NativeClassPtr,"IntParameterName");
			
		}
		
	}
	
}
#endif
#endif
