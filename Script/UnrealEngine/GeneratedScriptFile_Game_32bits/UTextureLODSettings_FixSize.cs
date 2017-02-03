#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UTextureLODSettings
	{
		static readonly int TextureLODGroups__Offset;
		public TStructArray<FTextureLODGroup> TextureLODGroups
		{
			get{ CheckIsValid();return new TStructArray<FTextureLODGroup>((FScriptArray)Marshal.PtrToStructure(_this.Get()+TextureLODGroups__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+TextureLODGroups__Offset, false);}
			
		}
		
		static UTextureLODSettings()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("TextureLODSettings");
			TextureLODGroups__Offset=GetPropertyOffset(NativeClassPtr,"TextureLODGroups");
			
		}
		
	}
	
}
#endif
#endif
