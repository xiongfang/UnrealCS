#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class USubsurfaceProfile
	{
		static readonly int Settings__Offset;
		public FSubsurfaceProfileStruct Settings
		{
			get{ CheckIsValid();return (FSubsurfaceProfileStruct)Marshal.PtrToStructure(_this.Get()+Settings__Offset, typeof(FSubsurfaceProfileStruct));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Settings__Offset, false);}
			
		}
		
		static USubsurfaceProfile()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("SubsurfaceProfile");
			Settings__Offset=GetPropertyOffset(NativeClassPtr,"Settings");
			
		}
		
	}
	
}
#endif
#endif
