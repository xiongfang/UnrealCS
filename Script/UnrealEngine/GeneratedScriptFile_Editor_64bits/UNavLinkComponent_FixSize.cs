#if WITH_EDITOR
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavLinkComponent
	{
		static readonly int Links__Offset;
		public TStructArray<FNavigationLink> Links
		{
			get{ CheckIsValid();return new TStructArray<FNavigationLink>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Links__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Links__Offset, false);}
			
		}
		
		static UNavLinkComponent()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavLinkComponent");
			Links__Offset=GetPropertyOffset(NativeClassPtr,"Links");
			
		}
		
	}
	
}
#endif
#endif
