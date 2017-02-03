#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class ULightmassPrimitiveSettingsObject
	{
		static readonly int LightmassSettings__Offset;
		public FLightmassPrimitiveSettings LightmassSettings
		{
			get{ CheckIsValid();return (FLightmassPrimitiveSettings)Marshal.PtrToStructure(_this.Get()+LightmassSettings__Offset, typeof(FLightmassPrimitiveSettings));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+LightmassSettings__Offset, false);}
			
		}
		
		static ULightmassPrimitiveSettingsObject()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("LightmassPrimitiveSettingsObject");
			LightmassSettings__Offset=GetPropertyOffset(NativeClassPtr,"LightmassSettings");
			
		}
		
	}
	
}
#endif
#endif
