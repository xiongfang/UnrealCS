#if WITH_GAME
#if PLATFORM_32BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UNavigationQueryFilter
	{
		static readonly int Areas__Offset;
		public TStructArray<FNavigationFilterArea> Areas
		{
			get{ CheckIsValid();return new TStructArray<FNavigationFilterArea>((FScriptArray)Marshal.PtrToStructure(_this.Get()+Areas__Offset, typeof(FScriptArray)));}
					set{ CheckIsValid();Marshal.StructureToPtr(value.InterArray, _this.Get()+Areas__Offset, false);}
			
		}
		
		static readonly int IncludeFlags__Offset;
		public FNavigationFilterFlags IncludeFlags
		{
			get{ CheckIsValid();return (FNavigationFilterFlags)Marshal.PtrToStructure(_this.Get()+IncludeFlags__Offset, typeof(FNavigationFilterFlags));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+IncludeFlags__Offset, false);}
			
		}
		
		static readonly int ExcludeFlags__Offset;
		public FNavigationFilterFlags ExcludeFlags
		{
			get{ CheckIsValid();return (FNavigationFilterFlags)Marshal.PtrToStructure(_this.Get()+ExcludeFlags__Offset, typeof(FNavigationFilterFlags));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+ExcludeFlags__Offset, false);}
			
		}
		
		static UNavigationQueryFilter()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("NavigationQueryFilter");
			Areas__Offset=GetPropertyOffset(NativeClassPtr,"Areas");
			IncludeFlags__Offset=GetPropertyOffset(NativeClassPtr,"IncludeFlags");
			ExcludeFlags__Offset=GetPropertyOffset(NativeClassPtr,"ExcludeFlags");
			
		}
		
	}
	
}
#endif
#endif
