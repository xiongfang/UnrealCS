#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UDeviceProfileManager
	{
		static readonly int Profiles__Offset;
		public TObjectArray<UObject>  Profiles
		{
					get{ CheckIsValid();return new TObjectArray<UObject>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Profiles__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Profiles__Offset, false);}
			
		}
		
		static UDeviceProfileManager()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("DeviceProfileManager");
			Profiles__Offset=GetPropertyOffset(NativeClassPtr,"Profiles");
			
		}
		
	}
	
}
#endif
#endif
