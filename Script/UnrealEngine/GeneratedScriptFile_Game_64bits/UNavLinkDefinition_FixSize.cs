#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavLinkDefinition
	{
		static readonly int Links__Offset;
		public TStructArray<FNavigationLink> Links
		{
			get{ CheckIsValid();return new TStructArray<FNavigationLink>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Links__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Links__Offset, false);}
			
		}
		
		static readonly int SegmentLinks__Offset;
		public TStructArray<FNavigationSegmentLink> SegmentLinks
		{
			get{ CheckIsValid();return new TStructArray<FNavigationSegmentLink>((FScriptArray)Marshal.PtrToStructure(_this.Get()+SegmentLinks__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+SegmentLinks__Offset, false);}
			
		}
		
		static UNavLinkDefinition()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavLinkDefinition");
			Links__Offset=GetPropertyOffset(NativeClassPtr,"Links");
			SegmentLinks__Offset=GetPropertyOffset(NativeClassPtr,"SegmentLinks");
			
		}
		
	}
	
}
#endif
#endif
