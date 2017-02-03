#if WITH_GAME
#if PLATFORM_64BITS
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine
{
	public partial class UWidgetNavigation
	{
		static readonly int Up__Offset;
		public FWidgetNavigationData Up
		{
			get{ CheckIsValid();return (FWidgetNavigationData)Marshal.PtrToStructure(_this.Get()+Up__Offset, typeof(FWidgetNavigationData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Up__Offset, false);}
			
		}
		
		static readonly int Down__Offset;
		public FWidgetNavigationData Down
		{
			get{ CheckIsValid();return (FWidgetNavigationData)Marshal.PtrToStructure(_this.Get()+Down__Offset, typeof(FWidgetNavigationData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Down__Offset, false);}
			
		}
		
		static readonly int Left__Offset;
		public FWidgetNavigationData Left
		{
			get{ CheckIsValid();return (FWidgetNavigationData)Marshal.PtrToStructure(_this.Get()+Left__Offset, typeof(FWidgetNavigationData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Left__Offset, false);}
			
		}
		
		static readonly int Right__Offset;
		public FWidgetNavigationData Right
		{
			get{ CheckIsValid();return (FWidgetNavigationData)Marshal.PtrToStructure(_this.Get()+Right__Offset, typeof(FWidgetNavigationData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Right__Offset, false);}
			
		}
		
		static readonly int Next__Offset;
		public FWidgetNavigationData Next
		{
			get{ CheckIsValid();return (FWidgetNavigationData)Marshal.PtrToStructure(_this.Get()+Next__Offset, typeof(FWidgetNavigationData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Next__Offset, false);}
			
		}
		
		static readonly int Previous__Offset;
		public FWidgetNavigationData Previous
		{
			get{ CheckIsValid();return (FWidgetNavigationData)Marshal.PtrToStructure(_this.Get()+Previous__Offset, typeof(FWidgetNavigationData));}
			set{ CheckIsValid();Marshal.StructureToPtr(value, _this.Get()+Previous__Offset, false);}
			
		}
		
		static UWidgetNavigation()
		{
			IntPtr NativeClassPtr=GetNativeClassFromName("WidgetNavigation");
			Up__Offset=GetPropertyOffset(NativeClassPtr,"Up");
			Down__Offset=GetPropertyOffset(NativeClassPtr,"Down");
			Left__Offset=GetPropertyOffset(NativeClassPtr,"Left");
			Right__Offset=GetPropertyOffset(NativeClassPtr,"Right");
			Next__Offset=GetPropertyOffset(NativeClassPtr,"Next");
			Previous__Offset=GetPropertyOffset(NativeClassPtr,"Previous");
			
		}
		
	}
	
}
#endif
#endif
